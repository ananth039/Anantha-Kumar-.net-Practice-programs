namespace Demo_on_NumericUpDown_and_DomainUpDown
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
            this.txtMyText = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.domFont = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMyText
            // 
            this.txtMyText.Location = new System.Drawing.Point(38, 67);
            this.txtMyText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMyText.Name = "txtMyText";
            this.txtMyText.Size = new System.Drawing.Size(586, 25);
            this.txtMyText.TabIndex = 0;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(35, 141);
            this.lblFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(45, 17);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(111, 208);
            this.numSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.ReadOnly = true;
            this.numSize.Size = new System.Drawing.Size(152, 25);
            this.numSize.TabIndex = 2;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(35, 208);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 17);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // domFont
            // 
            this.domFont.Items.Add("Times New Roman ");
            this.domFont.Items.Add("Tahoma");
            this.domFont.Items.Add(" Arial");
            this.domFont.Items.Add(" Arial Black");
            this.domFont.Items.Add(" Century Gothic");
            this.domFont.Items.Add(" Trebuchet MS ");
            this.domFont.Items.Add("Palatino Linotype ");
            this.domFont.Items.Add("Lucida Sans");
            this.domFont.Items.Add("jokerman");
            this.domFont.Location = new System.Drawing.Point(111, 139);
            this.domFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.domFont.Name = "domFont";
            this.domFont.ReadOnly = true;
            this.domFont.Size = new System.Drawing.Size(513, 25);
            this.domFont.TabIndex = 4;
            this.domFont.Text = "Tahoma ";
            this.domFont.SelectedItemChanged += new System.EventHandler(this.domFont_SelectedItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.domFont);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.txtMyText);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Demo on NumericUpDown and DomainUpDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMyText;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.DomainUpDown domFont;
    }
}

