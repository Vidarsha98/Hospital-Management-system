namespace hospital_management
{
    partial class Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            comboBoxdoctorid = new ComboBox();
            btndelete = new Button();
            btnadd = new Button();
            dataGridViewpatients = new DataGridView();
            txttest = new TextBox();
            lbltest = new Label();
            lblpatientname = new Label();
            txtpatientname = new TextBox();
            txtmedicines = new TextBox();
            lblmedicines = new Label();
            comboBoxpatientid = new ComboBox();
            txtdoctorname = new TextBox();
            lbldoctorname = new Label();
            label2 = new Label();
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
            pictureBoxclose = new PictureBox();
            comboBoxtestid = new ComboBox();
            textBox1 = new TextBox();
            lblcost = new Label();
            richTextBoxprescription = new RichTextBox();
            lblprescription = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpatients).BeginInit();
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
            // comboBoxdoctorid
            // 
            comboBoxdoctorid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxdoctorid.FormattingEnabled = true;
            comboBoxdoctorid.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxdoctorid.Location = new Point(236, 101);
            comboBoxdoctorid.Name = "comboBoxdoctorid";
            comboBoxdoctorid.Size = new Size(89, 25);
            comboBoxdoctorid.TabIndex = 72;
            comboBoxdoctorid.Text = "Doctor Id";
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(352, 340);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 70;
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
            btnadd.Location = new Point(249, 340);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 69;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewpatients
            // 
            dataGridViewpatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpatients.Location = new Point(179, 527);
            dataGridViewpatients.Name = "dataGridViewpatients";
            dataGridViewpatients.RowTemplate.Height = 25;
            dataGridViewpatients.Size = new Size(1055, 214);
            dataGridViewpatients.TabIndex = 68;
            // 
            // txttest
            // 
            txttest.Location = new Point(372, 207);
            txttest.Name = "txttest";
            txttest.Size = new Size(152, 23);
            txttest.TabIndex = 67;
            // 
            // lbltest
            // 
            lbltest.AutoSize = true;
            lbltest.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltest.Location = new Point(372, 187);
            lbltest.Name = "lbltest";
            lbltest.Size = new Size(33, 17);
            lbltest.TabIndex = 66;
            lbltest.Text = "Test";
            // 
            // lblpatientname
            // 
            lblpatientname.AutoSize = true;
            lblpatientname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpatientname.Location = new Point(372, 138);
            lblpatientname.Name = "lblpatientname";
            lblpatientname.Size = new Size(92, 17);
            lblpatientname.TabIndex = 65;
            lblpatientname.Text = "Patient Name";
            // 
            // txtpatientname
            // 
            txtpatientname.Location = new Point(372, 158);
            txtpatientname.Name = "txtpatientname";
            txtpatientname.Size = new Size(152, 23);
            txtpatientname.TabIndex = 64;
            // 
            // txtmedicines
            // 
            txtmedicines.Location = new Point(236, 262);
            txtmedicines.Multiline = true;
            txtmedicines.Name = "txtmedicines";
            txtmedicines.Size = new Size(149, 72);
            txtmedicines.TabIndex = 63;
            // 
            // lblmedicines
            // 
            lblmedicines.AutoSize = true;
            lblmedicines.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblmedicines.Location = new Point(249, 242);
            lblmedicines.Name = "lblmedicines";
            lblmedicines.Size = new Size(70, 17);
            lblmedicines.TabIndex = 62;
            lblmedicines.Text = "Medicines";
            // 
            // comboBoxpatientid
            // 
            comboBoxpatientid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxpatientid.FormattingEnabled = true;
            comboBoxpatientid.Items.AddRange(new object[] { "Urology", "Gynecology", "Surgery", "Ophalmo", "Generalist", "Dermato" });
            comboBoxpatientid.Location = new Point(236, 156);
            comboBoxpatientid.Name = "comboBoxpatientid";
            comboBoxpatientid.Size = new Size(88, 25);
            comboBoxpatientid.TabIndex = 59;
            comboBoxpatientid.Text = "Pateint Id";
            // 
            // txtdoctorname
            // 
            txtdoctorname.Location = new Point(372, 101);
            txtdoctorname.Name = "txtdoctorname";
            txtdoctorname.Size = new Size(152, 23);
            txtdoctorname.TabIndex = 58;
            // 
            // lbldoctorname
            // 
            lbldoctorname.AutoSize = true;
            lbldoctorname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbldoctorname.Location = new Point(372, 83);
            lbldoctorname.Name = "lbldoctorname";
            lbldoctorname.Size = new Size(90, 17);
            lbldoctorname.TabIndex = 57;
            lbldoctorname.Text = "Doctor Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(601, -1);
            label2.Name = "label2";
            label2.Size = new Size(297, 34);
            label2.TabIndex = 56;
            label2.Text = "Health Care Plus";
            // 
            // panelbottom
            // 
            panelbottom.BackColor = Color.DarkSlateGray;
            panelbottom.Location = new Point(172, 752);
            panelbottom.Name = "panelbottom";
            panelbottom.Size = new Size(1111, 29);
            panelbottom.TabIndex = 76;
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
            panelsidebar.Size = new Size(173, 781);
            panelsidebar.TabIndex = 75;
            // 
            // pictureBoxdashboard
            // 
            pictureBoxdashboard.BackColor = Color.White;
            pictureBoxdashboard.Image = (Image)resources.GetObject("pictureBoxdashboard.Image");
            pictureBoxdashboard.Location = new Point(-1, 180);
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
            lbldashboard.Location = new Point(76, 216);
            lbldashboard.Name = "lbldashboard";
            lbldashboard.Size = new Size(92, 21);
            lbldashboard.TabIndex = 28;
            lbldashboard.Text = "Dashboard";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Honeydew;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(-2, 487);
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
            pictureBox7.Location = new Point(-3, 335);
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
            pictureBox6.Location = new Point(-2, 411);
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
            pictureBox2.Location = new Point(-2, 261);
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
            lblsidebarreceptionist.Location = new Point(72, 520);
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
            lblsidebarlaboratory.Location = new Point(76, 443);
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
            lblsidebardoctor.Location = new Point(76, 367);
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
            lblsidebarpatient.Location = new Point(76, 297);
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
            // pictureBoxclose
            // 
            pictureBoxclose.BackColor = Color.Transparent;
            pictureBoxclose.BackgroundImage = (Image)resources.GetObject("pictureBoxclose.BackgroundImage");
            pictureBoxclose.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxclose.Location = new Point(1243, 0);
            pictureBoxclose.Name = "pictureBoxclose";
            pictureBoxclose.Size = new Size(40, 21);
            pictureBoxclose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxclose.TabIndex = 81;
            pictureBoxclose.TabStop = false;
            // 
            // comboBoxtestid
            // 
            comboBoxtestid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxtestid.FormattingEnabled = true;
            comboBoxtestid.Items.AddRange(new object[] { "Urology", "Gynecology", "Surgery", "Ophalmo", "Generalist", "Dermato" });
            comboBoxtestid.Location = new Point(236, 209);
            comboBoxtestid.Name = "comboBoxtestid";
            comboBoxtestid.Size = new Size(88, 25);
            comboBoxtestid.TabIndex = 82;
            comboBoxtestid.Text = "Test Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 84;
            // 
            // lblcost
            // 
            lblcost.AutoSize = true;
            lblcost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblcost.Location = new Point(400, 242);
            lblcost.Name = "lblcost";
            lblcost.Size = new Size(35, 17);
            lblcost.TabIndex = 83;
            lblcost.Text = "Cost";
            // 
            // richTextBoxprescription
            // 
            richTextBoxprescription.Location = new Point(647, 101);
            richTextBoxprescription.Name = "richTextBoxprescription";
            richTextBoxprescription.Size = new Size(538, 392);
            richTextBoxprescription.TabIndex = 85;
            richTextBoxprescription.Text = "";
            // 
            // lblprescription
            // 
            lblprescription.AutoSize = true;
            lblprescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblprescription.Location = new Point(825, 81);
            lblprescription.Name = "lblprescription";
            lblprescription.Size = new Size(114, 20);
            lblprescription.TabIndex = 86;
            lblprescription.Text = "PRESCRIPTION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 87;
            label1.Text = "Prescription";
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 781);
            Controls.Add(label1);
            Controls.Add(lblprescription);
            Controls.Add(richTextBoxprescription);
            Controls.Add(textBox1);
            Controls.Add(lblcost);
            Controls.Add(comboBoxtestid);
            Controls.Add(pictureBoxclose);
            Controls.Add(panelbottom);
            Controls.Add(panelsidebar);
            Controls.Add(comboBoxdoctorid);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(dataGridViewpatients);
            Controls.Add(txttest);
            Controls.Add(lbltest);
            Controls.Add(lblpatientname);
            Controls.Add(txtpatientname);
            Controls.Add(txtmedicines);
            Controls.Add(lblmedicines);
            Controls.Add(comboBoxpatientid);
            Controls.Add(txtdoctorname);
            Controls.Add(lbldoctorname);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prescriptions";
            Text = "Prescriptions";
            Load += Prescriptions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewpatients).EndInit();
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
        private ComboBox comboBoxdoctorid;
        private Button btndelete;
        private Button btnadd;
        private DataGridView dataGridViewpatients;
        private TextBox txttest;
        private Label lbltest;
        private Label lblpatientname;
        private TextBox txtpatientname;
        private TextBox txtmedicines;
        private Label lblmedicines;
        private ComboBox comboBoxpatientid;
        private TextBox txtdoctorname;
        private Label lbldoctorname;
        private Label label2;
        private Panel panelbottom;
        private Panel panelsidebar;
        private Label lbllogout;
        private PictureBox pictureBox9;
        private PictureBox pictureBoxlogo;
        private PictureBox pictureBoxclose;
        private ComboBox comboBoxtestid;
        private TextBox textBox1;
        private Label lblcost;
        private RichTextBox richTextBoxprescription;
        private Label lblprescription;
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