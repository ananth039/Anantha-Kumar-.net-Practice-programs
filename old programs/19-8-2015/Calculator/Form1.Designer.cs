namespace Calculator
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
            this.lblEnterFirstNumber = new System.Windows.Forms.Label();
            this.lblEnterSecondNumber = new System.Windows.Forms.Label();
            this.txtInputFirstNumber = new System.Windows.Forms.TextBox();
            this.txtInputSecondNumber = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnpercentage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFirstNumber
            // 
            this.lblEnterFirstNumber.AutoSize = true;
            this.lblEnterFirstNumber.Location = new System.Drawing.Point(35, 61);
            this.lblEnterFirstNumber.Name = "lblEnterFirstNumber";
            this.lblEnterFirstNumber.Size = new System.Drawing.Size(91, 13);
            this.lblEnterFirstNumber.TabIndex = 0;
            this.lblEnterFirstNumber.Text = "Enter first Number";
            // 
            // lblEnterSecondNumber
            // 
            this.lblEnterSecondNumber.AutoSize = true;
            this.lblEnterSecondNumber.Location = new System.Drawing.Point(35, 97);
            this.lblEnterSecondNumber.Name = "lblEnterSecondNumber";
            this.lblEnterSecondNumber.Size = new System.Drawing.Size(112, 13);
            this.lblEnterSecondNumber.TabIndex = 1;
            this.lblEnterSecondNumber.Text = "Enter Second Number";
            // 
            // txtInputFirstNumber
            // 
            this.txtInputFirstNumber.Location = new System.Drawing.Point(174, 53);
            this.txtInputFirstNumber.Name = "txtInputFirstNumber";
            this.txtInputFirstNumber.Size = new System.Drawing.Size(135, 20);
            this.txtInputFirstNumber.TabIndex = 2;
            this.txtInputFirstNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInputSecondNumber
            // 
            this.txtInputSecondNumber.Location = new System.Drawing.Point(174, 89);
            this.txtInputSecondNumber.Name = "txtInputSecondNumber";
            this.txtInputSecondNumber.Size = new System.Drawing.Size(135, 20);
            this.txtInputSecondNumber.TabIndex = 3;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(51, 162);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(141, 162);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 5;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.txtSub_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(234, 162);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 6;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(51, 213);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnpercentage
            // 
            this.btnpercentage.Location = new System.Drawing.Point(141, 213);
            this.btnpercentage.Name = "btnpercentage";
            this.btnpercentage.Size = new System.Drawing.Size(75, 23);
            this.btnpercentage.TabIndex = 8;
            this.btnpercentage.Text = "%";
            this.btnpercentage.UseVisualStyleBackColor = true;
            this.btnpercentage.Click += new System.EventHandler(this.btnpercentage_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(38, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(174, 120);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(135, 20);
            this.txtResult.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(234, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnpercentage);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtInputSecondNumber);
            this.Controls.Add(this.txtInputFirstNumber);
            this.Controls.Add(this.lblEnterSecondNumber);
            this.Controls.Add(this.lblEnterFirstNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFirstNumber;
        private System.Windows.Forms.Label lblEnterSecondNumber;
        private System.Windows.Forms.TextBox txtInputFirstNumber;
        private System.Windows.Forms.TextBox txtInputSecondNumber;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnpercentage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
    }
}

