namespace isPrime_Iseven_IsOdd_Reverse_number
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.btnPrime = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnReverseNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(34, 41);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(72, 13);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter Number";
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(164, 38);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(225, 20);
            this.txtInputNumber.TabIndex = 1;
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(48, 102);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(75, 23);
            this.btnPrime.TabIndex = 2;
            this.btnPrime.Text = "Prime";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(139, 101);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(75, 23);
            this.btnEven.TabIndex = 3;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(233, 101);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(75, 23);
            this.btnOdd.TabIndex = 4;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(332, 101);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial.TabIndex = 5;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnReverseNumber
            // 
            this.btnReverseNumber.Location = new System.Drawing.Point(164, 155);
            this.btnReverseNumber.Name = "btnReverseNumber";
            this.btnReverseNumber.Size = new System.Drawing.Size(119, 23);
            this.btnReverseNumber.TabIndex = 6;
            this.btnReverseNumber.Text = "Reverse Number";
            this.btnReverseNumber.UseVisualStyleBackColor = true;
            this.btnReverseNumber.Click += new System.EventHandler(this.btnReverseNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.btnReverseNumber);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multifunctional Opertions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnReverseNumber;
    }
}

