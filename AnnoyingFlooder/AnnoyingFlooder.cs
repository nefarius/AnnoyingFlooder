using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Text.RegularExpressions;

namespace AnnoyingFlooder
{
    public partial class AnnoyingFlooder : Form
    {
        #region WinAPI
        private enum FILE_ACCESS_RIGHTS : uint
        {
            GENERIC_READ = 0x80000000,
            GENERIC_WRITE = 0x40000000
        }

        private enum FILE_FLAGS : uint
        {
            WriteThrough = 0x80000000,
            Overlapped = 0x40000000,
            NoBuffering = 0x20000000,
            RandomAccess = 0x10000000,
            SequentialScan = 0x8000000,
            DeleteOnClose = 0x4000000,
            BackupSemantics = 0x2000000,
            PosixSemantics = 0x1000000,
            OpenReparsePoint = 0x200000,
            OpenNoRecall = 0x100000
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateFile(string fileName, 
            FILE_ACCESS_RIGHTS access, 
            FileShare share, 
            int securityAttributes, 
            FileMode creation, 
            FILE_FLAGS flags, 
            IntPtr templateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);
        #endregion

        public AnnoyingFlooder()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilename.Text))
            {
                if (MessageBox.Show("You didn't specify a file or directory name. " +
                    "If you leave this value blank, the stream will be created " +
                    "in the current working directory. Continue?",
                    "Filename empty",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.No)
                    return;
            }

            if (string.IsNullOrEmpty(textBoxFilesize.Text))
            {
                MessageBox.Show("You have to specify the size of the stream!",
                    "File/Stream size missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxStream.Text))
            {
                MessageBox.Show("You have to define the name of the stream. " +
                "Without, the original content of the file will be corrupted!", 
                "No stream name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            buttonGo.Enabled = false;
            progressBarWrite.Minimum = 0;
            progressBarWrite.Maximum = int.Parse(textBoxFilesize.Text);
            backgroundWorkerWrite.RunWorkerAsync();
        }

        private void backgroundWorkerWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            // Create new stream
            IntPtr fileHandle = CreateFile(textBoxFilename.Text + 
                ":" + textBoxStream.Text,
                FILE_ACCESS_RIGHTS.GENERIC_WRITE,
                FileShare.Write,
                0,
                FileMode.Create,
                0,
                IntPtr.Zero);

            FileStream writer =
                new FileStream(new SafeFileHandle(fileHandle, true), FileAccess.Write);

            byte[] buffer = new byte[1048576];
            for (int index = 0; index < int.Parse(textBoxFilesize.Text); index++)
            {
                writer.Write(buffer, 0, buffer.Length);
                backgroundWorkerWrite.ReportProgress(index);
            }

            writer.Close();
            CloseHandle(fileHandle);

            MessageBox.Show("Done!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorkerWrite_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarWrite.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerWrite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonGo.Enabled = true;
            progressBarWrite.Value = 0;
        }

        private void textBoxFilesize_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle backspace
            if (e.KeyChar == 8)
                return;
            // Only allow numbers
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (saveFileDialogHidden.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
                textBoxFilename.Text = saveFileDialogHidden.FileName;
        }

        private void textBoxStream_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle backspace
            if (e.KeyChar == 8)
                return;
            // Allow only letters, numbers, points and underscores
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"^[\w+\.]?$");
        }
    }
}
