namespace AnnoyingFlooder
{
    partial class AnnoyingFlooder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.textBoxFilesize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.progressBarWrite = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerWrite = new System.ComponentModel.BackgroundWorker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.saveFileDialogHidden = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filesize:";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(70, 24);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(178, 20);
            this.textBoxFilename.TabIndex = 2;
            // 
            // textBoxFilesize
            // 
            this.textBoxFilesize.Location = new System.Drawing.Point(67, 50);
            this.textBoxFilesize.Name = "textBoxFilesize";
            this.textBoxFilesize.Size = new System.Drawing.Size(58, 20);
            this.textBoxFilesize.TabIndex = 3;
            this.textBoxFilesize.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MB";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(254, 94);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // progressBarWrite
            // 
            this.progressBarWrite.Location = new System.Drawing.Point(15, 94);
            this.progressBarWrite.Name = "progressBarWrite";
            this.progressBarWrite.Size = new System.Drawing.Size(233, 23);
            this.progressBarWrite.TabIndex = 6;
            // 
            // backgroundWorkerWrite
            // 
            this.backgroundWorkerWrite.WorkerReportsProgress = true;
            this.backgroundWorkerWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerWrite_DoWork);
            this.backgroundWorkerWrite.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerWrite_ProgressChanged);
            this.backgroundWorkerWrite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerWrite_RunWorkerCompleted);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(254, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search...";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // AnnoyingFlooder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 133);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.progressBarWrite);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFilesize);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnnoyingFlooder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnnoyingFlooder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.TextBox textBoxFilesize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ProgressBar progressBarWrite;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWrite;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialogHidden;
    }
}

