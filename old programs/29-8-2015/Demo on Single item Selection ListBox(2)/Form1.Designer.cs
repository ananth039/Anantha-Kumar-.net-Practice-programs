namespace Demo_on_Single_item_Selection_ListBox_2_
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
            this.grpCities = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.txtNewCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.btnClearAl = new System.Windows.Forms.Button();
            this.btnShowCount = new System.Windows.Forms.Button();
            this.grpCities.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCities
            // 
            this.grpCities.Controls.Add(this.lstCities);
            this.grpCities.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCities.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.grpCities.Location = new System.Drawing.Point(80, 66);
            this.grpCities.Name = "grpCities";
            this.grpCities.Size = new System.Drawing.Size(217, 369);
            this.grpCities.TabIndex = 0;
            this.grpCities.TabStop = false;
            this.grpCities.Text = "Cities";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnShowCount);
            this.grpOptions.Controls.Add(this.btnClearAl);
            this.grpOptions.Controls.Add(this.btnRemoveCity);
            this.grpOptions.Controls.Add(this.btnAdd);
            this.grpOptions.Controls.Add(this.txtNewCity);
            this.grpOptions.Controls.Add(this.lblNewCity);
            this.grpOptions.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.grpOptions.Location = new System.Drawing.Point(317, 66);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(455, 369);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            this.grpOptions.Enter += new System.EventHandler(this.grpOptions_Enter);
            // 
            // lstCities
            // 
            this.lstCities.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 17;
            this.lstCities.Items.AddRange(new object[] {
            " Hyderabad",
            " Pune",
            " New Delhi ",
            " Banglore",
            " Dehradun",
            " Chilakapadu",
            "Tanuku",
            " Rajamundry",
            " Eluru",
            " Vijayawada"});
            this.lstCities.Location = new System.Drawing.Point(23, 29);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(173, 310);
            this.lstCities.TabIndex = 0;
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNewCity.Location = new System.Drawing.Point(20, 47);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(125, 17);
            this.lblNewCity.TabIndex = 0;
            this.lblNewCity.Text = "New City Name:";
            // 
            // txtNewCity
            // 
            this.txtNewCity.Location = new System.Drawing.Point(162, 39);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(271, 25);
            this.txtNewCity.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(305, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveCity.Location = new System.Drawing.Point(109, 170);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(200, 39);
            this.btnRemoveCity.TabIndex = 3;
            this.btnRemoveCity.Text = "Remove City";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // btnClearAl
            // 
            this.btnClearAl.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAl.Location = new System.Drawing.Point(109, 235);
            this.btnClearAl.Name = "btnClearAl";
            this.btnClearAl.Size = new System.Drawing.Size(200, 39);
            this.btnClearAl.TabIndex = 4;
            this.btnClearAl.Text = "Clear All";
            this.btnClearAl.UseVisualStyleBackColor = true;
            this.btnClearAl.Click += new System.EventHandler(this.btnClearAl_Click);
            // 
            // btnShowCount
            // 
            this.btnShowCount.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowCount.Location = new System.Drawing.Point(109, 308);
            this.btnShowCount.Name = "btnShowCount";
            this.btnShowCount.Size = new System.Drawing.Size(200, 37);
            this.btnShowCount.TabIndex = 5;
            this.btnShowCount.Text = "Show Count";
            this.btnShowCount.UseVisualStyleBackColor = true;
            this.btnShowCount.Click += new System.EventHandler(this.btnShowCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 467);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpCities);
            this.Name = "Form1";
            this.Text = "Demo on Single item Selection ListBox(2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCities.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCities;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Button btnShowCount;
        private System.Windows.Forms.Button btnClearAl;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewCity;
        private System.Windows.Forms.Label lblNewCity;
    }
}

