namespace PrimeFactorsOfn
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lboutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 96);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(125, 44);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(100, 20);
            this.txtInputNumber.TabIndex = 1;
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(25, 44);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(72, 13);
            this.lblEnterNumber.TabIndex = 2;
            this.lblEnterNumber.Text = "Enter Number";
            // 
            // lboutput
            // 
            this.lboutput.FormattingEnabled = true;
            this.lboutput.Location = new System.Drawing.Point(91, 145);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(120, 95);
            this.lboutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Prime factors of n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.ListBox lboutput;
    }
}

