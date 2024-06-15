using Bus_Tier;
using Models;
using System.Net;

namespace UI_Tier
{
	public partial class PetForm : Form
	{
		int petId;
		DisplayPet DisplayPet;
		List<NameBreed> breeds;
		bool IsChanged = false;
		public PetForm(int petId = 0)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.petId = petId;
			GetPetData();
		}

		private static void FillPictureBox(PictureBox pbox, Bitmap bmp)
		{
			if (bmp == null) return;
			pbox.SizeMode = PictureBoxSizeMode.Normal;
			bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;

			var resized = new Bitmap(pbox.Width, pbox.Height);
			var g = Graphics.FromImage(resized);
			var dest_rect = new Rectangle(0, 0, pbox.Width, pbox.Height);
			Rectangle src_rect;

			if (source_is_wider)
			{
				float size_ratio = (float)pbox.Height / bmp.Height;
				int sample_width = (int)(pbox.Width / size_ratio);
				src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
			}
			else
			{
				float size_ratio = (float)pbox.Width / bmp.Width;
				int sample_height = (int)(pbox.Height / size_ratio);
				src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
			}

			g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
			g.Dispose();

			pbox.Image = resized;
		}

		private Bitmap ImgUrlToBitmap(string imgUrl)
		{
			try
			{
				var request = WebRequest.Create(imgUrl);
				using var response = request.GetResponse();
				using var stream = response.GetResponseStream();
				return new Bitmap(stream);
			} catch (Exception ex)
			{
				return null;
			}
		}

