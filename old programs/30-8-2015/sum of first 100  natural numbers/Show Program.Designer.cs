namespace sum_of_first_100__natural_numbers
{
    partial class Show_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Program));
            this.rtbSourceProgram = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSourceCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbSourceProgram
            // 
            this.rtbSourceProgram.Location = new System.Drawing.Point(24, 30);
            this.rtbSourceProgram.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSourceProgram.Name = "rtbSourceProgram";
            this.rtbSourceProgram.ReadOnly = true;
            this.rtbSourceProgram.Size = new System.Drawing.Size(668, 553);
            this.rtbSourceProgram.TabIndex = 0;
            this.rtbSourceProgram.Text = resources.GetString("rtbSourceProgram.Text");
            this.rtbSourceProgram.TextChanged += new System.EventHandler(this.rtbSourceProgram_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 615);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSourceCode
            // 
            this.lblSourceCode.AutoSize = true;
            this.lblSourceCode.Location = new System.Drawing.Point(21, 9);
            this.lblSourceCode.Name = "lblSourceCode";
            this.lblSourceCode.Size = new System.Drawing.Size(293, 17);
            this.lblSourceCode.TabIndex = 2;
            this.lblSourceCode.Text = "Source Code for  Console Application::";
            // 
            // Show_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 669);
            this.ControlBox = false;
            this.Controls.Add(this.lblSourceCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbSourceProgram);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Show_Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Program";
            this.Load += new System.EventHandler(this.Show_Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourceProgram;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSourceCode;
    }
}