namespace Reverse_Number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtoutputNumber = new System.Windows.Forms.TextBox();
            this.lblReverseNumber = new System.Windows.Forms.Label();
            this.btnReverseNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(133, 53);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(112, 20);
            this.txtInputNumber.TabIndex = 0;
           
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(27, 56);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(72, 13);
            this.lblEnterNumber.TabIndex = 1;
            this.lblEnterNumber.Text = "Enter Number";
            // 
            // txtoutputNumber
            // 
            this.txtoutputNumber.Location = new System.Drawing.Point(133, 97);
            this.txtoutputNumber.Name = "txtoutputNumber";
            this.txtoutputNumber.Size = new System.Drawing.Size(112, 20);
            this.txtoutputNumber.TabIndex = 2;
                      // 
            // lblReverseNumber
            // 
            this.lblReverseNumber.AutoSize = true;
            this.lblReverseNumber.Location = new System.Drawing.Point(30, 97);
            this.lblReverseNumber.Name = "lblReverseNumber";
            this.lblReverseNumber.Size = new System.Drawing.Size(87, 13);
            this.lblReverseNumber.TabIndex = 3;
            this.lblReverseNumber.Text = "Reverse Number";
            // 
            // btnReverseNumber
            // 
            this.btnReverseNumber.Location = new System.Drawing.Point(117, 156);
            this.btnReverseNumber.Name = "btnReverseNumber";
            this.btnReverseNumber.Size = new System.Drawing.Size(75, 23);
            this.btnReverseNumber.TabIndex = 4;
            this.btnReverseNumber.Text = "Reverse";
            this.btnReverseNumber.UseVisualStyleBackColor = true;
            this.btnReverseNumber.Click += new System.EventHandler(this.btnReverseNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnReverseNumber);
            this.Controls.Add(this.lblReverseNumber);
            this.Controls.Add(this.txtoutputNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.txtInputNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reverse Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtoutputNumber;
        private System.Windows.Forms.Label lblReverseNumber;
        private System.Windows.Forms.Button btnReverseNumber;
    }
}

