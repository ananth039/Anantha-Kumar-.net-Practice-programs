namespace listbox
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
            this.lbinput = new System.Windows.Forms.ListBox();
            this.lboutput = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnaddmultiple = new System.Windows.Forms.Button();
            this.btnDeleteSingle = new System.Windows.Forms.Button();
            this.btnDeleteMultilple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbinput
            // 
            this.lbinput.FormattingEnabled = true;
            this.lbinput.Location = new System.Drawing.Point(53, 67);
            this.lbinput.Name = "lbinput";
            this.lbinput.Size = new System.Drawing.Size(210, 212);
            this.lbinput.TabIndex = 0;
            // 
            // lboutput
            // 
            this.lboutput.FormattingEnabled = true;
            this.lboutput.Location = new System.Drawing.Point(554, 67);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(235, 212);
            this.lboutput.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(341, 67);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(114, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Add Single";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnaddmultiple
            // 
            this.btnaddmultiple.Location = new System.Drawing.Point(341, 128);
            this.btnaddmultiple.Name = "btnaddmultiple";
            this.btnaddmultiple.Size = new System.Drawing.Size(115, 23);
            this.btnaddmultiple.TabIndex = 3;
            this.btnaddmultiple.Text = "Add multiple Items";
            this.btnaddmultiple.UseVisualStyleBackColor = true;
            this.btnaddmultiple.Click += new System.EventHandler(this.btnaddmultiple_Click);
            // 
            // btnDeleteSingle
            // 
            this.btnDeleteSingle.Location = new System.Drawing.Point(341, 184);
            this.btnDeleteSingle.Name = "btnDeleteSingle";
            this.btnDeleteSingle.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteSingle.TabIndex = 4;
            this.btnDeleteSingle.Text = "Delete single";
            this.btnDeleteSingle.UseVisualStyleBackColor = true;
            this.btnDeleteSingle.Click += new System.EventHandler(this.btnDeleteSingle_Click);
            // 
            // btnDeleteMultilple
            // 
            this.btnDeleteMultilple.Location = new System.Drawing.Point(341, 244);
            this.btnDeleteMultilple.Name = "btnDeleteMultilple";
            this.btnDeleteMultilple.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteMultilple.TabIndex = 5;
            this.btnDeleteMultilple.Text = "delete multiple";
            this.btnDeleteMultilple.UseVisualStyleBackColor = true;
            this.btnDeleteMultilple.Click += new System.EventHandler(this.btnDeleteMultilple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 321);
            this.Controls.Add(this.btnDeleteMultilple);
            this.Controls.Add(this.btnDeleteSingle);
            this.Controls.Add(this.btnaddmultiple);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.lbinput);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbinput;
        private System.Windows.Forms.ListBox lboutput;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnaddmultiple;
        private System.Windows.Forms.Button btnDeleteSingle;
        private System.Windows.Forms.Button btnDeleteMultilple;
    }
}

