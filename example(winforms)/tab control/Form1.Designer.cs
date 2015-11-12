namespace tab_control
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
            this.tbBackColor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbwhite = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.rbPink = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbBackColor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBackColor
            // 
            this.tbBackColor.Controls.Add(this.tabPage1);
            this.tbBackColor.Controls.Add(this.tabPage2);
            this.tbBackColor.Location = new System.Drawing.Point(22, 30);
            this.tbBackColor.Name = "tbBackColor";
            this.tbBackColor.SelectedIndex = 0;
            this.tbBackColor.Size = new System.Drawing.Size(457, 272);
            this.tbBackColor.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.rbwhite);
            this.tabPage1.Controls.Add(this.rbBlue);
            this.tabPage1.Controls.Add(this.rbGreen);
            this.tabPage1.Controls.Add(this.rbRed);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Back Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.rbGray);
            this.tabPage2.Controls.Add(this.rbBlack);
            this.tabPage2.Controls.Add(this.rbPink);
            this.tabPage2.Controls.Add(this.rbOrange);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fore Color";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRed.Location = new System.Drawing.Point(67, 42);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(57, 24);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGreen.Location = new System.Drawing.Point(67, 78);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(72, 24);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlue.Location = new System.Drawing.Point(67, 115);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(59, 24);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbwhite
            // 
            this.rbwhite.AutoSize = true;
            this.rbwhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbwhite.Location = new System.Drawing.Point(67, 150);
            this.rbwhite.Name = "rbwhite";
            this.rbwhite.Size = new System.Drawing.Size(68, 24);
            this.rbwhite.TabIndex = 3;
            this.rbwhite.TabStop = true;
            this.rbwhite.Text = "White";
            this.rbwhite.UseVisualStyleBackColor = true;
            this.rbwhite.CheckedChanged += new System.EventHandler(this.rbwhite_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(251, 95);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 37);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrange.Location = new System.Drawing.Point(62, 58);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(80, 24);
            this.rbOrange.TabIndex = 0;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // rbPink
            // 
            this.rbPink.AutoSize = true;
            this.rbPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPink.Location = new System.Drawing.Point(62, 90);
            this.rbPink.Name = "rbPink";
            this.rbPink.Size = new System.Drawing.Size(56, 24);
            this.rbPink.TabIndex = 1;
            this.rbPink.TabStop = true;
            this.rbPink.Text = "pink";
            this.rbPink.UseVisualStyleBackColor = true;
            this.rbPink.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlack.Location = new System.Drawing.Point(62, 124);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(66, 24);
            this.rbBlack.TabIndex = 2;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGray.Location = new System.Drawing.Point(62, 158);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(61, 24);
            this.rbGray.TabIndex = 3;
            this.rbGray.TabStop = true;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            this.rbGray.CheckedChanged += new System.EventHandler(this.rbGray_CheckedChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(225, 106);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(142, 35);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 302);
            this.Controls.Add(this.tbBackColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbBackColor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbBackColor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbwhite;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbPink;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.Button btnPrevious;
    }
}

