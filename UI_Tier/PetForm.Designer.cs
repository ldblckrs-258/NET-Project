namespace UI_Tier
{
	partial class PetForm
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
			btnSubmit = new Button();
			lblTitle = new Label();
			flpInfo = new FlowLayoutPanel();
			lblPetName = new Label();
			txtPetName = new TextBox();
			lblId = new Label();
			lblIdValue = new Label();
			lblGender = new Label();
			cbGender = new ComboBox();
			lblBornYear = new Label();
			txtBornYear = new TextBox();
			lblBreed = new Label();
			cbBreed = new ComboBox();
			lblSpc = new Label();
			lblSpcValue = new Label();
			lblPrice = new Label();
			txtPrice = new TextBox();
			lblWeight = new Label();
			txtWeight = new TextBox();
			lblDesc = new Label();
			txtDesc = new TextBox();
			lblImg = new Label();
			txtImgUrl = new TextBox();
			pbImage = new PictureBox();
			btnDelete = new Button();
			btnSold = new Button();
			btnPreview = new Button();
			panelHeader.SuspendLayout();
			flpInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(199, 249, 204);
			panelHeader.Controls.Add(btnSubmit);
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Margin = new Padding(3, 4, 3, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(883, 48);
			panelHeader.TabIndex = 0;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.FromArgb(56, 163, 165);
			btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSubmit.ForeColor = Color.White;
			btnSubmit.Location = new Point(751, 8);
			btnSubmit.Margin = new Padding(3, 4, 3, 4);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(120, 36);
			btnSubmit.TabIndex = 9;
			btnSubmit.Text = "Lưu";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.FromArgb(35, 25, 66);
			lblTitle.Location = new Point(14, 10);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(189, 28);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Thông tin thú cưng";
			// 
			// flpInfo
			// 
			flpInfo.Controls.Add(lblPetName);
			flpInfo.Controls.Add(txtPetName);
			flpInfo.Controls.Add(lblId);
			flpInfo.Controls.Add(lblIdValue);
			flpInfo.Controls.Add(lblGender);
			flpInfo.Controls.Add(cbGender);
			flpInfo.Controls.Add(lblBornYear);
			flpInfo.Controls.Add(txtBornYear);
			flpInfo.Controls.Add(lblBreed);
			flpInfo.Controls.Add(cbBreed);
			flpInfo.Controls.Add(lblSpc);
			flpInfo.Controls.Add(lblSpcValue);
			flpInfo.Controls.Add(lblPrice);
			flpInfo.Controls.Add(txtPrice);
			flpInfo.Controls.Add(lblWeight);
			flpInfo.Controls.Add(txtWeight);
			flpInfo.Controls.Add(lblDesc);
			flpInfo.Controls.Add(txtDesc);
			flpInfo.Controls.Add(lblImg);
			flpInfo.Controls.Add(txtImgUrl);
			flpInfo.Location = new Point(14, 75);
			flpInfo.Margin = new Padding(3, 4, 3, 4);
			flpInfo.Name = "flpInfo";
			flpInfo.Size = new Size(555, 220);
			flpInfo.TabIndex = 1;
			// 
			// lblPetName
			// 
			lblPetName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPetName.Location = new Point(3, 8);
			lblPetName.Margin = new Padding(3, 8, 3, 4);
			lblPetName.Name = "lblPetName";
			lblPetName.Size = new Size(114, 23);
			lblPetName.TabIndex = 0;
			lblPetName.Text = "Tên thú cưng";
			// 
			// txtPetName
			// 
			txtPetName.Location = new Point(123, 4);
			txtPetName.Margin = new Padding(3, 4, 3, 4);
			txtPetName.Name = "txtPetName";
			txtPetName.PlaceholderText = "Nhập tên thú cưng";
			txtPetName.Size = new Size(245, 27);
			txtPetName.TabIndex = 1;
			// 
			// lblId
			// 
			lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblId.Location = new Point(405, 8);
			lblId.Margin = new Padding(34, 8, 3, 4);
			lblId.Name = "lblId";
			lblId.Size = new Size(37, 23);
			lblId.TabIndex = 2;
			lblId.Text = "ID";
			// 
			// lblIdValue
			// 
			lblIdValue.AutoSize = true;
			lblIdValue.Location = new Point(448, 11);
			lblIdValue.Margin = new Padding(3, 11, 3, 4);
			lblIdValue.Name = "lblIdValue";
			lblIdValue.Size = new Size(104, 20);
			lblIdValue.TabIndex = 3;
			lblIdValue.Text = "Auto generate";
			// 
			// lblGender
			// 
			lblGender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGender.Location = new Point(3, 43);
			lblGender.Margin = new Padding(3, 8, 3, 4);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(114, 23);
			lblGender.TabIndex = 4;
			lblGender.Text = "Giới tính";
			// 
			// cbGender
			// 
			cbGender.FormattingEnabled = true;
			cbGender.Location = new Point(123, 39);
			cbGender.Margin = new Padding(3, 4, 3, 4);
			cbGender.Name = "cbGender";
			cbGender.Size = new Size(141, 28);
			cbGender.TabIndex = 2;
			// 
			// lblBornYear
			// 
			lblBornYear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblBornYear.Location = new Point(301, 43);
			lblBornYear.Margin = new Padding(34, 8, 3, 4);
			lblBornYear.Name = "lblBornYear";
			lblBornYear.Size = new Size(91, 23);
			lblBornYear.TabIndex = 6;
			lblBornYear.Text = "Năm sinh";
			// 
			// txtBornYear
			// 
			txtBornYear.Location = new Point(398, 39);
			txtBornYear.Margin = new Padding(3, 4, 3, 4);
			txtBornYear.Name = "txtBornYear";
			txtBornYear.PlaceholderText = "Nhập năm sinh";
			txtBornYear.Size = new Size(154, 27);
			txtBornYear.TabIndex = 3;
			txtBornYear.TextAlign = HorizontalAlignment.Center;
			// 
			// lblBreed
			// 
			lblBreed.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblBreed.Location = new Point(3, 79);
			lblBreed.Margin = new Padding(3, 8, 3, 4);
			lblBreed.Name = "lblBreed";
			lblBreed.Size = new Size(114, 23);
			lblBreed.TabIndex = 8;
			lblBreed.Text = "Giống";
			// 
			// cbBreed
			// 
			cbBreed.FormattingEnabled = true;
			cbBreed.Location = new Point(123, 75);
			cbBreed.Margin = new Padding(3, 4, 3, 4);
			cbBreed.Name = "cbBreed";
			cbBreed.Size = new Size(173, 28);
			cbBreed.TabIndex = 4;
			// 
			// lblSpc
			// 
			lblSpc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSpc.Location = new Point(329, 79);
			lblSpc.Margin = new Padding(30, 8, 10, 4);
			lblSpc.Name = "lblSpc";
			lblSpc.Size = new Size(55, 23);
			lblSpc.TabIndex = 10;
			lblSpc.Text = "Loài";
			lblSpc.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSpcValue
			// 
			lblSpcValue.Location = new Point(397, 82);
			lblSpcValue.Margin = new Padding(3, 11, 3, 4);
			lblSpcValue.Name = "lblSpcValue";
			lblSpcValue.Size = new Size(147, 20);
			lblSpcValue.TabIndex = 11;
			lblSpcValue.Text = "Auto detect";
			lblSpcValue.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblPrice
			// 
			lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPrice.Location = new Point(3, 115);
			lblPrice.Margin = new Padding(3, 8, 3, 4);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(114, 23);
			lblPrice.TabIndex = 14;
			lblPrice.Text = "Giá bán";
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(123, 111);
			txtPrice.Margin = new Padding(3, 4, 3, 4);
			txtPrice.Name = "txtPrice";
			txtPrice.PlaceholderText = "Nhập giá bán (đ)";
			txtPrice.Size = new Size(141, 27);
			txtPrice.TabIndex = 5;
			// 
			// lblWeight
			// 
			lblWeight.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblWeight.Location = new Point(301, 115);
			lblWeight.Margin = new Padding(34, 8, 3, 4);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(91, 23);
			lblWeight.TabIndex = 12;
			lblWeight.Text = "Cân nặng";
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(398, 111);
			txtWeight.Margin = new Padding(3, 4, 3, 4);
			txtWeight.Name = "txtWeight";
			txtWeight.PlaceholderText = "Nhập cân nặng";
			txtWeight.Size = new Size(154, 27);
			txtWeight.TabIndex = 13;
			txtWeight.TextAlign = HorizontalAlignment.Center;
			// 
			// lblDesc
			// 
			lblDesc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDesc.Location = new Point(3, 150);
			lblDesc.Margin = new Padding(3, 8, 3, 4);
			lblDesc.Name = "lblDesc";
			lblDesc.Size = new Size(114, 23);
			lblDesc.TabIndex = 16;
			lblDesc.Text = "Mô tả";
			// 
			// txtDesc
			// 
			txtDesc.Location = new Point(123, 146);
			txtDesc.Margin = new Padding(3, 4, 3, 4);
			txtDesc.Name = "txtDesc";
			txtDesc.PlaceholderText = "Nhập mô tả";
			txtDesc.Size = new Size(429, 27);
			txtDesc.TabIndex = 6;
			// 
			// lblImg
			// 
			lblImg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblImg.Location = new Point(3, 185);
			lblImg.Margin = new Padding(3, 8, 3, 4);
			lblImg.Name = "lblImg";
			lblImg.Size = new Size(114, 23);
			lblImg.TabIndex = 18;
			lblImg.Text = "Hình ảnh";
			// 
			// txtImgUrl
			// 
			txtImgUrl.Location = new Point(123, 181);
			txtImgUrl.Margin = new Padding(3, 4, 3, 4);
			txtImgUrl.Name = "txtImgUrl";
			txtImgUrl.PlaceholderText = "Nhập đường dẫn hình ảnh";
			txtImgUrl.Size = new Size(429, 27);
			txtImgUrl.TabIndex = 7;
			// 
			// pbImage
			// 
			pbImage.Location = new Point(598, 75);
			pbImage.Margin = new Padding(3, 4, 3, 4);
			pbImage.Name = "pbImage";
			pbImage.Size = new Size(270, 220);
			pbImage.TabIndex = 2;
			pbImage.TabStop = false;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(229, 107, 111);
			btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(14, 313);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(120, 36);
			btnDelete.TabIndex = 11;
			btnDelete.Text = "Xóa";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Visible = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnSold
			// 
			btnSold.BackColor = Color.FromArgb(94, 84, 142);
			btnSold.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSold.ForeColor = Color.White;
			btnSold.Location = new Point(375, 313);
			btnSold.Name = "btnSold";
			btnSold.Size = new Size(120, 36);
			btnSold.TabIndex = 10;
			btnSold.Text = "Bán";
			btnSold.UseVisualStyleBackColor = false;
			btnSold.Visible = false;
			btnSold.Click += btnSold_Click;
			// 
			// btnPreview
			// 
			btnPreview.BackColor = Color.FromArgb(94, 84, 142);
			btnPreview.FlatStyle = FlatStyle.System;
			btnPreview.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnPreview.ForeColor = Color.White;
			btnPreview.Location = new Point(748, 313);
			btnPreview.Name = "btnPreview";
			btnPreview.Size = new Size(120, 36);
			btnPreview.TabIndex = 8;
			btnPreview.Text = "Xem ảnh";
			btnPreview.UseVisualStyleBackColor = false;
			btnPreview.Click += btnPreview_Click;
			// 
			// PetForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(883, 364);
			Controls.Add(btnPreview);
			Controls.Add(btnSold);
			Controls.Add(btnDelete);
			Controls.Add(pbImage);
			Controls.Add(flpInfo);
			Controls.Add(panelHeader);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PetForm";
			Text = "Pet";
			FormClosing += PetForm_FormClosing;
			Load += PetForm_Load;
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			flpInfo.ResumeLayout(false);
			flpInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelHeader;
		private Label lblTitle;
		private Button btnSubmit;
		private FlowLayoutPanel flpInfo;
		private Label lblPetName;
		private TextBox txtPetName;
		private Label lblId;
		private Label lblGender;
		private ComboBox cbGender;
		private Label lblBornYear;
		private TextBox txtBornYear;
		private Label lblBreed;
		private ComboBox cbBreed;
		private Label lblSpc;
		private Label lblSpcValue;
		private Label lblWeight;
		private TextBox txtWeight;
		private Label lblPrice;
		private TextBox txtPrice;
		private Label lblDesc;
		private TextBox txtDesc;
		private Label lblImg;
		private TextBox txtImgUrl;
		private PictureBox pbImage;
		private Button btnDelete;
		private Button btnSold;
		private Button btnPreview;
		private Label lblIdValue;
	}
}