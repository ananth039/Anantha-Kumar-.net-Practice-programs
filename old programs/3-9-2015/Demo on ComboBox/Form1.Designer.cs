namespace Demo_on_ComboBox
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
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(33, 67);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(76, 13);
            this.lblSelectCourse.TabIndex = 0;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(36, 124);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(28, 13);
            this.lblFee.TabIndex = 1;
            this.lblFee.Text = "Fee:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            " Oracle ",
            ".NET ",
            "C ",
            "C++",
            "Java "});
            this.cmbCourse.Location = new System.Drawing.Point(181, 63);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(166, 21);
            this.cmbCourse.Sorted = true;
            this.cmbCourse.TabIndex = 2;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.CmbSelectCourse_SelectedIndexChanged);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(181, 121);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(162, 20);
            this.txtFee.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 187);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblSelectCourse);
            this.Name = "Form1";
            this.Text = " Demo on ComboBox ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtFee;
    }
}

