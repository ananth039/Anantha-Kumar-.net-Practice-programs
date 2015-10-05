namespace Demo_on_TrackBar
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
            this.lblFontSize = new System.Windows.Forms.Label();
            this.trkFontSize = new System.Windows.Forms.TrackBar();
            this.lblMyText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(35, 55);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(71, 15);
            this.lblFontSize.TabIndex = 0;
            this.lblFontSize.Text = "Font Size:";
            // 
            // trkFontSize
            // 
            this.trkFontSize.Location = new System.Drawing.Point(142, 42);
            this.trkFontSize.Maximum = 200;
            this.trkFontSize.Minimum = 1;
            this.trkFontSize.Name = "trkFontSize";
            this.trkFontSize.Size = new System.Drawing.Size(104, 45);
            this.trkFontSize.TabIndex = 1;
            this.trkFontSize.TickFrequency = 5;
            this.trkFontSize.Value = 1;
            this.trkFontSize.Scroll += new System.EventHandler(this.rkFontSize_Scroll);
            // 
            // lblMyText
            // 
            this.lblMyText.AutoSize = true;
            this.lblMyText.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyText.Location = new System.Drawing.Point(105, 143);
            this.lblMyText.Name = "lblMyText";
            this.lblMyText.Size = new System.Drawing.Size(107, 15);
            this.lblMyText.TabIndex = 2;
            this.lblMyText.Text = "Windows Forms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 398);
            this.Controls.Add(this.lblMyText);
            this.Controls.Add(this.trkFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Name = "Form1";
            this.Text = "Demo On Track Bar";
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.TrackBar trkFontSize;
        private System.Windows.Forms.Label lblMyText;
    }
}

