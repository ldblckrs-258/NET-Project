namespace UI_Tier
{
	partial class MyAccountForm
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
			panelHeader = new Panel();
			label1 = new Label();
			btnReload = new Button();
			btnBack = new Button();
			lblFullName = new Label();
			txtFullName = new TextBox();
			lblDate = new Label();
			dtpDate = new DateTimePicker();
			lblRole = new Label();
			txtRole = new TextBox();
			lblUsername = new Label();
			txtUsername = new TextBox();
			lblPwd = new Label();
			txtPwd = new TextBox();
			lblNPwd = new Label();
			txtNPwd = new TextBox();
			btnUpdate = new Button();
			btnCPW = new Button();
			btnCancel = new Button();
			panelHeader.SuspendLayout();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(255, 229, 217);
			panelHeader.Controls.Add(label1);
			panelHeader.Controls.Add(btnReload);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(800, 60);
			panelHeader.TabIndex = 2;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(35, 25, 66);
			label1.Location = new Point(262, 15);
			label1.Name = "label1";
			label1.Size = new Size(266, 33);
			label1.TabIndex = 20;
			label1.Text = "TÀI KHOẢN CÁ NHÂN";
			// 
			// btnReload
			// 
			btnReload.BackColor = Color.FromArgb(94, 84, 142);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnReload.ForeColor = Color.White;
			btnReload.Location = new Point(660, 12);
			btnReload.Margin = new Padding(3, 4, 3, 4);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(128, 36);
			btnReload.TabIndex = 10;
			btnReload.Text = "Làm mới";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.FromArgb(216, 226, 220);
			btnBack.FlatStyle = FlatStyle.Flat;
			btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnBack.ForeColor = SystemColors.ActiveCaptionText;
			btnBack.Location = new Point(12, 12);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(128, 36);
			btnBack.TabIndex = 11;
			btnBack.Text = "< Back to menu";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// lblFullName
			// 
			lblFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblFullName.Location = new Point(26, 95);
			lblFullName.Margin = new Padding(3, 8, 3, 4);
			lblFullName.Name = "lblFullName";
			lblFullName.Size = new Size(114, 23);
			lblFullName.TabIndex = 23;
			lblFullName.Text = "Họ và tên";
			// 
			// txtFullName
			// 
			txtFullName.Location = new Point(149, 91);
			txtFullName.Margin = new Padding(3, 4, 3, 4);
			txtFullName.Name = "txtFullName";
			txtFullName.PlaceholderText = "Nhập tên của bạn";
			txtFullName.Size = new Size(245, 27);
			txtFullName.TabIndex = 1;
			// 
			// lblDate
			// 
			lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDate.Location = new Point(26, 140);
			lblDate.Margin = new Padding(3, 8, 3, 4);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(114, 23);
			lblDate.TabIndex = 24;
			lblDate.Text = "Ngày sinh";
			// 
			// dtpDate
			// 
			dtpDate.Format = DateTimePickerFormat.Short;
			dtpDate.Location = new Point(146, 136);
			dtpDate.Name = "dtpDate";
			dtpDate.Size = new Size(245, 27);
			dtpDate.TabIndex = 2;
			// 
			// lblRole
			// 
			lblRole.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRole.Location = new Point(26, 181);
			lblRole.Margin = new Padding(3, 8, 3, 4);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(114, 23);
			lblRole.TabIndex = 25;
			lblRole.Text = "Vai trò";
			// 
			// txtRole
			// 
			txtRole.Location = new Point(149, 179);
			txtRole.Margin = new Padding(3, 4, 3, 4);
			txtRole.Name = "txtRole";
			txtRole.PlaceholderText = "Vai trò của bạn";
			txtRole.ReadOnly = true;
			txtRole.Size = new Size(245, 27);
			txtRole.TabIndex = 3;
			// 
			// lblUsername
			// 
			lblUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsername.Location = new Point(429, 95);
			lblUsername.Margin = new Padding(3, 8, 3, 4);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(125, 23);
			lblUsername.TabIndex = 21;
			lblUsername.Text = "Tên đăng nhập";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(580, 93);
			txtUsername.Margin = new Padding(3, 4, 3, 4);
			txtUsername.Name = "txtUsername";
			txtUsername.PlaceholderText = "Tên đăng nhập của bạn";
			txtUsername.ReadOnly = true;
			txtUsername.Size = new Size(187, 27);
			txtUsername.TabIndex = 4;
			// 
			// lblPwd
			// 
			lblPwd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPwd.Location = new Point(429, 140);
			lblPwd.Margin = new Padding(3, 8, 3, 4);
			lblPwd.Name = "lblPwd";
			lblPwd.Size = new Size(125, 23);
			lblPwd.TabIndex = 22;
			lblPwd.Text = "Mật khẩu cũ";
			lblPwd.Visible = false;
			// 
			// txtPwd
			// 
			txtPwd.Location = new Point(583, 138);
			txtPwd.Margin = new Padding(3, 4, 3, 4);
			txtPwd.MaxLength = 20;
			txtPwd.Name = "txtPwd";
			txtPwd.PlaceholderText = "Nhập mật khẩu hiện tại";
			txtPwd.Size = new Size(187, 27);
			txtPwd.TabIndex = 5;
			txtPwd.UseSystemPasswordChar = true;
			txtPwd.Visible = false;
			// 
			// lblNPwd
			// 
			lblNPwd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNPwd.Location = new Point(429, 181);
			lblNPwd.Margin = new Padding(3, 8, 3, 4);
			lblNPwd.Name = "lblNPwd";
			lblNPwd.Size = new Size(148, 23);
			lblNPwd.TabIndex = 14;
			lblNPwd.Text = "Mật khẩu mới";
			lblNPwd.Visible = false;
			// 
			// txtNPwd
			// 
			txtNPwd.Location = new Point(583, 179);
			txtNPwd.Margin = new Padding(3, 4, 3, 4);
			txtNPwd.MaxLength = 20;
			txtNPwd.Name = "txtNPwd";
			txtNPwd.PlaceholderText = "Nhập mật khẩu mới";
			txtNPwd.Size = new Size(187, 27);
			txtNPwd.TabIndex = 6;
			txtNPwd.UseSystemPasswordChar = true;
			txtNPwd.Visible = false;
			txtNPwd.WordWrap = false;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(128, 237, 153);
			btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
			btnUpdate.Location = new Point(26, 229);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.RightToLeft = RightToLeft.No;
			btnUpdate.Size = new Size(120, 32);
			btnUpdate.TabIndex = 7;
			btnUpdate.Text = "Cập nhật";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnCPW
			// 
			btnCPW.BackColor = Color.FromArgb(224, 177, 203);
			btnCPW.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCPW.ForeColor = SystemColors.ActiveCaptionText;
			btnCPW.Location = new Point(601, 229);
			btnCPW.Name = "btnCPW";
			btnCPW.RightToLeft = RightToLeft.No;
			btnCPW.Size = new Size(169, 32);
			btnCPW.TabIndex = 8;
			btnCPW.Text = "Đổi mật khẩu";
			btnCPW.UseVisualStyleBackColor = false;
			btnCPW.Click += btnCPW_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(255, 229, 217);
			btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCancel.ForeColor = SystemColors.ActiveCaptionText;
			btnCancel.Location = new Point(429, 229);
			btnCancel.Name = "btnCancel";
			btnCancel.RightToLeft = RightToLeft.No;
			btnCancel.Size = new Size(120, 32);
			btnCancel.TabIndex = 9;
			btnCancel.Text = "Hủy";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Visible = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// MyAccountForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 280);
			Controls.Add(btnCancel);
			Controls.Add(btnCPW);
			Controls.Add(btnUpdate);
			Controls.Add(txtNPwd);
			Controls.Add(lblNPwd);
			Controls.Add(txtPwd);
			Controls.Add(lblPwd);
			Controls.Add(txtUsername);
			Controls.Add(lblUsername);
			Controls.Add(txtRole);
			Controls.Add(lblRole);
			Controls.Add(dtpDate);
			Controls.Add(lblDate);
			Controls.Add(txtFullName);
			Controls.Add(lblFullName);
			Controls.Add(panelHeader);
			Name = "MyAccountForm";
			Text = "Tài khoản cá nhân | PET STORE MANAGEMENT";
			Load += MyAccountForm_Load;
			panelHeader.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Button btnReload;
		private Button btnBack;
		private Label label1;
		private Label lblFullName;
		private TextBox txtFullName;
		private Label lblDate;
		private DateTimePicker dtpDate;
		private Label lblRole;
		private TextBox txtRole;
		private Label lblUsername;
		private TextBox txtUsername;
		private Label lblPwd;
		private TextBox txtPwd;
		private Label lblNPwd;
		private TextBox txtNPwd;
		private Button btnUpdate;
		private Button btnCPW;
		private Button btnCancel;
	}
}