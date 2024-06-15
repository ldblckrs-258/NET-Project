using System.Globalization;

namespace UI_Tier
{
	partial class PetListForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panelHeader = new Panel();
			btnAdd = new Button();
			btnBack = new Button();
			lblTitle = new Label();
			dgvPets = new DataGridView();
			PetId = new DataGridViewTextBoxColumn();
			PetName = new DataGridViewTextBoxColumn();
			PetSpecies = new DataGridViewTextBoxColumn();
			PetBornYear = new DataGridViewTextBoxColumn();
			PetPrice = new DataGridViewTextBoxColumn();
			PetIsSold = new DataGridViewCheckBoxColumn();
			txtSearch = new TextBox();
			btnSearch = new Button();
			cbIsSold = new ComboBox();
			btnReset = new Button();
			txtTotal = new TextBox();
			lblTotal = new Label();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(87, 204, 153);
			panelHeader.Controls.Add(btnAdd);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(888, 60);
			panelHeader.TabIndex = 0;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(255, 229, 217);
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAdd.Location = new Point(748, 12);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(128, 36);
			btnAdd.TabIndex = 6;
			btnAdd.Text = "+ Thêm mới";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.FromArgb(255, 229, 217);
			btnBack.FlatStyle = FlatStyle.Flat;
			btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnBack.Location = new Point(12, 12);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(128, 36);
			btnBack.TabIndex = 7;
			btnBack.Text = "< Back to menu";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblTitle.Location = new Point(309, 12);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(289, 33);
			lblTitle.TabIndex = 10;
			lblTitle.Text = "DANH SÁCH THÚ CƯNG";
			// 
			// dgvPets
			// 
			dgvPets.AllowUserToAddRows = false;
			dgvPets.AllowUserToDeleteRows = false;
			dgvPets.AllowUserToOrderColumns = true;
			dgvPets.BackgroundColor = SystemColors.Control;
			dgvPets.BorderStyle = BorderStyle.None;
			dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPets.Columns.AddRange(new DataGridViewColumn[] { PetId, PetName, PetSpecies, PetBornYear, PetPrice, PetIsSold });
			dgvPets.Location = new Point(64, 137);
			dgvPets.Margin = new Padding(3, 4, 3, 4);
			dgvPets.Name = "dgvPets";
			dgvPets.ReadOnly = true;
			dgvPets.RowHeadersWidth = 51;
			dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPets.Size = new Size(772, 318);
			dgvPets.TabIndex = 4;
			dgvPets.CellDoubleClick += dgvPets_CellDoubleClick;
			// 
			// PetId
			// 
			PetId.HeaderText = "ID";
			PetId.MinimumWidth = 6;
			PetId.Name = "PetId";
			PetId.ReadOnly = true;
			PetId.Width = 80;
			// 
			// PetName
			// 
			PetName.HeaderText = "Tên thú cưng";
			PetName.MinimumWidth = 6;
			PetName.Name = "PetName";
			PetName.ReadOnly = true;
			PetName.Width = 160;
			// 
			// PetSpecies
			// 
			PetSpecies.HeaderText = "Giống thú cưng";
			PetSpecies.MinimumWidth = 6;
			PetSpecies.Name = "PetSpecies";
			PetSpecies.ReadOnly = true;
			PetSpecies.Width = 140;
			// 
			// PetBornYear
			// 
			PetBornYear.HeaderText = "Năm sinh";
			PetBornYear.MinimumWidth = 6;
			PetBornYear.Name = "PetBornYear";
			PetBornYear.ReadOnly = true;
			PetBornYear.Width = 125;
			// 
			// PetPrice
			// 
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "C0";
			dataGridViewCellStyle1.FormatProvider = new CultureInfo("vi-VN");
			PetPrice.DefaultCellStyle = dataGridViewCellStyle1;
			PetPrice.HeaderText = "Giá bán";
			PetPrice.MinimumWidth = 6;
			PetPrice.Name = "PetPrice";
			PetPrice.ReadOnly = true;
			PetPrice.Width = 120;
			// 
			// PetIsSold
			// 
			PetIsSold.HeaderText = "Đã bán?";
			PetIsSold.MinimumWidth = 6;
			PetIsSold.Name = "PetIsSold";
			PetIsSold.ReadOnly = true;
			PetIsSold.Width = 80;
			// 
			// txtSearch
			// 
			txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSearch.Location = new Point(64, 87);
			txtSearch.Margin = new Padding(3, 4, 3, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Nhập tên cần tìm kiếm";
			txtSearch.Size = new Size(182, 29);
			txtSearch.TabIndex = 0;
			txtSearch.KeyDown += txtSearch_KeyDown;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = Color.FromArgb(199, 249, 204);
			btnSearch.Location = new Point(267, 85);
			btnSearch.Margin = new Padding(3, 4, 3, 4);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(113, 37);
			btnSearch.TabIndex = 1;
			btnSearch.Text = "Tìm kiếm";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// cbIsSold
			// 
			cbIsSold.DropDownStyle = ComboBoxStyle.DropDownList;
			cbIsSold.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbIsSold.Items.AddRange(new object[] { "Tất cả", "Đã bán", "Chưa bán" });
			cbIsSold.Location = new Point(683, 87);
			cbIsSold.Margin = new Padding(3, 4, 3, 4);
			cbIsSold.Name = "cbIsSold";
			cbIsSold.Size = new Size(138, 29);
			cbIsSold.TabIndex = 3;
			cbIsSold.SelectedIndexChanged += cbIsSold_SelectedIndexChanged;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb(224, 177, 203);
			btnReset.Location = new Point(554, 83);
			btnReset.Margin = new Padding(3, 4, 3, 4);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(113, 37);
			btnReset.TabIndex = 2;
			btnReset.Text = "Đặt lại";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(668, 465);
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.Size = new Size(153, 27);
			txtTotal.TabIndex = 5;
			txtTotal.TextAlign = HorizontalAlignment.Right;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotal.Location = new Point(567, 468);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(95, 20);
			lblTotal.TabIndex = 6;
			lblTotal.Text = "Tổng đã bán";
			// 
			// PetListForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(888, 504);
			Controls.Add(lblTotal);
			Controls.Add(txtTotal);
			Controls.Add(btnReset);
			Controls.Add(cbIsSold);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(dgvPets);
			Controls.Add(panelHeader);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PetListForm";
			Text = "Danh sách thú cưng | PET STORE MANAGEMENT";
			Load += PetListForm_Load;
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Label lblTitle;
		private Button btnBack;
		private DataGridView dgvPets;
		private TextBox txtSearch;
		private Button btnSearch;
		private ComboBox cbIsSold;
		private DataGridViewTextBoxColumn PetId;
		private DataGridViewTextBoxColumn PetName;
		private DataGridViewTextBoxColumn PetSpecies;
		private DataGridViewTextBoxColumn PetBornYear;
		private DataGridViewTextBoxColumn PetPrice;
		private DataGridViewCheckBoxColumn PetIsSold;
		private Button btnAdd;
		private Button btnReset;
		private TextBox txtTotal;
		private Label lblTotal;
	}
}