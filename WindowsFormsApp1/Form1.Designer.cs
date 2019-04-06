namespace WindowsFormsApp1
{
    partial class Form1
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
            this.InjectButton = new System.Windows.Forms.Button();
            this.ProcessNameTXT = new System.Windows.Forms.TextBox();
            this.OpenBrowseFiles = new System.Windows.Forms.Button();
            this.DLLPathTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InjectButton
            // 
            this.InjectButton.Location = new System.Drawing.Point(12, 87);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(75, 23);
            this.InjectButton.TabIndex = 0;
            this.InjectButton.Text = "Inject";
            this.InjectButton.UseVisualStyleBackColor = true;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // ProcessNameTXT
            // 
            this.ProcessNameTXT.Location = new System.Drawing.Point(11, 61);
            this.ProcessNameTXT.Name = "ProcessNameTXT";
            this.ProcessNameTXT.Size = new System.Drawing.Size(101, 20);
            this.ProcessNameTXT.TabIndex = 1;
            this.ProcessNameTXT.Text = "Process Name";
            // 
            // OpenBrowseFiles
            // 
            this.OpenBrowseFiles.Location = new System.Drawing.Point(118, 58);
            this.OpenBrowseFiles.Name = "OpenBrowseFiles";
            this.OpenBrowseFiles.Size = new System.Drawing.Size(75, 23);
            this.OpenBrowseFiles.TabIndex = 2;
            this.OpenBrowseFiles.Text = "Open";
            this.OpenBrowseFiles.UseVisualStyleBackColor = true;
            this.OpenBrowseFiles.Click += new System.EventHandler(this.OpenBrowseFiles_Click);
            // 
            // DLLPathTXT
            // 
            this.DLLPathTXT.Location = new System.Drawing.Point(11, 32);
            this.DLLPathTXT.Name = "DLLPathTXT";
            this.DLLPathTXT.Size = new System.Drawing.Size(181, 20);
            this.DLLPathTXT.TabIndex = 4;
            this.DLLPathTXT.Text = "File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CRNYY\'s Injector";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(200, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DLLPathTXT);
            this.Controls.Add(this.OpenBrowseFiles);
            this.Controls.Add(this.ProcessNameTXT);
            this.Controls.Add(this.InjectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "CRNYY\'s Injector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InjectButton;
        private System.Windows.Forms.TextBox ProcessNameTXT;
        private System.Windows.Forms.Button OpenBrowseFiles;
        private System.Windows.Forms.TextBox DLLPathTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

