namespace Demo_on_GroupBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpBackgroundColor = new System.Windows.Forms.GroupBox();
            this.grptxtForeGroundcolor = new System.Windows.Forms.GroupBox();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rb = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.grpBackgroundColor.SuspendLayout();
            this.grptxtForeGroundcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 33);
            this.textBox1.TabIndex = 0;
            // 
            // grpBackgroundColor
            // 
            this.grpBackgroundColor.Controls.Add(this.rbYellow);
            this.grpBackgroundColor.Controls.Add(this.rb);
            this.grpBackgroundColor.Controls.Add(this.rbWhite);
            this.grpBackgroundColor.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBackgroundColor.Location = new System.Drawing.Point(81, 114);
            this.grpBackgroundColor.Name = "grpBackgroundColor";
            this.grpBackgroundColor.Size = new System.Drawing.Size(287, 212);
            this.grpBackgroundColor.TabIndex = 1;
            this.grpBackgroundColor.TabStop = false;
            this.grpBackgroundColor.Text = "Text Box Background Color:";
            this.grpBackgroundColor.Enter += new System.EventHandler(this.grpBackgroundColor_Enter);
            this.grpBackgroundColor.MouseHover += new System.EventHandler(this.grpBackgroundColor_MouseHover);
            // 
            // grptxtForeGroundcolor
            // 
            this.grptxtForeGroundcolor.Controls.Add(this.rbOrange);
            this.grptxtForeGroundcolor.Controls.Add(this.rbGreen);
            this.grptxtForeGroundcolor.Controls.Add(this.rbBlue);
            this.grptxtForeGroundcolor.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptxtForeGroundcolor.Location = new System.Drawing.Point(415, 114);
            this.grptxtForeGroundcolor.Name = "grptxtForeGroundcolor";
            this.grptxtForeGroundcolor.Size = new System.Drawing.Size(312, 212);
            this.grptxtForeGroundcolor.TabIndex = 2;
            this.grptxtForeGroundcolor.TabStop = false;
            this.grptxtForeGroundcolor.Text = "TextBox Foreground color";
            this.grptxtForeGroundcolor.Enter += new System.EventHandler(this.grptxtForeGroundcolor_Enter);
            this.grptxtForeGroundcolor.MouseHover += new System.EventHandler(this.grptxtForeGroundcolor_MouseHover);
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWhite.Location = new System.Drawing.Point(102, 53);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(67, 21);
            this.rbWhite.TabIndex = 0;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb.Location = new System.Drawing.Point(102, 102);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(55, 21);
            this.rb.TabIndex = 1;
            this.rb.TabStop = true;
            this.rb.Text = "Red";
            this.rb.UseVisualStyleBackColor = true;
            this.rb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYellow.Location = new System.Drawing.Point(102, 159);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(75, 21);
            this.rbYellow.TabIndex = 2;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.rbYellow_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlue.Location = new System.Drawing.Point(112, 53);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(59, 21);
            this.rbBlue.TabIndex = 0;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGreen.Location = new System.Drawing.Point(112, 102);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(69, 21);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrange.Location = new System.Drawing.Point(112, 159);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(78, 21);
            this.rbOrange.TabIndex = 2;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.grptxtForeGroundcolor);
            this.Controls.Add(this.grpBackgroundColor);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Demo on GroupBox";
            this.grpBackgroundColor.ResumeLayout(false);
            this.grpBackgroundColor.PerformLayout();
            this.grptxtForeGroundcolor.ResumeLayout(false);
            this.grptxtForeGroundcolor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpBackgroundColor;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.GroupBox grptxtForeGroundcolor;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
    }
}

