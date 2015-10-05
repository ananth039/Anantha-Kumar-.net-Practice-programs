namespace sum_of_first_100__natural_numbers
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
            this.lblProblem = new System.Windows.Forms.Label();
            this.grpProbem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.btnShowCode = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.lblSquareofthesum = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSumOftheSquare = new System.Windows.Forms.Label();
            this.lblEnterLimitforNaturalNumbers = new System.Windows.Forms.Label();
            this.txtInputNaturalNumber = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpProbem.SuspendLayout();
            this.grpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Location = new System.Drawing.Point(20, 36);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(0, 17);
            this.lblProblem.TabIndex = 0;
            this.lblProblem.Click += new System.EventHandler(this.label1_Click);
            this.lblProblem.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // grpProbem
            // 
            this.grpProbem.Controls.Add(this.label1);
            this.grpProbem.Controls.Add(this.lblProblem);
            this.grpProbem.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProbem.Location = new System.Drawing.Point(12, 32);
            this.grpProbem.Name = "grpProbem";
            this.grpProbem.Size = new System.Drawing.Size(915, 293);
            this.grpProbem.TabIndex = 2;
            this.grpProbem.TabStop = false;
            this.grpProbem.Text = "Problem";
            this.grpProbem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // grpAnswer
            // 
            this.grpAnswer.Controls.Add(this.btnShowCode);
            this.grpAnswer.Controls.Add(this.lblAnswer);
            this.grpAnswer.Controls.Add(this.lblDiff);
            this.grpAnswer.Controls.Add(this.lblSum2);
            this.grpAnswer.Controls.Add(this.lblSquareofthesum);
            this.grpAnswer.Controls.Add(this.lblSum);
            this.grpAnswer.Controls.Add(this.lblSumOftheSquare);
            this.grpAnswer.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnswer.Location = new System.Drawing.Point(13, 332);
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.Size = new System.Drawing.Size(914, 264);
            this.grpAnswer.TabIndex = 3;
            this.grpAnswer.TabStop = false;
            this.grpAnswer.Text = "Answer";
            // 
            // btnShowCode
            // 
            this.btnShowCode.Location = new System.Drawing.Point(275, 216);
            this.btnShowCode.Name = "btnShowCode";
            this.btnShowCode.Size = new System.Drawing.Size(177, 42);
            this.btnShowCode.TabIndex = 6;
            this.btnShowCode.Text = "Show Program";
            this.btnShowCode.UseVisualStyleBackColor = true;
            this.btnShowCode.Click += new System.EventHandler(this.btnShowCode_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(336, 184);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(60, 17);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(39, 144);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(0, 17);
            this.lblDiff.TabIndex = 4;
            // 
            // lblSum2
            // 
            this.lblSum2.AutoSize = true;
            this.lblSum2.Location = new System.Drawing.Point(509, 95);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(45, 17);
            this.lblSum2.TabIndex = 3;
            this.lblSum2.Text = "Total";
            // 
            // lblSquareofthesum
            // 
            this.lblSquareofthesum.AutoSize = true;
            this.lblSquareofthesum.Location = new System.Drawing.Point(39, 95);
            this.lblSquareofthesum.Name = "lblSquareofthesum";
            this.lblSquareofthesum.Size = new System.Drawing.Size(0, 17);
            this.lblSquareofthesum.TabIndex = 2;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(509, 52);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(45, 17);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "Total";
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // lblSumOftheSquare
            // 
            this.lblSumOftheSquare.AutoSize = true;
            this.lblSumOftheSquare.Location = new System.Drawing.Point(72, 52);
            this.lblSumOftheSquare.Name = "lblSumOftheSquare";
            this.lblSumOftheSquare.Size = new System.Drawing.Size(0, 17);
            this.lblSumOftheSquare.TabIndex = 0;
            // 
            // lblEnterLimitforNaturalNumbers
            // 
            this.lblEnterLimitforNaturalNumbers.AutoSize = true;
            this.lblEnterLimitforNaturalNumbers.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLimitforNaturalNumbers.Location = new System.Drawing.Point(76, 625);
            this.lblEnterLimitforNaturalNumbers.Name = "lblEnterLimitforNaturalNumbers";
            this.lblEnterLimitforNaturalNumbers.Size = new System.Drawing.Size(198, 15);
            this.lblEnterLimitforNaturalNumbers.TabIndex = 7;
            this.lblEnterLimitforNaturalNumbers.Text = "Enter limit for natural Numbers";
            this.lblEnterLimitforNaturalNumbers.Click += new System.EventHandler(this.lblEnterLimitforNaturalNumbers_Click);
            // 
            // txtInputNaturalNumber
            // 
            this.txtInputNaturalNumber.Location = new System.Drawing.Point(324, 623);
            this.txtInputNaturalNumber.Name = "txtInputNaturalNumber";
            this.txtInputNaturalNumber.Size = new System.Drawing.Size(222, 20);
            this.txtInputNaturalNumber.TabIndex = 8;
            this.txtInputNaturalNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(636, 610);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 41);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 666);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInputNaturalNumber);
            this.Controls.Add(this.lblEnterLimitforNaturalNumbers);
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.grpProbem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sum of the Square of nthne First 100 Natuaral Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.grpProbem.ResumeLayout(false);
            this.grpProbem.PerformLayout();
            this.grpAnswer.ResumeLayout(false);
            this.grpAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.GroupBox grpProbem;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSumOftheSquare;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblSum2;
        private System.Windows.Forms.Label lblSquareofthesum;
        private System.Windows.Forms.Button btnShowCode;
        private System.Windows.Forms.Label lblEnterLimitforNaturalNumbers;
        private System.Windows.Forms.TextBox txtInputNaturalNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
    }
}

