namespace traffic_signal
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
            this.lblEnterTrafficSignalNumber = new System.Windows.Forms.Label();
            this.txtInpusignalNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTrafficSignaloutput = new System.Windows.Forms.TextBox();
            this.lblTraffcSignal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterTrafficSignalNumber
            // 
            this.lblEnterTrafficSignalNumber.AutoSize = true;
            this.lblEnterTrafficSignalNumber.Location = new System.Drawing.Point(23, 64);
            this.lblEnterTrafficSignalNumber.Name = "lblEnterTrafficSignalNumber";
            this.lblEnterTrafficSignalNumber.Size = new System.Drawing.Size(129, 13);
            this.lblEnterTrafficSignalNumber.TabIndex = 0;
            this.lblEnterTrafficSignalNumber.Text = "Enter traffic signal number";
            // 
            // txtInpusignalNumber
            // 
            this.txtInpusignalNumber.Location = new System.Drawing.Point(178, 61);
            this.txtInpusignalNumber.Name = "txtInpusignalNumber";
            this.txtInpusignalNumber.Size = new System.Drawing.Size(137, 20);
            this.txtInpusignalNumber.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(135, 143);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTrafficSignaloutput
            // 
            this.txtTrafficSignaloutput.Location = new System.Drawing.Point(178, 101);
            this.txtTrafficSignaloutput.Name = "txtTrafficSignaloutput";
            this.txtTrafficSignaloutput.Size = new System.Drawing.Size(137, 20);
            this.txtTrafficSignaloutput.TabIndex = 3;
            this.txtTrafficSignaloutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTraffcSignal
            // 
            this.lblTraffcSignal.AutoSize = true;
            this.lblTraffcSignal.Location = new System.Drawing.Point(23, 108);
            this.lblTraffcSignal.Name = "lblTraffcSignal";
            this.lblTraffcSignal.Size = new System.Drawing.Size(72, 13);
            this.lblTraffcSignal.TabIndex = 4;
            this.lblTraffcSignal.Text = "Trafffic Signal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.lblTraffcSignal);
            this.Controls.Add(this.txtTrafficSignaloutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInpusignalNumber);
            this.Controls.Add(this.lblEnterTrafficSignalNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Traffic Signals(0,1,2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTrafficSignalNumber;
        private System.Windows.Forms.TextBox txtInpusignalNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTrafficSignaloutput;
        private System.Windows.Forms.Label lblTraffcSignal;
    }
}

