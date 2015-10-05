namespace Demo_on_PictureBox
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
            this.lblEnterImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.rbNoraml = new System.Windows.Forms.RadioButton();
            this.rbStrech = new System.Windows.Forms.RadioButton();
            this.rbAutoSize = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.lblSizeMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterImagePath
            // 
            this.lblEnterImagePath.AutoSize = true;
            this.lblEnterImagePath.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterImagePath.Location = new System.Drawing.Point(31, 56);
            this.lblEnterImagePath.Name = "lblEnterImagePath";
            this.lblEnterImagePath.Size = new System.Drawing.Size(129, 17);
            this.lblEnterImagePath.TabIndex = 0;
            this.lblEnterImagePath.Text = "Enter Image path";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(196, 53);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(360, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(590, 38);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 39);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // picBoxImage
            // 
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxImage.Location = new System.Drawing.Point(34, 103);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(631, 193);
            this.picBoxImage.TabIndex = 3;
            this.picBoxImage.TabStop = false;
            // 
            // btnClearImage
            // 
            this.btnClearImage.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearImage.Location = new System.Drawing.Point(323, 311);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(98, 33);
            this.btnClearImage.TabIndex = 4;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // rbNoraml
            // 
            this.rbNoraml.AutoSize = true;
            this.rbNoraml.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoraml.Location = new System.Drawing.Point(108, 370);
            this.rbNoraml.Name = "rbNoraml";
            this.rbNoraml.Size = new System.Drawing.Size(79, 21);
            this.rbNoraml.TabIndex = 5;
            this.rbNoraml.TabStop = true;
            this.rbNoraml.Text = "Normal";
            this.rbNoraml.UseVisualStyleBackColor = true;
            this.rbNoraml.CheckedChanged += new System.EventHandler(this.rbNoraml_CheckedChanged);
            // 
            // rbStrech
            // 
            this.rbStrech.AutoSize = true;
            this.rbStrech.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStrech.Location = new System.Drawing.Point(213, 372);
            this.rbStrech.Name = "rbStrech";
            this.rbStrech.Size = new System.Drawing.Size(76, 21);
            this.rbStrech.TabIndex = 6;
            this.rbStrech.TabStop = true;
            this.rbStrech.Text = "Stretch";
            this.rbStrech.UseVisualStyleBackColor = true;
            this.rbStrech.CheckedChanged += new System.EventHandler(this.rbStrech_CheckedChanged);
            // 
            // rbAutoSize
            // 
            this.rbAutoSize.AutoSize = true;
            this.rbAutoSize.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutoSize.Location = new System.Drawing.Point(323, 372);
            this.rbAutoSize.Name = "rbAutoSize";
            this.rbAutoSize.Size = new System.Drawing.Size(98, 21);
            this.rbAutoSize.TabIndex = 7;
            this.rbAutoSize.TabStop = true;
            this.rbAutoSize.Text = "Auto Size";
            this.rbAutoSize.UseVisualStyleBackColor = true;
            this.rbAutoSize.CheckedChanged += new System.EventHandler(this.rbAutoSize_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCenter.Location = new System.Drawing.Point(470, 372);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(73, 21);
            this.rbCenter.TabIndex = 8;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZoom.Location = new System.Drawing.Point(597, 370);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(68, 21);
            this.rbZoom.TabIndex = 9;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged);
            // 
            // lblSizeMode
            // 
            this.lblSizeMode.AutoSize = true;
            this.lblSizeMode.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeMode.ForeColor = System.Drawing.Color.Red;
            this.lblSizeMode.Location = new System.Drawing.Point(12, 372);
            this.lblSizeMode.Name = "lblSizeMode";
            this.lblSizeMode.Size = new System.Drawing.Size(90, 17);
            this.lblSizeMode.TabIndex = 10;
            this.lblSizeMode.Text = "Size Mode:";
            this.lblSizeMode.Click += new System.EventHandler(this.lblSizeMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 423);
            this.Controls.Add(this.lblSizeMode);
            this.Controls.Add(this.rbZoom);
            this.Controls.Add(this.rbCenter);
            this.Controls.Add(this.rbAutoSize);
            this.Controls.Add(this.rbStrech);
            this.Controls.Add(this.rbNoraml);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.lblEnterImagePath);
            this.Name = "Form1";
            this.Text = "Form1Demo on PictureBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.RadioButton rbNoraml;
        private System.Windows.Forms.RadioButton rbStrech;
        private System.Windows.Forms.RadioButton rbAutoSize;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.Label lblSizeMode;
    }
}

