namespace checkboxes
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
            this.lblselectCourse = new System.Windows.Forms.Label();
            this.chbCsharpdotnet = new System.Windows.Forms.CheckBox();
            this.chbaspdotnet = new System.Windows.Forms.CheckBox();
            this.chbadodotnet = new System.Windows.Forms.CheckBox();
            this.chbSqlserver = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblselectCourse
            // 
            this.lblselectCourse.AutoSize = true;
            this.lblselectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectCourse.Location = new System.Drawing.Point(25, 27);
            this.lblselectCourse.Name = "lblselectCourse";
            this.lblselectCourse.Size = new System.Drawing.Size(117, 20);
            this.lblselectCourse.TabIndex = 0;
            this.lblselectCourse.Text = "Select Courses";
            this.lblselectCourse.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbCsharpdotnet
            // 
            this.chbCsharpdotnet.AutoSize = true;
            this.chbCsharpdotnet.Location = new System.Drawing.Point(78, 69);
            this.chbCsharpdotnet.Name = "chbCsharpdotnet";
            this.chbCsharpdotnet.Size = new System.Drawing.Size(65, 17);
            this.chbCsharpdotnet.TabIndex = 1;
            this.chbCsharpdotnet.Text = "C#.NET";
            this.chbCsharpdotnet.UseVisualStyleBackColor = true;
            // 
            // chbaspdotnet
            // 
            this.chbaspdotnet.AutoSize = true;
            this.chbaspdotnet.Location = new System.Drawing.Point(78, 93);
            this.chbaspdotnet.Name = "chbaspdotnet";
            this.chbaspdotnet.Size = new System.Drawing.Size(72, 17);
            this.chbaspdotnet.TabIndex = 2;
            this.chbaspdotnet.Text = "ASP.NET";
            this.chbaspdotnet.UseVisualStyleBackColor = true;
            // 
            // chbadodotnet
            // 
            this.chbadodotnet.AutoSize = true;
            this.chbadodotnet.Location = new System.Drawing.Point(78, 117);
            this.chbadodotnet.Name = "chbadodotnet";
            this.chbadodotnet.Size = new System.Drawing.Size(74, 17);
            this.chbadodotnet.TabIndex = 3;
            this.chbadodotnet.Text = "ADO.NET";
            this.chbadodotnet.UseVisualStyleBackColor = true;
            // 
            // chbSqlserver
            // 
            this.chbSqlserver.AutoSize = true;
            this.chbSqlserver.Location = new System.Drawing.Point(78, 141);
            this.chbSqlserver.Name = "chbSqlserver";
            this.chbSqlserver.Size = new System.Drawing.Size(94, 17);
            this.chbSqlserver.TabIndex = 4;
            this.chbSqlserver.Text = "SQL SERVER";
            this.chbSqlserver.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(78, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chbSqlserver);
            this.Controls.Add(this.chbadodotnet);
            this.Controls.Add(this.chbaspdotnet);
            this.Controls.Add(this.chbCsharpdotnet);
            this.Controls.Add(this.lblselectCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselectCourse;
        private System.Windows.Forms.CheckBox chbCsharpdotnet;
        private System.Windows.Forms.CheckBox chbaspdotnet;
        private System.Windows.Forms.CheckBox chbadodotnet;
        private System.Windows.Forms.CheckBox chbSqlserver;
        private System.Windows.Forms.Button btnSubmit;
    }
}

