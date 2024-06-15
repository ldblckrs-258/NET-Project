namespace UI_Tier
{
	partial class BreedListForm
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
			btnReload = new Button();
			lblTitle = new Label();
			btnBack = new Button();
			dgvBreeds = new DataGridView();
			BreedId = new DataGridViewTextBoxColumn();
			BreedName = new DataGridViewTextBoxColumn();
			BreedSpecies = new DataGridViewTextBoxColumn();
			BreedDesc = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			lblBreedName = new Label();
			txtBreedName = new TextBox();
			lblSpecies = new Label();
			cbSpecies = new ComboBox();
			lblDesc = new Label();
			txtDesc = new TextBox();
			btnClear = new Button();
			btnSubmit = new Button();
			btnDelete = new Button();
			lblId = new Label();
			lblIdValue = new Label();
			lblDescription = new Label();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvBreeds).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(87, 204, 153);
			panelHeader.Controls.Add(btnReload);
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(809, 60);
			panelHeader.TabIndex = 13;
			// 
			// btnReload
			// 
			btnReload.BackColor = Color.FromArgb(94, 84, 142);
			btnReload.FlatStyle = FlatStyle.Flat;
			btnReload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnReload.ForeColor = Color.White;
			btnReload.Location = new Point(669, 12);
			btnReload.Margin = new Padding(3, 4, 3, 4);
			btnReload.Name = "btnReload";
			btnReload.Size = new Size(128, 36);
			btnReload.TabIndex = 2;
			btnReload.Text = "Làm mới";
			btnReload.UseVisualStyleBackColor = false;
			btnReload.Click += btnReload_Click;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblTitle.Location = new Point(294, 15);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(243, 33);
			lblTitle.TabIndex = 4;
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
			btnBack.TabIndex = 1;
			btnBack.Text = "< Back to menu";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// dgvBreeds
			// 
			dgvBreeds.AllowUserToAddRows = false;
			dgvBreeds.AllowUserToDeleteRows = false;
			dgvBreeds.BackgroundColor = SystemColors.Control;
			dgvBreeds.BorderStyle = BorderStyle.None;
			dgvBreeds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBreeds.Columns.AddRange(new DataGridViewColumn[] { BreedId, BreedName, BreedSpecies, BreedDesc });
			dgvBreeds.Location = new Point(34, 87);
			dgvBreeds.Name = "dgvBreeds";
			dgvBreeds.ReadOnly = true;
			dgvBreeds.RowHeadersWidth = 51;
			dgvBreeds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvBreeds.Size = new Size(754, 272);
			dgvBreeds.TabIndex = 12;
			dgvBreeds.CellClick += dgvBreeds_CellClick;
			// 
			// BreedId
			// 
			BreedId.HeaderText = "Id";
			BreedId.MinimumWidth = 6;
			BreedId.Name = "BreedId";
			BreedId.ReadOnly = true;
			BreedId.Width = 125;
			// 
			// BreedName
			// 
			BreedName.HeaderText = "Tên giống";
			BreedName.MinimumWidth = 6;
			BreedName.Name = "BreedName";
			BreedName.ReadOnly = true;
			BreedName.Width = 125;
			// 
			// BreedSpecies
			// 
			BreedSpecies.HeaderText = "Loài";
			BreedSpecies.MinimumWidth = 6;
			BreedSpecies.Name = "BreedSpecies";
			BreedSpecies.ReadOnly = true;
			BreedSpecies.Width = 80;
			// 
			// BreedDesc
			// 
			BreedDesc.HeaderText = "Mô tả";
			BreedDesc.MinimumWidth = 6;
			BreedDesc.Name = "BreedDesc";
			BreedDesc.ReadOnly = true;
			BreedDesc.Resizable = DataGridViewTriState.True;
			BreedDesc.SortMode = DataGridViewColumnSortMode.NotSortable;
			BreedDesc.Width = 350;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.AppWorkspace;
			panel1.Location = new Point(34, 365);
			panel1.Name = "panel1";
			panel1.Size = new Size(738, 1);
			panel1.TabIndex = 11;
			// 
			// lblBreedName
			// 
			lblBreedName.AutoSize = true;
			lblBreedName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblBreedName.ForeColor = Color.Black;
			lblBreedName.Location = new Point(34, 387);
			lblBreedName.Name = "lblBreedName";
			lblBreedName.Size = new Size(85, 23);
			lblBreedName.TabIndex = 10;
			lblBreedName.Text = "Tên giống";
			// 
			// txtBreedName
			// 
			txtBreedName.Location = new Point(148, 386);
			txtBreedName.Name = "txtBreedName";
			txtBreedName.PlaceholderText = "Nhập tên giống";
			txtBreedName.Size = new Size(167, 27);
			txtBreedName.TabIndex = 3;
			// 
			// lblSpecies
			// 
			lblSpecies.AutoSize = true;
			lblSpecies.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSpecies.ForeColor = Color.Black;
			lblSpecies.Location = new Point(34, 429);
			lblSpecies.Name = "lblSpecies";
			lblSpecies.Size = new Size(41, 23);
			lblSpecies.TabIndex = 9;
			lblSpecies.Text = "Loài";
			// 
			// cbSpecies
			// 
			cbSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
			cbSpecies.FormattingEnabled = true;
			cbSpecies.Location = new Point(148, 428);
			cbSpecies.Name = "cbSpecies";
			cbSpecies.Size = new Size(167, 28);
			cbSpecies.TabIndex = 4;
			// 
			// lblDesc
			// 
			lblDesc.AutoSize = true;
			lblDesc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDesc.ForeColor = Color.Black;
			lblDesc.Location = new Point(355, 429);
			lblDesc.Name = "lblDesc";
			lblDesc.Size = new Size(56, 23);
			lblDesc.TabIndex = 8;
			lblDesc.Text = "Mô tả";
			// 
			// txtDesc
			// 
			txtDesc.Location = new Point(443, 428);
			txtDesc.MaxLength = 400;
			txtDesc.Name = "txtDesc";
			txtDesc.PlaceholderText = "Nhập mô tả về giống thú cưng";
			txtDesc.Size = new Size(329, 27);
			txtDesc.TabIndex = 5;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.FromArgb(224, 177, 203);
			btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClear.ForeColor = SystemColors.ActiveCaptionText;
			btnClear.Location = new Point(343, 481);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(120, 32);
			btnClear.TabIndex = 7;
			btnClear.Text = "Đặt lại";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.FromArgb(56, 163, 165);
			btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
			btnSubmit.Location = new Point(652, 481);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(120, 32);
			btnSubmit.TabIndex = 6;
			btnSubmit.Text = "Thêm";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(229, 107, 111);
			btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.ForeColor = SystemColors.ActiveCaptionText;
			btnDelete.Location = new Point(34, 481);
			btnDelete.Name = "btnDelete";
			btnDelete.RightToLeft = RightToLeft.No;
			btnDelete.Size = new Size(120, 32);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Xóa";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblId.ForeColor = Color.Black;
			lblId.Location = new Point(355, 386);
			lblId.Name = "lblId";
			lblId.Size = new Size(25, 23);
			lblId.TabIndex = 2;
			lblId.Text = "Id";
			// 
			// lblIdValue
			// 
			lblIdValue.AutoSize = true;
			lblIdValue.ForeColor = SystemColors.ActiveCaptionText;
			lblIdValue.Location = new Point(443, 388);
			lblIdValue.Name = "lblIdValue";
			lblIdValue.Size = new Size(104, 20);
			lblIdValue.TabIndex = 1;
			lblIdValue.Text = "Auto generate";
			// 
			// lblDescription
			// 
			lblDescription.ForeColor = SystemColors.ActiveCaptionText;
			lblDescription.Location = new Point(34, 369);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(738, 99);
			lblDescription.TabIndex = 0;
			lblDescription.Text = "Nhấn vào một hàng để đọc chi tiết mô tả";
			lblDescription.Visible = false;
			// 
			// BreedListForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(809, 532);
			Controls.Add(lblDescription);
			Controls.Add(lblIdValue);
			Controls.Add(lblId);
			Controls.Add(btnDelete);
			Controls.Add(btnSubmit);
			Controls.Add(btnClear);
			Controls.Add(txtDesc);
			Controls.Add(lblDesc);
			Controls.Add(cbSpecies);
			Controls.Add(lblSpecies);
			Controls.Add(txtBreedName);
			Controls.Add(lblBreedName);
			Controls.Add(panel1);
			Controls.Add(dgvBreeds);
			Controls.Add(panelHeader);
			ForeColor = SystemColors.ActiveCaptionText;
			Name = "BreedListForm";
			Text = "Danh sách giống thú cưng | PET STORE MANAGEMENT";
			Load += BreedListForm_Load_1;
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvBreeds).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Button btnBack;
		private Label lblTitle;
		private Button btnReload;
		private DataGridView dgvBreeds;
		private DataGridViewTextBoxColumn BreedId;
		private DataGridViewTextBoxColumn BreedName;
		private DataGridViewTextBoxColumn BreedSpecies;
		private DataGridViewTextBoxColumn BreedDesc;
		private Panel panel1;
		private Label lblBreedName;
		private TextBox txtBreedName;
		private Label lblSpecies;
		private ComboBox cbSpecies;
		private Label lblDesc;
		private TextBox txtDesc;
		private Button btnClear;
		private Button btnSubmit;
		private Button btnDelete;
		private Label lblId;
		private Label lblIdValue;
		private Label lblDescription;
	}
}