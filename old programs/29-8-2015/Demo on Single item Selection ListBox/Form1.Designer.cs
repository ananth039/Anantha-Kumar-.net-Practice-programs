namespace Demo_on_Single_item_Selection_ListBox
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
            this.lblSelectYourcourse = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.blSelectedCoursePrompt = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblSelectedCourseIndexPrompt = new System.Windows.Forms.Label();
            this.lblSelectedCourseIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectYourcourse
            // 
            this.lblSelectYourcourse.AutoSize = true;
            this.lblSelectYourcourse.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYourcourse.Location = new System.Drawing.Point(57, 119);
            this.lblSelectYourcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectYourcourse.Name = "lblSelectYourcourse";
            this.lblSelectYourcourse.Size = new System.Drawing.Size(150, 17);
            this.lblSelectYourcourse.TabIndex = 0;
            this.lblSelectYourcourse.Text = "Select your Course:";
            this.lblSelectYourcourse.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 17;
            this.lstCourses.Items.AddRange(new object[] {
            ".NET 4.0 ",
            "Java ",
            "Share Point ",
            "Oracle DBA",
            " Sql Server",
            " QTP",
            " MS BI"});
            this.lstCourses.Location = new System.Drawing.Point(55, 158);
            this.lstCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(178, 157);
            this.lstCourses.TabIndex = 1;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // blSelectedCoursePrompt
            // 
            this.blSelectedCoursePrompt.AutoSize = true;
            this.blSelectedCoursePrompt.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blSelectedCoursePrompt.Location = new System.Drawing.Point(344, 185);
            this.blSelectedCoursePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blSelectedCoursePrompt.Name = "blSelectedCoursePrompt";
            this.blSelectedCoursePrompt.Size = new System.Drawing.Size(130, 17);
            this.blSelectedCoursePrompt.TabIndex = 2;
            this.blSelectedCoursePrompt.Text = "Selected Course:";
            this.blSelectedCoursePrompt.Click += new System.EventHandler(this.blSelectedCoursePrompt_Click);
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourse.Location = new System.Drawing.Point(482, 185);
            this.lblSelectedCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(166, 17);
            this.lblSelectedCourse.TabIndex = 3;
            this.lblSelectedCourse.Text = "Selected Course Here";
            this.lblSelectedCourse.Click += new System.EventHandler(this.lblSelectedCourse_Click);
            // 
            // lblSelectedCourseIndexPrompt
            // 
            this.lblSelectedCourseIndexPrompt.AutoSize = true;
            this.lblSelectedCourseIndexPrompt.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourseIndexPrompt.Location = new System.Drawing.Point(298, 241);
            this.lblSelectedCourseIndexPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCourseIndexPrompt.Name = "lblSelectedCourseIndexPrompt";
            this.lblSelectedCourseIndexPrompt.Size = new System.Drawing.Size(176, 17);
            this.lblSelectedCourseIndexPrompt.TabIndex = 4;
            this.lblSelectedCourseIndexPrompt.Text = "Selected Course Index:";
            // 
            // lblSelectedCourseIndex
            // 
            this.lblSelectedCourseIndex.AutoSize = true;
            this.lblSelectedCourseIndex.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourseIndex.Location = new System.Drawing.Point(482, 241);
            this.lblSelectedCourseIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCourseIndex.Name = "lblSelectedCourseIndex";
            this.lblSelectedCourseIndex.Size = new System.Drawing.Size(212, 17);
            this.lblSelectedCourseIndex.TabIndex = 5;
            this.lblSelectedCourseIndex.Text = "Selected Course Index Here";
            this.lblSelectedCourseIndex.Click += new System.EventHandler(this.lblSelectedCourseIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 370);
            this.Controls.Add(this.lblSelectedCourseIndex);
            this.Controls.Add(this.lblSelectedCourseIndexPrompt);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.blSelectedCoursePrompt);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lblSelectYourcourse);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Demo on Single item Selection ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectYourcourse;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label blSelectedCoursePrompt;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblSelectedCourseIndexPrompt;
        private System.Windows.Forms.Label lblSelectedCourseIndex;
    }
}

