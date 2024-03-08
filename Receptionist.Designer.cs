namespace hospital_management
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            btnedit = new Button();
            btndelete = new Button();
            btnadd = new Button();
            dataGridViewreceptionist = new DataGridView();
            lblphonenumber = new Label();
            RPhoneTb = new TextBox();
            RAddressTb = new TextBox();
            lbladdress = new Label();
            RNameTb = new TextBox();
            lblname = new Label();
            panelbottom = new Panel();
            panelsidebar = new Panel();
            pictureBoxdashboard = new PictureBox();
            lbldashboard = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblsidebarreceptionist = new Label();
            lblsidebarlaboratory = new Label();
            lblsidebardoctor = new Label();
            lblsidebarpatient = new Label();
            lbllogout = new Label();
            pictureBox9 = new PictureBox();
            pictureBoxlogo = new PictureBox();
            labelpassword = new Label();
            RPasswordTb = new TextBox();
            label2 = new Label();
            comboBoxgender = new ComboBox();
            pictureBoxclose = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewreceptionist).BeginInit();
            panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxclose).BeginInit();
            SuspendLayout();
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.LimeGreen;
            btnedit.BackgroundImageLayout = ImageLayout.None;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnedit.ForeColor = SystemColors.ButtonHighlight;
            btnedit.Location = new Point(1007, 199);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(75, 23);
            btnedit.TabIndex = 70;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(870, 199);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 69;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Black;
            btnadd.BackgroundImageLayout = ImageLayout.None;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.ForeColor = SystemColors.ButtonHighlight;
            btnadd.Location = new Point(719, 197);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 68;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // dataGridViewreceptionist
            // 
            dataGridViewreceptionist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewreceptionist.Location = new Point(189, 252);
            dataGridViewreceptionist.Name = "dataGridViewreceptionist";
            dataGridViewreceptionist.RowTemplate.Height = 25;
            dataGridViewreceptionist.Size = new Size(1341, 494);
            dataGridViewreceptionist.TabIndex = 67;
            // 
            // lblphonenumber
            // 
            lblphonenumber.AutoSize = true;
            lblphonenumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblphonenumber.Location = new Point(719, 84);
            lblphonenumber.Name = "lblphonenumber";
            lblphonenumber.Size = new Size(101, 17);
            lblphonenumber.TabIndex = 64;
            lblphonenumber.Text = "Phone Number";
            // 
            // RPhoneTb
            // 
            RPhoneTb.Location = new Point(719, 104);
            RPhoneTb.Name = "RPhoneTb";
            RPhoneTb.Size = new Size(133, 23);
            RPhoneTb.TabIndex = 63;
            // 
            // RAddressTb
            // 
            RAddressTb.Location = new Point(1106, 102);
            RAddressTb.Multiline = true;
            RAddressTb.Name = "RAddressTb";
            RAddressTb.Size = new Size(177, 72);
            RAddressTb.TabIndex = 62;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbladdress.Location = new Point(1106, 82);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(57, 17);
            lbladdress.TabIndex = 61;
            lbladdress.Text = "Address";
            // 
            // RNameTb
            // 
            RNameTb.Location = new Point(304, 102);
            RNameTb.Name = "RNameTb";
            RNameTb.Size = new Size(152, 23);
            RNameTb.TabIndex = 57;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(304, 80);
            lblname.Name = "lblname";
            lblname.Size = new Size(44, 17);
            lblname.TabIndex = 56;
            lblname.Text = "Name";
            // 
            // panelbottom
            // 
            panelbottom.BackColor = Color.DarkSlateGray;
            panelbottom.Location = new Point(175, 750);
            panelbottom.Name = "panelbottom";
            panelbottom.Size = new Size(1403, 29);
            panelbottom.TabIndex = 75;
            // 
            // panelsidebar
            // 
            panelsidebar.BackColor = Color.DarkSlateGray;
            panelsidebar.BackgroundImageLayout = ImageLayout.None;
            panelsidebar.Controls.Add(pictureBoxdashboard);
            panelsidebar.Controls.Add(lbldashboard);
            panelsidebar.Controls.Add(pictureBox8);
            panelsidebar.Controls.Add(pictureBox7);
            panelsidebar.Controls.Add(pictureBox6);
            panelsidebar.Controls.Add(pictureBox2);
            panelsidebar.Controls.Add(lblsidebarreceptionist);
            panelsidebar.Controls.Add(lblsidebarlaboratory);
            panelsidebar.Controls.Add(lblsidebardoctor);
            panelsidebar.Controls.Add(lblsidebarpatient);
            panelsidebar.Controls.Add(lbllogout);
            panelsidebar.Controls.Add(pictureBox9);
            panelsidebar.Controls.Add(pictureBoxlogo);
            panelsidebar.Dock = DockStyle.Left;
            panelsidebar.Location = new Point(0, 0);
            panelsidebar.Name = "panelsidebar";
            panelsidebar.Size = new Size(182, 779);
            panelsidebar.TabIndex = 74;
            // 
            // pictureBoxdashboard
            // 
            pictureBoxdashboard.BackColor = Color.White;
            pictureBoxdashboard.Image = (Image)resources.GetObject("pictureBoxdashboard.Image");
            pictureBoxdashboard.Location = new Point(4, 184);
            pictureBoxdashboard.Name = "pictureBoxdashboard";
            pictureBoxdashboard.Size = new Size(53, 57);
            pictureBoxdashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxdashboard.TabIndex = 29;
            pictureBoxdashboard.TabStop = false;
            // 
            // lbldashboard
            // 
            lbldashboard.AutoSize = true;
            lbldashboard.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldashboard.ForeColor = Color.White;
            lbldashboard.Location = new Point(81, 220);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Size = new Size(92, 21);
            lbldashboard.TabIndex = 28;
            lbldashboard.Text = "Dashboard";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Honeydew;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 491);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(50, 54);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Honeydew;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(2, 339);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 53);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Honeydew;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 415);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Honeydew;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // lblsidebarreceptionist
            // 
            lblsidebarreceptionist.AutoSize = true;
            lblsidebarreceptionist.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblsidebarreceptionist.ForeColor = Color.White;
            lblsidebarreceptionist.Location = new Point(77, 524);
            lblsidebarreceptionist.Name = "lblsidebarreceptionist";
            lblsidebarreceptionist.Size = new Size(103, 21);
            lblsidebarreceptionist.TabIndex = 24;
            lblsidebarreceptionist.Text = "Receptionist";
            // 
            // lblsidebarlaboratory
            // 
            lblsidebarlaboratory.AutoSize = true;
            lblsidebarlaboratory.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblsidebarlaboratory.ForeColor = Color.White;
            lblsidebarlaboratory.Location = new Point(81, 447);
            lblsidebarlaboratory.Name = "lblsidebarlaboratory";
            lblsidebarlaboratory.Size = new Size(93, 21);
            lblsidebarlaboratory.TabIndex = 23;
            lblsidebarlaboratory.Text = "Laboratory";
            // 
            // lblsidebardoctor
            // 
            lblsidebardoctor.AutoSize = true;
            lblsidebardoctor.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblsidebardoctor.ForeColor = Color.White;
            lblsidebardoctor.Location = new Point(81, 371);
            lblsidebardoctor.Name = "lblsidebardoctor";
            lblsidebardoctor.Size = new Size(63, 21);
            lblsidebardoctor.TabIndex = 22;
            lblsidebardoctor.Text = "Doctor";
            // 
            // lblsidebarpatient
            // 
            lblsidebarpatient.AutoSize = true;
            lblsidebarpatient.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblsidebarpatient.ForeColor = Color.White;
            lblsidebarpatient.Location = new Point(81, 301);
            lblsidebarpatient.Name = "lblsidebarpatient";
            lblsidebarpatient.Size = new Size(68, 21);
            lblsidebarpatient.TabIndex = 21;
            lblsidebarpatient.Text = "Patients";
            // 
            // lbllogout
            // 
            lbllogout.AutoSize = true;
            lbllogout.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbllogout.ForeColor = Color.White;
            lbllogout.Location = new Point(62, 750);
            lbllogout.Name = "lbllogout";
            lbllogout.Size = new Size(55, 17);
            lbllogout.TabIndex = 15;
            lbllogout.Text = "Logout";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(62, 710);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(54, 36);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.BackgroundImage = (Image)resources.GetObject("pictureBoxlogo.BackgroundImage");
            pictureBoxlogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxlogo.Location = new Point(0, 0);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(200, 124);
            pictureBoxlogo.TabIndex = 2;
            pictureBoxlogo.TabStop = false;
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelpassword.Location = new Point(907, 82);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(66, 17);
            labelpassword.TabIndex = 77;
            labelpassword.Text = "Password";
            // 
            // RPasswordTb
            // 
            RPasswordTb.Location = new Point(907, 102);
            RPasswordTb.Name = "RPasswordTb";
            RPasswordTb.Size = new Size(133, 23);
            RPasswordTb.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(711, 18);
            label2.Name = "label2";
            label2.Size = new Size(297, 34);
            label2.TabIndex = 78;
            label2.Text = "Health Care Plus";
            // 
            // comboBoxgender
            // 
            comboBoxgender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxgender.FormattingEnabled = true;
            comboBoxgender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxgender.Location = new Point(501, 102);
            comboBoxgender.Name = "comboBoxgender";
            comboBoxgender.Size = new Size(152, 25);
            comboBoxgender.TabIndex = 79;
            comboBoxgender.Text = "Gender";
            // 
            // pictureBoxclose
            // 
            pictureBoxclose.BackColor = Color.Transparent;
            pictureBoxclose.BackgroundImage = (Image)resources.GetObject("pictureBoxclose.BackgroundImage");
            pictureBoxclose.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxclose.Location = new Point(1501, 4);
            pictureBoxclose.Name = "pictureBoxclose";
            pictureBoxclose.Size = new Size(40, 21);
            pictureBoxclose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxclose.TabIndex = 80;
            pictureBoxclose.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 81;
            label1.Text = "Receptionist";
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 779);
            Controls.Add(label1);
            Controls.Add(pictureBoxclose);
            Controls.Add(comboBoxgender);
            Controls.Add(label2);
            Controls.Add(labelpassword);
            Controls.Add(RPasswordTb);
            Controls.Add(panelbottom);
            Controls.Add(panelsidebar);
            Controls.Add(btnedit);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(dataGridViewreceptionist);
            Controls.Add(lblphonenumber);
            Controls.Add(RPhoneTb);
            Controls.Add(RAddressTb);
            Controls.Add(lbladdress);
            Controls.Add(RNameTb);
            Controls.Add(lblname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receptionist";
            Text = "receptionists";
            Load += receptionists_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewreceptionist).EndInit();
            panelsidebar.ResumeLayout(false);
            panelsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxclose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpassword;
        private Label lblpassword;
        private Button btnedit;
        private Button btndelete;
        private Button btnadd;
        private DataGridView dataGridViewreceptionist;
        private Label lblphonenumber;
        private TextBox RPhoneTb;
        private TextBox RAddressTb;
        private Label lbladdress;
        private TextBox RNameTb;
        private Label lblname;
        private Panel panelbottom;
        private Panel panelsidebar;
        private Label lbllogout;
        private PictureBox pictureBox9;
        private PictureBox pictureBoxlogo;
        private Label labelpassword;
        private TextBox RPasswordTb;
        private Label label2;
        private ComboBox comboBoxgender;
        private PictureBox pictureBoxclose;
        private PictureBox pictureBoxdashboard;
        private Label lbldashboard;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Label lblsidebarreceptionist;
        private Label lblsidebarlaboratory;
        private Label lblsidebardoctor;
        private Label lblsidebarpatient;
        private Label label1;
    }
}