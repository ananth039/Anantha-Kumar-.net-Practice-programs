namespace Demo_on_Multiple_item_Selection_ListBox
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
            this.lblAvailBooks = new System.Windows.Forms.Label();
            this.lstAvialbleBooks = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstSelectedBooks = new System.Windows.Forms.ListBox();
            this.lblSelectedBooks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAvailBooks
            // 
            this.lblAvailBooks.AutoSize = true;
            this.lblAvailBooks.Location = new System.Drawing.Point(51, 37);
            this.lblAvailBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailBooks.Name = "lblAvailBooks";
            this.lblAvailBooks.Size = new System.Drawing.Size(132, 17);
            this.lblAvailBooks.TabIndex = 0;
            this.lblAvailBooks.Text = "Available Books:";
            // 
            // lstAvialbleBooks
            // 
            this.lstAvialbleBooks.FormattingEnabled = true;
            this.lstAvialbleBooks.ItemHeight = 17;
            this.lstAvialbleBooks.Items.AddRange(new object[] {
            " C# 4.0 for Beginners ",
            " Java Complete Reference ",
            " Let Us C",
            " Let Us C++",
            "ASP.NET for Professionals",
            "HTML 4.0",
            "JavaScript Bible"});
            this.lstAvialbleBooks.Location = new System.Drawing.Point(45, 71);
            this.lstAvialbleBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAvialbleBooks.Name = "lstAvialbleBooks";
            this.lstAvialbleBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAvialbleBooks.Size = new System.Drawing.Size(436, 412);
            this.lstAvialbleBooks.Sorted = true;
            this.lstAvialbleBooks.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(520, 257);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 52);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = ">";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstSelectedBooks
            // 
            this.lstSelectedBooks.FormattingEnabled = true;
            this.lstSelectedBooks.ItemHeight = 17;
            this.lstSelectedBooks.Location = new System.Drawing.Point(620, 71);
            this.lstSelectedBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSelectedBooks.Name = "lstSelectedBooks";
            this.lstSelectedBooks.Size = new System.Drawing.Size(336, 412);
            this.lstSelectedBooks.Sorted = true;
            this.lstSelectedBooks.TabIndex = 3;
            // 
            // lblSelectedBooks
            // 
            this.lblSelectedBooks.AutoSize = true;
            this.lblSelectedBooks.Location = new System.Drawing.Point(617, 37);
            this.lblSelectedBooks.Name = "lblSelectedBooks";
            this.lblSelectedBooks.Size = new System.Drawing.Size(126, 17);
            this.lblSelectedBooks.TabIndex = 4;
            this.lblSelectedBooks.Text = "Selected Books:";
            this.lblSelectedBooks.Click += new System.EventHandler(this.lblSelectedBooks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 579);
            this.Controls.Add(this.lblSelectedBooks);
            this.Controls.Add(this.lstSelectedBooks);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstAvialbleBooks);
            this.Controls.Add(this.lblAvailBooks);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Demo on Multiple item Selection ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailBooks;
        private System.Windows.Forms.ListBox lstAvialbleBooks;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstSelectedBooks;
        private System.Windows.Forms.Label lblSelectedBooks;
    }
}

