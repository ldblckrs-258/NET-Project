namespace UI_Tier
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			panel1 = new Panel();
			lblNote = new Label();
			lblAppName = new Label();
			picLoginGraphic = new PictureBox();
			lblTitle = new Label();
			lblUsername = new Label();
			txtUsername = new TextBox();
			lblPassword = new Label();
			txtPassword = new TextBox();
			cbRemember = new CheckBox();
			btnLogin = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picLoginGraphic).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(199, 249, 204);
			panel1.Controls.Add(lblNote);
			panel1.Controls.Add(lblAppName);
			panel1.Controls.Add(picLoginGraphic);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(355, 535);
			panel1.TabIndex = 0;
			// 
			// lblNote
			// 
			lblNote.AutoSize = true;
			lblNote.ForeColor = Color.FromArgb(94, 84, 142);
			lblNote.Location = new Point(14, 483);
			lblNote.MaximumSize = new Size(329, 0);
			lblNote.Name = "lblNote";
			lblNote.RightToLeft = RightToLeft.No;
			lblNote.Size = new Size(322, 40);
			lblNote.TabIndex = 2;
			lblNote.Text = "Không có tài khoản? Vui lòng liên hệ quản lý của bạn để được cấp tài khoản.";
			// 
			// lblAppName
			// 
			lblAppName.AutoSize = true;
			lblAppName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAppName.ForeColor = Color.FromArgb(35, 25, 66);
			lblAppName.Location = new Point(18, 23);
			lblAppName.Name = "lblAppName";
			lblAppName.Size = new Size(318, 32);
			lblAppName.TabIndex = 1;
			lblAppName.Text = "PET STORE MANAGEMENT";
			lblAppName.TextAlign = ContentAlignment.TopCenter;
			// 
			// picLoginGraphic
			// 
			picLoginGraphic.Image = (Image)resources.GetObject("picLoginGraphic.Image");
			picLoginGraphic.InitialImage = null;
			picLoginGraphic.Location = new Point(62, 127);
			picLoginGraphic.MaximumSize = new Size(229, 267);
			picLoginGraphic.Name = "picLoginGraphic";
			picLoginGraphic.Padding = new Padding(23, 27, 23, 27);
			picLoginGraphic.Size = new Size(229, 267);
			picLoginGraphic.SizeMode = PictureBoxSizeMode.StretchImage;
			picLoginGraphic.TabIndex = 0;
			picLoginGraphic.TabStop = false;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblTitle.Location = new Point(399, 73);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(301, 32);
			lblTitle.TabIndex = 9;
			lblTitle.Text = "ĐĂNG NHẬP TÀI KHOẢN";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsername.Location = new Point(407, 156);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(143, 25);
			lblUsername.TabIndex = 8;
			lblUsername.Text = "Tên đăng nhập:";
			// 
			// txtUsername
			// 
			txtUsername.Anchor = AnchorStyles.Left;
			txtUsername.BackColor = Color.WhiteSmoke;
			txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtUsername.Location = new Point(409, 195);
			txtUsername.Margin = new Padding(3, 4, 3, 4);
			txtUsername.MaxLength = 30;
			txtUsername.Name = "txtUsername";
			txtUsername.PlaceholderText = "Nhập tên đăng nhập của bạn";
			txtUsername.Size = new Size(251, 29);
			txtUsername.TabIndex = 1;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPassword.Location = new Point(407, 261);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(99, 25);
			lblPassword.TabIndex = 7;
			lblPassword.Text = "Mật khẩu:";
			// 
			// txtPassword
			// 
			txtPassword.BackColor = Color.WhiteSmoke;
			txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtPassword.Location = new Point(407, 299);
			txtPassword.Margin = new Padding(3, 4, 3, 4);
			txtPassword.MaxLength = 20;
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Nhập mật khẩu của bạn";
			txtPassword.Size = new Size(251, 29);
			txtPassword.TabIndex = 2;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// cbRemember
			// 
			cbRemember.AutoSize = true;
			cbRemember.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cbRemember.Location = new Point(409, 363);
			cbRemember.Margin = new Padding(3, 4, 3, 4);
			cbRemember.Name = "cbRemember";
			cbRemember.Size = new Size(149, 27);
			cbRemember.TabIndex = 3;
			cbRemember.Text = "Lưu đăng nhập";
			cbRemember.UseVisualStyleBackColor = true;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(34, 87, 122);
			btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogin.ForeColor = Color.White;
			btnLogin.Location = new Point(523, 408);
			btnLogin.Margin = new Padding(3, 4, 3, 4);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(137, 43);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Đăng nhập";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(726, 535);
			Controls.Add(btnLogin);
			Controls.Add(cbRemember);
			Controls.Add(txtPassword);
			Controls.Add(lblPassword);
			Controls.Add(txtUsername);
			Controls.Add(lblUsername);
			Controls.Add(lblTitle);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "LoginForm";
			Text = "Đăng nhập | Pet Store Management";
			FormClosing += LoginForm_FormClosing;
			Load += LoginForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picLoginGraphic).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox picLoginGraphic;
		private Label lblAppName;
		private Label lblNote;
		private Label lblTitle;
		private Label lblUsername;
		private TextBox txtUsername;
		private Label lblPassword;
		private TextBox txtPassword;
		private CheckBox cbRemember;
		private Button btnLogin;
	}
}