		private bool GetPetData()
		{
			if (petId == 0)
			{
				return false;
			}
			BSPet bsPet = new();
			DisplayPet = bsPet.GetPet(petId);
			if (DisplayPet == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu, vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void PetForm_Load(object sender, EventArgs e)
		{
			BSBreed bsBreed = new();
			breeds = bsBreed.GetBreedsName();
			foreach (NameBreed breed in breeds)
			{
				cbBreed.Items.Add(breed.Name);
			}

			cbGender.Items.Add("Đực");
			cbGender.Items.Add("Cái");

			if (DisplayPet == null) return;
			txtPetName.Text = DisplayPet.Name;
			lblIdValue.Text = DisplayPet.Id.ToString();
			txtBornYear.Text = DisplayPet.BornYear.ToString();
			lblSpcValue.Text = DisplayPet.Species;
			txtPrice.Text = DisplayPet.Price.ToString();
			txtWeight.Text = DisplayPet.Weight.ToString();
			txtDesc.Text = DisplayPet.Description;
			txtImgUrl.Text = DisplayPet.Image;
			FillPictureBox(pbImage, ImgUrlToBitmap(DisplayPet.Image));

			cbGender.SelectedIndex = DisplayPet.IsMale ? 0 : 1;
			cbBreed.SelectedIndex = breeds.FindIndex(b => b.Id == DisplayPet.BreedId);
			btnDelete.Visible = true;

			if (DisplayPet.IsSold)
			{
				txtPrice.Enabled = false;
				btnSold.Visible = false;
			} else
			{
				btnSold.Visible = true;
			}

			this.Text = $"Thú cưng: {DisplayPet.Name}";

			if (Program.CurrentUser == null || Program.CurrentUser.Role == "Nhân viên")
			{
				btnDelete.Visible = false;
				txtPrice.Enabled = false;
				txtPetName.Enabled = false;
				txtBornYear.Enabled = false;
				txtWeight.Enabled = false;
				txtDesc.Enabled = false;
				txtImgUrl.Enabled = false;
				cbGender.Enabled = false;
				cbBreed.Enabled = false;
				btnSubmit.Visible = false;
				btnPreview.Visible = false;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (petId == 0) return;
			if (MessageBox.Show("Bạn thực sự muốn xóa dữ liệu thú cưng này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BSPet bsPet = new();
				if (bsPet.DeletePet(petId))
				{
					MessageBox.Show("Xóa thú cưng thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DetectChanges()
		{
			if (DisplayPet == null)	return;
			if (txtPetName.Text != DisplayPet.Name)
			{ 
				IsChanged = true;
				return;
			}
			if (txtBornYear.Text != DisplayPet.BornYear.ToString())
			{
				IsChanged = true;
				return;
			}
			if (txtPrice.Text != DisplayPet.Price.ToString())
			{
				IsChanged = true;
				return;
			}
			if (txtWeight.Text != DisplayPet.Weight.ToString())
			{
				IsChanged = true;
				return;
			}
			if (txtDesc.Text != DisplayPet.Description)
			{
				IsChanged = true;
				return;
			}
			if (txtImgUrl.Text != DisplayPet.Image)
			{
				IsChanged = true;
				return;
			}
			if (cbGender.SelectedIndex != (DisplayPet.IsMale ? 0 : 1))
			{
				IsChanged = true;
				return;
			}
			if (cbBreed.SelectedIndex != breeds.FindIndex(b => b.Id == DisplayPet.BreedId))
			{
				IsChanged = true;
				return;
			}
			return;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (txtPetName.Text == "" || txtBornYear.Text == "" || txtPrice.Text == "" || txtWeight.Text == "" || txtDesc.Text == "" || txtImgUrl.Text == "")
			{
				MessageBox.Show("Vui lòng điền tất cả các thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(txtBornYear.Text, out int bornYear) || !int.TryParse(txtPrice.Text, out int price) || !float.TryParse(txtWeight.Text, out float weight))
			{
				MessageBox.Show("Trường nhập vào không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (bornYear < 1900 || bornYear > DateTime.Now.Year)
			{
				MessageBox.Show("Trường năm sinh không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (price < 0 || weight < 0)
			{
				MessageBox.Show("Trường giá tiền hoặc cân nặng không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cbBreed.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn một giống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cbGender.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn một giới tính", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			DetectChanges();
			BSPet bsPet = new();
			Pet newPet = new()
			{
				Id = petId,
				Name = txtPetName.Text,
				IsMale = cbGender.SelectedIndex == 0,
				BornYear = bornYear,
				BreedId = breeds[cbBreed.SelectedIndex].Id,
				Weight = weight,
				Description = txtDesc.Text,
				Image = txtImgUrl.Text,
				Price = price
			};
			if (petId == 0)
			{
				if (bsPet.AddPet(newPet))
				{
					MessageBox.Show("Thêm thú cưng mới thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Thêm vào thất bại. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (IsChanged)
			{
				if (bsPet.UpdatePet(newPet))
				{
					MessageBox.Show("Cập nhật thông tin thú cưng thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.FormClosing -= PetForm_FormClosing;
					this.Close();
				}
				else
				{
					MessageBox.Show("Cập nhật thông tin thất bại. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa thực hiện thay đổi nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DetectChanges();
			if (IsChanged)
			{
				if (MessageBox.Show("Bạn muốn đóng cửa sổ khi chưa lưu thay đổi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}

		private void btnSold_Click(object sender, EventArgs e)
		{
			if (petId == 0 || DisplayPet.IsSold == true) return;
			if (MessageBox.Show("Đặt thú cưng này là `Đã bán`? Bạn sẽ không thể hoàn tác hành động này.", "Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			BSPet bsPet = new();
			if (bsPet.SellPet(petId))
			{
				MessageBox.Show("Thành công. Trạng thái của thú cưng đã được đặt thành `Đã bán`", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Lỗi bán thú cưng. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{
			try
			{
				FillPictureBox(pbImage, ImgUrlToBitmap(txtImgUrl.Text));
			} catch (Exception ex)
			{
				MessageBox.Show("Lỗi hình ảnh. Vui lòng kiểm tra lại internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			BSBreed bsBreed = new();
			if (cbBreed.SelectedIndex == -1) return;
			int breedId = breeds[cbBreed.SelectedIndex].Id;
			lblSpcValue.Text = bsBreed.GetSpeciesName(breedId);
		}
	}
}
