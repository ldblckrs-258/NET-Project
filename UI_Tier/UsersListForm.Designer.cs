namespace UI_Tier
{
	partial class UsersListForm
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
			label2 = new Label();
			btnCreateMode = new Button();
			btnBack = new Button();
			dgvUsers = new DataGridView();
			UserId = new DataGridViewTextBoxColumn();
			UserFullName = new DataGridViewTextBoxColumn();
			Username = new DataGridViewTextBoxColumn();
			UserDoB = new DataGridViewTextBoxColumn();
			UserRole = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			lblId = new Label();
			txtId = new TextBox();
			lblFullName = new Label();
			txtFullName = new TextBox();
			lblDate = new Label();
			dtpDate = new DateTimePicker();
			lblUsername = new Label();
			txtUsername = new TextBox();
			lblRole = new Label();
			cbRole = new ComboBox();
			btnSubmit = new Button();
			btnDelete = new Button();
			lblPwd = new Label();
			txtPwd = new TextBox();
			btnRPW = new Button();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(255, 229, 217);
			panelHeader.Controls.Add(label2);
			panelHeader.Controls.Add(btnCreateMode);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(812, 60);
			panelHeader.TabIndex = 3;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(35, 25, 66);
			label2.Location = new Point(262, 15);
			label2.Name = "label2";
			label2.Size = new Size(282, 33);
			label2.TabIndex = 4;
			label2.Text = "QUẢN LÍ NGƯỜI DÙNG";
			// 
			// btnCreateMode
			// 
			btnCreateMode.BackColor = Color.FromArgb(94, 84, 142);
			btnCreateMode.FlatStyle = FlatStyle.Flat;
			btnCreateMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCreateMode.ForeColor = Color.White;
			btnCreateMode.Location = new Point(672, 12);
			btnCreateMode.Margin = new Padding(3, 4, 3, 4);
			btnCreateMode.Name = "btnCreateMode";
			btnCreateMode.Size = new Size(128, 36);
			btnCreateMode.TabIndex = 9;
			btnCreateMode.Text = "Tạo mới";
			btnCreateMode.UseVisualStyleBackColor = false;
			btnCreateMode.Click += btnCreateMode_Click;
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
			// dgvUsers
			// 
			dgvUsers.AllowUserToAddRows = false;
			dgvUsers.AllowUserToDeleteRows = false;
			dgvUsers.BackgroundColor = SystemColors.Control;
			dgvUsers.BorderStyle = BorderStyle.None;
			dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserId, UserFullName, Username, UserDoB, UserRole });
			dgvUsers.Location = new Point(57, 85);
			dgvUsers.Name = "dgvUsers";
			dgvUsers.ReadOnly = true;
			dgvUsers.RowHeadersWidth = 10;
			dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUsers.Size = new Size(708, 253);
			dgvUsers.TabIndex = 10;
			dgvUsers.CellClick += dgvUsers_CellContentClick;
			// 
			// UserId
			// 
			UserId.HeaderText = "ID";
			UserId.MinimumWidth = 6;
			UserId.Name = "UserId";
			UserId.ReadOnly = true;
			UserId.Width = 125;
			// 
			// UserFullName
			// 
			UserFullName.HeaderText = "Họ và tên";
			UserFullName.MinimumWidth = 6;
			UserFullName.Name = "UserFullName";
			UserFullName.ReadOnly = true;
			UserFullName.Width = 150;
			// 
			// Username
			// 
			Username.HeaderText = "Tên đăng nhập";
			Username.MinimumWidth = 6;
			Username.Name = "Username";
			Username.ReadOnly = true;
			Username.Width = 150;
			// 
			// UserDoB
			// 
			UserDoB.HeaderText = "Ngày sinh";
			UserDoB.MinimumWidth = 6;
			UserDoB.Name = "UserDoB";
			UserDoB.ReadOnly = true;
			UserDoB.Width = 125;
			// 
			// UserRole
			// 
			UserRole.HeaderText = "Vai trò";
			UserRole.MinimumWidth = 6;
			UserRole.Name = "UserRole";
			UserRole.ReadOnly = true;
			UserRole.Width = 125;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveBorder;
			panel1.Location = new Point(57, 344);
			panel1.Name = "panel1";
			panel1.Size = new Size(690, 1);
			panel1.TabIndex = 5;
			// 
			// lblId
			// 
			lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblId.Location = new Point(419, 360);
			lblId.Margin = new Padding(3, 8, 3, 4);
			lblId.Name = "lblId";
			lblId.Size = new Size(125, 23);
			lblId.TabIndex = 6;
			lblId.Text = "ID";
			lblId.TextAlign = ContentAlignment.TopRight;
			// 
			// txtId
			// 
			txtId.Location = new Point(560, 356);
			txtId.Margin = new Padding(3, 4, 3, 4);
			txtId.Name = "txtId";
			txtId.PlaceholderText = "Auto generate";
			txtId.ReadOnly = true;
			txtId.Size = new Size(187, 27);
			txtId.TabIndex = 7;
			// 
			// lblFullName
			// 
			lblFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblFullName.Location = new Point(57, 358);
			lblFullName.Margin = new Padding(3, 8, 3, 4);
			lblFullName.Name = "lblFullName";
			lblFullName.Size = new Size(114, 23);
			lblFullName.TabIndex = 8;
			lblFullName.Text = "Họ và tên";
			// 
			// txtFullName
			// 
			txtFullName.Location = new Point(177, 356);
			txtFullName.Margin = new Padding(3, 4, 3, 4);
			txtFullName.Name = "txtFullName";
			txtFullName.PlaceholderText = "Nhập tên của bạn";
			txtFullName.Size = new Size(211, 27);
			txtFullName.TabIndex = 1;
			// 
			// lblDate
			// 
			lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDate.Location = new Point(57, 393);
			lblDate.Margin = new Padding(3, 8, 3, 4);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(114, 23);
			lblDate.TabIndex = 10;
			lblDate.Text = "Ngày sinh";
			// 
			// dtpDate
			// 
			dtpDate.Format = DateTimePickerFormat.Short;
			dtpDate.Location = new Point(177, 389);
			dtpDate.Name = "dtpDate";
			dtpDate.Size = new Size(211, 27);
			dtpDate.TabIndex = 2;
			// 
			// lblUsername
			// 
			lblUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsername.Location = new Point(419, 393);
			lblUsername.Margin = new Padding(3, 8, 3, 4);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(125, 23);
			lblUsername.TabIndex = 12;
			lblUsername.Text = "Tên đăng nhập";
			lblUsername.TextAlign = ContentAlignment.TopRight;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(560, 391);
			txtUsername.Margin = new Padding(3, 4, 3, 4);
			txtUsername.Name = "txtUsername";
			txtUsername.PlaceholderText = "Tên đăng nhập";
			txtUsername.Size = new Size(187, 27);
			txtUsername.TabIndex = 4;
			// 
			// lblRole
			// 
			lblRole.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRole.Location = new Point(57, 428);
			lblRole.Margin = new Padding(3, 8, 3, 4);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(114, 23);
			lblRole.TabIndex = 14;
			lblRole.Text = "Vai trò";
			// 
			// cbRole
			// 
			cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
			cbRole.FormattingEnabled = true;
			cbRole.Location = new Point(177, 426);
			cbRole.Name = "cbRole";
			cbRole.Size = new Size(211, 28);
			cbRole.TabIndex = 3;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.FromArgb(128, 237, 153);
			btnSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
			btnSubmit.Location = new Point(627, 470);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.RightToLeft = RightToLeft.No;
			btnSubmit.Size = new Size(120, 36);
			btnSubmit.TabIndex = 6;
			btnSubmit.Text = "Lưu";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(229, 107, 111);
			btnDelete.Enabled = false;
			btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.ForeColor = Color.Black;
			btnDelete.Location = new Point(57, 470);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(120, 36);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Xóa";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// lblPwd
			// 
			lblPwd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPwd.Location = new Point(419, 428);
			lblPwd.Margin = new Padding(3, 8, 3, 4);
			lblPwd.Name = "lblPwd";
			lblPwd.Size = new Size(125, 23);
			lblPwd.TabIndex = 19;
			lblPwd.Text = "Mật khẩu";
			lblPwd.TextAlign = ContentAlignment.TopRight;
			// 
			// txtPwd
			// 
			txtPwd.Location = new Point(560, 426);
			txtPwd.Margin = new Padding(3, 4, 3, 4);
			txtPwd.MaxLength = 20;
			txtPwd.Name = "txtPwd";
			txtPwd.PlaceholderText = "Nhập mật khẩu";
			txtPwd.Size = new Size(187, 27);
			txtPwd.TabIndex = 5;
			txtPwd.UseSystemPasswordChar = true;
			txtPwd.WordWrap = false;
			// 
			// btnRPW
			// 
			btnRPW.BackColor = Color.FromArgb(224, 177, 203);
			btnRPW.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRPW.ForeColor = SystemColors.ActiveCaptionText;
			btnRPW.Location = new Point(320, 470);
			btnRPW.Name = "btnRPW";
			btnRPW.RightToLeft = RightToLeft.No;
			btnRPW.Size = new Size(169, 36);
			btnRPW.TabIndex = 7;
			btnRPW.Text = "Đặt lại mật khẩu";
			btnRPW.UseVisualStyleBackColor = false;
			btnRPW.Visible = false;
			btnRPW.Click += btnRPW_Click;
			// 
			// UsersListForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(812, 514);
			Controls.Add(btnRPW);
			Controls.Add(txtPwd);
			Controls.Add(lblPwd);
			Controls.Add(btnDelete);
			Controls.Add(btnSubmit);
			Controls.Add(cbRole);
			Controls.Add(lblRole);
			Controls.Add(txtUsername);
			Controls.Add(lblUsername);
			Controls.Add(dtpDate);
			Controls.Add(lblDate);
			Controls.Add(txtFullName);
			Controls.Add(lblFullName);
			Controls.Add(txtId);
			Controls.Add(lblId);
			Controls.Add(panel1);
			Controls.Add(dgvUsers);
			Controls.Add(panelHeader);
			Name = "UsersListForm";
			Text = "Quản lý người dùng | PET STORE MANAGEMENT";
			Load += UsersListForm_Load;
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Button btnCreateMode;
		private Button btnBack;
		private Label label2;
		private DataGridView dgvUsers;
		private DataGridViewTextBoxColumn UserId;
		private DataGridViewTextBoxColumn UserFullName;
		private DataGridViewTextBoxColumn Username;
		private DataGridViewTextBoxColumn UserDoB;
		private DataGridViewTextBoxColumn UserRole;
		private Panel panel1;
		private Label lblId;
		private TextBox txtId;
		private Label lblFullName;
		private TextBox txtFullName;
		private Label lblDate;
		private DateTimePicker dtpDate;
		private Label lblUsername;
		private TextBox txtUsername;
		private Label lblRole;
		private ComboBox cbRole;
		private Button btnSubmit;
		private Button btnDelete;
		private Label lblPwd;
		private TextBox txtPwd;
		private Button btnRPW;
	}
}