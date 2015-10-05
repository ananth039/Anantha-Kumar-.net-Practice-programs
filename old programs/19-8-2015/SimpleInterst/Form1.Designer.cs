namespace SimpleInterst
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
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.lblEnterrateofinterst = new System.Windows.Forms.Label();
            this.lblEntertimeInyears = new System.Windows.Forms.Label();
            this.txtInputAmount = new System.Windows.Forms.TextBox();
            this.txtRateofInterst = new System.Windows.Forms.TextBox();
            this.txtTimeinyears = new System.Windows.Forms.TextBox();
            this.btnSimpleInterst = new System.Windows.Forms.Button();
            this.lblSimpleInterst = new System.Windows.Forms.Label();
            this.txtSimpleInterstResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Location = new System.Drawing.Point(28, 36);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(74, 13);
            this.lblEnterAmount.TabIndex = 0;
            this.lblEnterAmount.Text = "Enter  Amount";
            // 
            // lblEnterrateofinterst
            // 
            this.lblEnterrateofinterst.AutoSize = true;
            this.lblEnterrateofinterst.Location = new System.Drawing.Point(28, 76);
            this.lblEnterrateofinterst.Name = "lblEnterrateofinterst";
            this.lblEnterrateofinterst.Size = new System.Drawing.Size(104, 13);
            this.lblEnterrateofinterst.TabIndex = 1;
            this.lblEnterrateofinterst.Text = "Enter Rate Of Interst";
            // 
            // lblEntertimeInyears
            // 
            this.lblEntertimeInyears.AutoSize = true;
            this.lblEntertimeInyears.Location = new System.Drawing.Point(25, 111);
            this.lblEntertimeInyears.Name = "lblEntertimeInyears";
            this.lblEntertimeInyears.Size = new System.Drawing.Size(99, 13);
            this.lblEntertimeInyears.TabIndex = 2;
            this.lblEntertimeInyears.Text = "Enter Time in Years";
            // 
            // txtInputAmount
            // 
            this.txtInputAmount.Location = new System.Drawing.Point(168, 28);
            this.txtInputAmount.Name = "txtInputAmount";
            this.txtInputAmount.Size = new System.Drawing.Size(130, 20);
            this.txtInputAmount.TabIndex = 3;
            // 
            // txtRateofInterst
            // 
            this.txtRateofInterst.Location = new System.Drawing.Point(168, 68);
            this.txtRateofInterst.Name = "txtRateofInterst";
            this.txtRateofInterst.Size = new System.Drawing.Size(130, 20);
            this.txtRateofInterst.TabIndex = 4;
            this.txtRateofInterst.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTimeinyears
            // 
            this.txtTimeinyears.Location = new System.Drawing.Point(168, 104);
            this.txtTimeinyears.Name = "txtTimeinyears";
            this.txtTimeinyears.Size = new System.Drawing.Size(130, 20);
            this.txtTimeinyears.TabIndex = 5;
            // 
            // btnSimpleInterst
            // 
            this.btnSimpleInterst.Location = new System.Drawing.Point(136, 193);
            this.btnSimpleInterst.Name = "btnSimpleInterst";
            this.btnSimpleInterst.Size = new System.Drawing.Size(75, 23);
            this.btnSimpleInterst.TabIndex = 6;
            this.btnSimpleInterst.Text = "Calculate";
            this.btnSimpleInterst.UseVisualStyleBackColor = true;
            this.btnSimpleInterst.Click += new System.EventHandler(this.btnSimpleInterst_Click);
            // 
            // lblSimpleInterst
            // 
            this.lblSimpleInterst.AutoSize = true;
            this.lblSimpleInterst.Location = new System.Drawing.Point(31, 145);
            this.lblSimpleInterst.Name = "lblSimpleInterst";
            this.lblSimpleInterst.Size = new System.Drawing.Size(70, 13);
            this.lblSimpleInterst.TabIndex = 7;
            this.lblSimpleInterst.Text = "Simple Interst";
            // 
            // txtSimpleInterstResult
            // 
            this.txtSimpleInterstResult.Location = new System.Drawing.Point(168, 142);
            this.txtSimpleInterstResult.Name = "txtSimpleInterstResult";
            this.txtSimpleInterstResult.Size = new System.Drawing.Size(130, 20);
            this.txtSimpleInterstResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.txtSimpleInterstResult);
            this.Controls.Add(this.lblSimpleInterst);
            this.Controls.Add(this.btnSimpleInterst);
            this.Controls.Add(this.txtTimeinyears);
            this.Controls.Add(this.txtRateofInterst);
            this.Controls.Add(this.txtInputAmount);
            this.Controls.Add(this.lblEntertimeInyears);
            this.Controls.Add(this.lblEnterrateofinterst);
            this.Controls.Add(this.lblEnterAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Interst";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.Label lblEnterrateofinterst;
        private System.Windows.Forms.Label lblEntertimeInyears;
        private System.Windows.Forms.TextBox txtInputAmount;
        private System.Windows.Forms.TextBox txtRateofInterst;
        private System.Windows.Forms.TextBox txtTimeinyears;
        private System.Windows.Forms.Button btnSimpleInterst;
        private System.Windows.Forms.Label lblSimpleInterst;
        private System.Windows.Forms.TextBox txtSimpleInterstResult;
    }
}

