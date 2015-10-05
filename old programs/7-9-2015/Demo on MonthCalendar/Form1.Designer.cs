namespace Demo_on_MonthCalendar
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
            this.lblDOB = new System.Windows.Forms.Label();
            this.monCalMyDate = new System.Windows.Forms.MonthCalendar();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.lblSelectedDateHere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(28, 55);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(192, 17);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Select Your Date of Birth:";
            // 
            // monCalMyDate
            // 
            this.monCalMyDate.Location = new System.Drawing.Point(227, 55);
            this.monCalMyDate.Name = "monCalMyDate";
            this.monCalMyDate.TabIndex = 1;
            this.monCalMyDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.Location = new System.Drawing.Point(28, 252);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(149, 17);
            this.lblSelectedDate.TabIndex = 2;
            this.lblSelectedDate.Text = "Selected Date Here";
            this.lblSelectedDate.Click += new System.EventHandler(this.lblSelectedDate_Click);
            // 
            // lblSelectedDateHere
            // 
            this.lblSelectedDateHere.AutoSize = true;
            this.lblSelectedDateHere.Location = new System.Drawing.Point(227, 252);
            this.lblSelectedDateHere.Name = "lblSelectedDateHere";
            this.lblSelectedDateHere.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedDateHere.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 297);
            this.Controls.Add(this.lblSelectedDateHere);
            this.Controls.Add(this.lblSelectedDate);
            this.Controls.Add(this.monCalMyDate);
            this.Controls.Add(this.lblDOB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.MonthCalendar monCalMyDate;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Label lblSelectedDateHere;
    }
}

