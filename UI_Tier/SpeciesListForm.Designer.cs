namespace UI_Tier
{
	partial class SpeciesListForm
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
			lblTitle = new Label();
			btnBack = new Button();
			dgvSpecies = new DataGridView();
			SpcId = new DataGridViewTextBoxColumn();
			SpcName = new DataGridViewTextBoxColumn();
			lblSpcName = new Label();
			txtSpcName = new TextBox();
			lblId = new Label();
			lblIdValue = new Label();
			btnSubmit = new Button();
			btnDelete = new Button();
			btnClear = new Button();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSpecies).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(87, 204, 153);
			panelHeader.Controls.Add(label1);
			panelHeader.Controls.Add(btnReload);
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(684, 60);
			panelHeader.TabIndex = 2;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(35, 25, 66);
			label1.Location = new Point(224, 13);
			label1.Name = "label1";
			label1.Size = new Size(241, 33);
			label1.TabIndex = 3;
			label1.Text = "DANH SÁCH LOÀI";
			// 
			// btnReload
			// 
			btnReload.BackColor = Color.FromArgb(94, 84, 142);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnReload.ForeColor = Color.White;
			btnReload.Location = new Point(544, 12);
			btnReload.Margin = new Padding(3, 4, 3, 4);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(128, 36);
			btnReload.TabIndex = 5;
			btnReload.Text = "Làm mới";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblTitle.Location = new Point(274, 15);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(753, 0);
			lblTitle.TabIndex = 2;
			lblTitle.Text = "DANH SÁCH GIỐNG";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.FromArgb(255, 229, 217);
			btnBack.FlatStyle = FlatStyle.Flat;
			btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnBack.ForeColor = SystemColors.ActiveCaptionText;
			btnBack.Location = new Point(12, 12);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(128, 36);
			btnBack.TabIndex = 7;
			btnBack.Text = "< Back to menu";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// dgvSpecies
			// 
			dgvSpecies.AllowUserToAddRows = false;
			dgvSpecies.AllowUserToDeleteRows = false;
			dgvSpecies.BackgroundColor = SystemColors.Control;
			dgvSpecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSpecies.Columns.AddRange(new DataGridViewColumn[] { SpcId, SpcName });
			dgvSpecies.Location = new Point(21, 87);
			dgvSpecies.Name = "dgvSpecies";
			dgvSpecies.ReadOnly = true;
			dgvSpecies.RowHeadersWidth = 51;
			dgvSpecies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSpecies.Size = new Size(381, 203);
			dgvSpecies.TabIndex = 6;
			dgvSpecies.CellClick += dgvSpecies_CellClick;
			// 
			// SpcId
			// 
			SpcId.HeaderText = "Id";
			SpcId.MinimumWidth = 6;
			SpcId.Name = "SpcId";
			SpcId.ReadOnly = true;
			SpcId.Width = 125;
			// 
			// SpcName
			// 
			SpcName.HeaderText = "Tên loài";
			SpcName.MinimumWidth = 6;
			SpcName.Name = "SpcName";
			SpcName.ReadOnly = true;
			SpcName.Width = 175;
			// 
			// lblSpcName
			// 
			lblSpcName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSpcName.Location = new Point(433, 122);
			lblSpcName.Margin = new Padding(3, 8, 3, 4);
			lblSpcName.Name = "lblSpcName";
			lblSpcName.Size = new Size(144, 23);
			lblSpcName.TabIndex = 4;
			lblSpcName.Text = "Tên loài thú cưng";
			// 
			// txtSpcName
			// 
			txtSpcName.Location = new Point(433, 152);
			txtSpcName.Name = "txtSpcName";
			txtSpcName.PlaceholderText = "Nhập tên loài";
			txtSpcName.Size = new Size(230, 27);
			txtSpcName.TabIndex = 0;
			// 
			// lblId
			// 
			lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblId.Location = new Point(433, 87);
			lblId.Margin = new Padding(3, 8, 3, 4);
			lblId.Name = "lblId";
			lblId.Size = new Size(37, 23);
			lblId.TabIndex = 6;
			lblId.Text = "Id";
			// 
			// lblIdValue
			// 
			lblIdValue.AutoSize = true;
			lblIdValue.Location = new Point(473, 88);
			lblIdValue.Margin = new Padding(3, 11, 3, 4);
			lblIdValue.Name = "lblIdValue";
			lblIdValue.Size = new Size(104, 20);
			lblIdValue.TabIndex = 7;
			lblIdValue.Text = "Auto generate";
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.FromArgb(56, 163, 165);
			btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
			btnSubmit.Location = new Point(561, 207);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(100, 32);
			btnSubmit.TabIndex = 2;
			btnSubmit.Text = "Lưu";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(229, 107, 111);
			btnDelete.Enabled = false;
			btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.ForeColor = SystemColors.ActiveCaptionText;
			btnDelete.Location = new Point(433, 207);
			btnDelete.Name = "btnDelete";
			btnDelete.RightToLeft = RightToLeft.No;
			btnDelete.Size = new Size(100, 32);
			btnDelete.TabIndex = 4;
			btnDelete.Text = "Xóa";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.FromArgb(224, 177, 203);
			btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClear.ForeColor = SystemColors.ActiveCaptionText;
			btnClear.Location = new Point(490, 258);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(120, 32);
			btnClear.TabIndex = 3;
			btnClear.Text = "Đặt lại";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// SpeciesListForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(684, 313);
			Controls.Add(btnClear);
			Controls.Add(btnDelete);
			Controls.Add(btnSubmit);
			Controls.Add(lblIdValue);
			Controls.Add(lblId);
			Controls.Add(txtSpcName);
			Controls.Add(lblSpcName);
			Controls.Add(dgvSpecies);
			Controls.Add(panelHeader);
			Name = "SpeciesListForm";
			Text = "Danh sách loài thú cưng | PET STORE MANAGEMENT";
			Load += SpeciesListForm_Load;
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvSpecies).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Button btnReload;
		private Label lblTitle;
		private Button btnBack;
		private Label label1;
		private DataGridView dgvSpecies;
		private DataGridViewTextBoxColumn SpcId;
		private DataGridViewTextBoxColumn SpcName;
		private Label lblSpcName;
		private TextBox txtSpcName;
		private Label lblId;
		private Label lblIdValue;
		private Button btnSubmit;
		private Button btnDelete;
		private Button btnClear;
	}
}