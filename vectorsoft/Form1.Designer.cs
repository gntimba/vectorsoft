namespace vectorsoft
{
    partial class front
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(front));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPasstype = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.cmGender = new System.Windows.Forms.ComboBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(278, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(293, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(293, 243);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 20);
            this.txtGender.TabIndex = 4;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(293, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(293, 138);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // cmType
            // 
            this.cmType.FormattingEnabled = true;
            this.cmType.Items.AddRange(new object[] {
            "SA ID",
            "PASSPORT"});
            this.cmType.Location = new System.Drawing.Point(293, 164);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(121, 21);
            this.cmType.TabIndex = 7;
            this.cmType.Text = "Select Type";
            this.cmType.SelectedIndexChanged += new System.EventHandler(this.cmType_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(198, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(197, 138);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(197, 164);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 13);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "IDTYPE";
            // 
            // lblPasstype
            // 
            this.lblPasstype.AutoSize = true;
            this.lblPasstype.Location = new System.Drawing.Point(197, 190);
            this.lblPasstype.Name = "lblPasstype";
            this.lblPasstype.Size = new System.Drawing.Size(30, 13);
            this.lblPasstype.TabIndex = 11;
            this.lblPasstype.Text = "Pass";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(198, 246);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(198, 217);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "DOB";
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(293, 217);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(121, 20);
            this.dtPicker.TabIndex = 14;
            this.dtPicker.Visible = false;
            // 
            // txtDOB
            // 
            this.txtDOB.Enabled = false;
            this.txtDOB.Location = new System.Drawing.Point(293, 217);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(121, 20);
            this.txtDOB.TabIndex = 15;
            this.txtDOB.Visible = false;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cmGender
            // 
            this.cmGender.FormattingEnabled = true;
            this.cmGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmGender.Location = new System.Drawing.Point(293, 246);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(121, 21);
            this.cmGender.TabIndex = 16;
            this.cmGender.Text = "Select Gender";
            this.cmGender.SelectedIndexChanged += new System.EventHandler(this.cmGender_SelectedIndexChanged);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(275, 350);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(94, 13);
            this.lblSuccess.TabIndex = 17;
            this.lblSuccess.Text = "Sucessfully Saved";
            this.lblSuccess.UseWaitCursor = true;
            this.lblSuccess.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::vectorsoft.Properties.Resources.vectorsoft;
            this.pictureBox1.InitialImage = global::vectorsoft.Properties.Resources.vectorsoft;
            this.pictureBox1.Location = new System.Drawing.Point(156, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 80);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.cmGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPasstype);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmType);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "front";
            this.Text = "VectorSoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPasstype;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.ComboBox cmGender;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

