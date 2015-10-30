namespace TTSWF
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
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.btnReadOut = new System.Windows.Forms.Button();
            this.cbSupportLanguages = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbxContent
            // 
            this.tbxContent.Location = new System.Drawing.Point(12, 12);
            this.tbxContent.MaxLength = 0;
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxContent.Size = new System.Drawing.Size(616, 331);
            this.tbxContent.TabIndex = 0;
            // 
            // btnReadOut
            // 
            this.btnReadOut.Location = new System.Drawing.Point(12, 376);
            this.btnReadOut.Name = "btnReadOut";
            this.btnReadOut.Size = new System.Drawing.Size(132, 23);
            this.btnReadOut.TabIndex = 1;
            this.btnReadOut.Text = "Read Text";
            this.btnReadOut.UseVisualStyleBackColor = true;
            this.btnReadOut.Click += new System.EventHandler(this.btnReadOut_Click);
            // 
            // cbSupportLanguages
            // 
            this.cbSupportLanguages.FormattingEnabled = true;
            this.cbSupportLanguages.Location = new System.Drawing.Point(12, 349);
            this.cbSupportLanguages.Name = "cbSupportLanguages";
            this.cbSupportLanguages.Size = new System.Drawing.Size(616, 21);
            this.cbSupportLanguages.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 402);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSupportLanguages);
            this.Controls.Add(this.btnReadOut);
            this.Controls.Add(this.tbxContent);
            this.Name = "Form1";
            this.Text = "Text to Speech v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.Button btnReadOut;
        private System.Windows.Forms.ComboBox cbSupportLanguages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

