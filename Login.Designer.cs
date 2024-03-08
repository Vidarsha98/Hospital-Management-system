namespace WinFormsApp2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblhealthcareplus = new Label();
            pictureBoxlogo = new PictureBox();
            comboBoxusertype = new ComboBox();
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblusertype = new Label();
            btnlogin = new Button();
            lblreset = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblhealthcareplus);
            panel1.Controls.Add(pictureBoxlogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 63);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(610, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblhealthcareplus
            // 
            lblhealthcareplus.AutoSize = true;
            lblhealthcareplus.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblhealthcareplus.ForeColor = Color.Coral;
            lblhealthcareplus.Location = new Point(287, 29);
            lblhealthcareplus.Name = "lblhealthcareplus";
            lblhealthcareplus.Size = new Size(297, 34);
            lblhealthcareplus.TabIndex = 1;
            lblhealthcareplus.Text = "Health Care Plus";
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.BackgroundImage = (Image)resources.GetObject("pictureBoxlogo.BackgroundImage");
            pictureBoxlogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxlogo.Location = new Point(0, -29);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(162, 123);
            pictureBoxlogo.TabIndex = 1;
            pictureBoxlogo.TabStop = false;
            // 
            // comboBoxusertype
            // 
            comboBoxusertype.BackColor = SystemColors.WindowFrame;
            comboBoxusertype.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxusertype.ForeColor = SystemColors.InfoText;
            comboBoxusertype.FormattingEnabled = true;
            comboBoxusertype.Items.AddRange(new object[] { "Admin", "Doctor", "Reciptionist" });
            comboBoxusertype.Location = new Point(232, 164);
            comboBoxusertype.Name = "comboBoxusertype";
            comboBoxusertype.Size = new Size(210, 23);
            comboBoxusertype.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.ForeColor = SystemColors.ActiveCaptionText;
            lblusername.Location = new Point(146, 243);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(81, 20);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.ForeColor = SystemColors.ActiveCaptionText;
            lblpassword.Location = new Point(150, 305);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(81, 20);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.WindowFrame;
            txtusername.Location = new Point(232, 240);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(210, 23);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.WindowFrame;
            txtpassword.Location = new Point(232, 302);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(210, 23);
            txtpassword.TabIndex = 5;
            // 
            // lblusertype
            // 
            lblusertype.AutoSize = true;
            lblusertype.BackColor = Color.Transparent;
            lblusertype.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblusertype.ForeColor = SystemColors.ActiveCaptionText;
            lblusertype.Location = new Point(152, 164);
            lblusertype.Name = "lblusertype";
            lblusertype.Size = new Size(79, 20);
            lblusertype.TabIndex = 6;
            lblusertype.Text = "UserType";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(271, 357);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(149, 30);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            // 
            // lblreset
            // 
            lblreset.AutoSize = true;
            lblreset.BackColor = Color.Silver;
            lblreset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblreset.ForeColor = SystemColors.ActiveCaptionText;
            lblreset.Location = new Point(313, 390);
            lblreset.Name = "lblreset";
            lblreset.Size = new Size(48, 20);
            lblreset.TabIndex = 8;
            lblreset.Text = "Reset";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 472);
            Controls.Add(lblreset);
            Controls.Add(btnlogin);
            Controls.Add(lblusertype);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(comboBoxusertype);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxlogo;
        private Label lblhealthcareplus;
        private ComboBox comboBoxusertype;
        private Label lblusername;
        private Label lblpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblusertype;
        private Button btnlogin;
        private Label lblreset;
        private PictureBox pictureBox1;
    }
}