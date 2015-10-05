namespace datatype_sizes
{
    partial class lblSelectDataType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblSelectDataType));
            this.cmbDataTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinSize = new System.Windows.Forms.Label();
            this.lblMaximumsize = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.rtbMinSize = new System.Windows.Forms.RichTextBox();
            this.rtbMaxsize = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbDataTypes
            // 
            this.cmbDataTypes.FormattingEnabled = true;
            this.cmbDataTypes.Items.AddRange(new object[] {
            "SByte",
            "Byte",
            "Short",
            "UShort",
            "int",
            "Uint",
            "long",
            "Ulong",
            "float",
            "double",
            "decimal",
            "char"});
            this.cmbDataTypes.Location = new System.Drawing.Point(219, 65);
            this.cmbDataTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDataTypes.Name = "cmbDataTypes";
            this.cmbDataTypes.Size = new System.Drawing.Size(254, 23);
            this.cmbDataTypes.TabIndex = 0;
            this.cmbDataTypes.Text = "select data type";
            this.cmbDataTypes.SelectedIndexChanged += new System.EventHandler(this.cmbDataTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Data Type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinSize
            // 
            this.lblMinSize.AutoSize = true;
            this.lblMinSize.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSize.Location = new System.Drawing.Point(83, 198);
            this.lblMinSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinSize.Name = "lblMinSize";
            this.lblMinSize.Size = new System.Drawing.Size(97, 15);
            this.lblMinSize.TabIndex = 2;
            this.lblMinSize.Text = "Minimum Size:";
            this.lblMinSize.Click += new System.EventHandler(this.lblMinSize_Click);
            // 
            // lblMaximumsize
            // 
            this.lblMaximumsize.AutoSize = true;
            this.lblMaximumsize.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumsize.Location = new System.Drawing.Point(83, 290);
            this.lblMaximumsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximumsize.Name = "lblMaximumsize";
            this.lblMaximumsize.Size = new System.Drawing.Size(101, 15);
            this.lblMaximumsize.TabIndex = 3;
            this.lblMaximumsize.Text = "Maximum Size:";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataType.Location = new System.Drawing.Point(299, 149);
            this.lblDataType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(66, 15);
            this.lblDataType.TabIndex = 4;
            this.lblDataType.Text = "DataType";
            this.lblDataType.Click += new System.EventHandler(this.lblDataType_Click);
            // 
            // rtbMinSize
            // 
            this.rtbMinSize.Location = new System.Drawing.Point(204, 195);
            this.rtbMinSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbMinSize.Name = "rtbMinSize";
            this.rtbMinSize.ReadOnly = true;
            this.rtbMinSize.Size = new System.Drawing.Size(269, 31);
            this.rtbMinSize.TabIndex = 5;
            this.rtbMinSize.Text = "";
            // 
            // rtbMaxsize
            // 
            this.rtbMaxsize.Location = new System.Drawing.Point(204, 286);
            this.rtbMaxsize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbMaxsize.Name = "rtbMaxsize";
            this.rtbMaxsize.ReadOnly = true;
            this.rtbMaxsize.Size = new System.Drawing.Size(269, 31);
            this.rtbMaxsize.TabIndex = 6;
            this.rtbMaxsize.Text = "";
            // 
            // lblSelectDataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 378);
            this.Controls.Add(this.rtbMaxsize);
            this.Controls.Add(this.rtbMinSize);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.lblMaximumsize);
            this.Controls.Add(this.lblMinSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDataTypes);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "lblSelectDataType";
            this.Text = "DataType sizes";
            this.Load += new System.EventHandler(this.lblSelectDataType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinSize;
        private System.Windows.Forms.Label lblMaximumsize;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.RichTextBox rtbMinSize;
        private System.Windows.Forms.RichTextBox rtbMaxsize;
    }
}

