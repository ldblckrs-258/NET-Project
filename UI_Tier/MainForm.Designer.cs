namespace UI_Tier
{
	partial class MainForm
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
			this.FormClosing += MainForm_FormClosing;

			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			panelHeader = new Panel();
			btnLogout = new Button();
			lblName = new Label();
			lblAppTitle = new Label();
			pictureBox1 = new PictureBox();
			btnOpenPets = new Button();
			layoutMain = new FlowLayoutPanel();
			btnOpenBreed = new Button();
			btnOpenSpecies = new Button();
			btnMyAccount = new Button();
			btnUsers = new Button();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			layoutMain.SuspendLayout();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(87, 204, 153);
			panelHeader.Controls.Add(btnLogout);
			panelHeader.Controls.Add(lblName);
			panelHeader.Controls.Add(lblAppTitle);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(0, 0, 0, 40);
			panelHeader.Name = "panelHeader";
			panelHeader.Padding = new Padding(23, 13, 23, 0);
			panelHeader.Size = new Size(658, 53);
			panelHeader.TabIndex = 0;
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.FromArgb(87, 204, 153);
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatStyle = FlatStyle.System;
			btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogout.Location = new Point(525, 11);
			btnLogout.Margin = new Padding(3, 4, 3, 4);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(107, 35);
			btnLogout.TabIndex = 6;
			btnLogout.Text = "Đăng xuất";
			btnLogout.UseVisualStyleBackColor = false;
			btnLogout.Click += btnLogout_Click;
			// 
			// lblName
			// 
			lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblName.ForeColor = Color.FromArgb(35, 25, 66);
			lblName.Location = new Point(243, 16);
			lblName.Name = "lblName";
			lblName.Size = new Size(276, 23);
			lblName.TabIndex = 0;
			lblName.Text = "Admin User (Chủ cửa hàng)";
			lblName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblAppTitle
			// 
			lblAppTitle.AutoSize = true;
			lblAppTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAppTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblAppTitle.Location = new Point(14, 16);
			lblAppTitle.Name = "lblAppTitle";
			lblAppTitle.Size = new Size(223, 23);
			lblAppTitle.TabIndex = 0;
			lblAppTitle.Text = "PET STORE MANAGEMENT";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(520, 451);
			pictureBox1.Margin = new Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(126, 105);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// btnOpenPets
			// 
			btnOpenPets.BackColor = Color.FromArgb(216, 226, 220);
			btnOpenPets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnOpenPets.ForeColor = Color.FromArgb(35, 25, 66);
			btnOpenPets.Location = new Point(11, 0);
			btnOpenPets.Margin = new Padding(11, 0, 11, 16);
			btnOpenPets.Name = "btnOpenPets";
			btnOpenPets.Size = new Size(320, 53);
			btnOpenPets.TabIndex = 1;
			btnOpenPets.Text = "Thú cưng";
			btnOpenPets.UseVisualStyleBackColor = false;
			btnOpenPets.Click += btnOpenPets_Click;
			// 
			// layoutMain
			// 
			layoutMain.Controls.Add(btnOpenPets);
			layoutMain.Controls.Add(btnOpenBreed);
			layoutMain.Controls.Add(btnOpenSpecies);
			layoutMain.Controls.Add(btnMyAccount);
			layoutMain.Controls.Add(btnUsers);
			layoutMain.Location = new Point(154, 127);
			layoutMain.Margin = new Padding(3, 4, 3, 4);
			layoutMain.Name = "layoutMain";
			layoutMain.Size = new Size(343, 332);
			layoutMain.TabIndex = 3;
			// 
			// btnOpenBreed
			// 
			btnOpenBreed.BackColor = Color.FromArgb(255, 229, 217);
			btnOpenBreed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnOpenBreed.ForeColor = Color.FromArgb(35, 25, 66);
			btnOpenBreed.Location = new Point(11, 69);
			btnOpenBreed.Margin = new Padding(11, 0, 11, 16);
			btnOpenBreed.Name = "btnOpenBreed";
			btnOpenBreed.Size = new Size(320, 53);
			btnOpenBreed.TabIndex = 2;
			btnOpenBreed.Text = "Giống";
			btnOpenBreed.UseVisualStyleBackColor = false;
			btnOpenBreed.Click += btnOpenBreed_Click;
			// 
			// btnOpenSpecies
			// 
			btnOpenSpecies.BackColor = Color.FromArgb(216, 226, 220);
			btnOpenSpecies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnOpenSpecies.ForeColor = Color.FromArgb(35, 25, 66);
			btnOpenSpecies.Location = new Point(11, 138);
			btnOpenSpecies.Margin = new Padding(11, 0, 11, 16);
			btnOpenSpecies.Name = "btnOpenSpecies";
			btnOpenSpecies.Size = new Size(320, 53);
			btnOpenSpecies.TabIndex = 3;
			btnOpenSpecies.Text = "Loài";
			btnOpenSpecies.UseVisualStyleBackColor = false;
			btnOpenSpecies.Click += btnOpenSpecies_Click;
			// 
			// btnMyAccount
			// 
			btnMyAccount.BackColor = Color.FromArgb(255, 229, 217);
			btnMyAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnMyAccount.ForeColor = Color.FromArgb(35, 25, 66);
			btnMyAccount.Location = new Point(11, 207);
			btnMyAccount.Margin = new Padding(11, 0, 11, 16);
			btnMyAccount.Name = "btnMyAccount";
			btnMyAccount.Size = new Size(320, 53);
			btnMyAccount.TabIndex = 4;
			btnMyAccount.Text = "Tài khoản cá nhân";
			btnMyAccount.UseVisualStyleBackColor = false;
			btnMyAccount.Click += btnMyAccount_Click;
			// 
			// btnUsers
			// 
			btnUsers.BackColor = Color.FromArgb(216, 226, 220);
			btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnUsers.ForeColor = Color.FromArgb(35, 25, 66);
			btnUsers.Location = new Point(11, 276);
			btnUsers.Margin = new Padding(11, 0, 11, 16);
			btnUsers.Name = "btnUsers";
			btnUsers.Size = new Size(320, 53);
			btnUsers.TabIndex = 5;
			btnUsers.Text = "Quản lý người dùng";
			btnUsers.UseVisualStyleBackColor = false;
			btnUsers.Click += btnUsers_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(658, 569);
			Controls.Add(layoutMain);
			Controls.Add(pictureBox1);
			Controls.Add(panelHeader);
			Margin = new Padding(3, 4, 3, 4);
			Name = "MainForm";
			Text = "PET STORE MANAGEMENT";
			Shown += MainForm_Shown;
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			layoutMain.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelHeader;
		private Label lblName;
		private Label lblAppTitle;
		private Button btnLogout;
		private PictureBox pictureBox1;
		private Button btnOpenPets;
		private FlowLayoutPanel layoutMain;
		private Button btnOpenBreed;
		private Button btnOpenSpecies;
		private Button btnMyAccount;
		private Button btnUsers;
	}
}