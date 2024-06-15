using Bus_Tier;
using Models;

namespace UI_Tier
{
	public partial class BreedListForm : Form
	{
		List<Breed> breeds;
		List<Species> species;
		Breed selectedBreed;
		bool EditMode = false;


		public BreedListForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}
		private void GetBreeds()
		{
			BSBreed bsBreed = new();
			breeds = bsBreed.GetBreeds();
			if (breeds == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu, vui lòng thử lại sau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dgvBreeds.Rows.Clear();
			foreach (Breed breed in breeds)
			{
				dgvBreeds.Rows.Add(breed.Id, breed.Name, species.Find(s => s.Id == breed.SpeciesId).Name, breed.Description);
			}
		}

		private void GetSpecies()
		{
			BSSpecies bSSpecies = new();
			species = bSSpecies.GetSpecies();
			if (species == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu, vui lòng thử lại sau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void BreedListForm_Load_1(object sender, EventArgs e)
		{
			GetSpecies();
			GetBreeds();

			if (Program.CurrentUser.Role == "Nhân viên")
			{
				btnDelete.Visible = false;
				btnClear.Visible = false;
				btnSubmit.Visible = false;
				txtBreedName.Visible = false;
				lblBreedName.Visible = false;
				lblSpecies.Visible = false;
				cbSpecies.Visible = false;
				lblId.Visible = false;
				lblIdValue.Visible = false;
				txtDesc.Visible = false;
				lblDesc.Visible = false;
				lblDescription.Visible = true;
				this.Size = new Size(827, 530);
			}

			cbSpecies.Items.Clear();
			foreach (Species s in species)
			{
				cbSpecies.Items.Add(s.Name);
			}
		}

		private void dgvBreeds_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dgvBreeds.Rows.Count)
			{
				if (Program.CurrentUser.Role == "Nhân viên")
				{
					lblDescription.Text = dgvBreeds.Rows[e.RowIndex].Cells[3].Value.ToString();
					return;
				}
				selectedBreed = breeds.Find(b => b.Id == (int)dgvBreeds.Rows[e.RowIndex].Cells[0].Value);
				SetEditMode(true);
			}
		}

		private void SetEditMode(bool isEdit)
		{
			if (isEdit)
			{
				lblIdValue.Text = selectedBreed.Id.ToString();
				txtBreedName.Text = selectedBreed.Name;
				txtDesc.Text = selectedBreed.Description;
				cbSpecies.SelectedIndex = species.FindIndex(s => s.Id == selectedBreed.SpeciesId);
				btnSubmit.Text = "Cập nhật";
				btnDelete.Enabled = true;
				EditMode = true;
			}
			else
			{
				lblIdValue.Text = "Auto generate";
				txtBreedName.Text = "";
				txtDesc.Text = "";
				cbSpecies.SelectedIndex = 0;
				btnDelete.Enabled = false;
				btnSubmit.Text = "Thêm";
				EditMode = false;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			SetEditMode(false);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			BSBreed bsBreed = new();
			if (MessageBox.Show("Bạn thực sự muốn xóa giống thú cưng này chứ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			if (bsBreed.DeleteBreed(selectedBreed.Id))
			{
				MessageBox.Show("Xóa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetBreeds();
				SetEditMode(false);
			}
			else
			{
				MessageBox.Show("Xóa thất bại! Có thể do đang có thú cưng được lưu trữ là giống này, vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			BSBreed bsBreed = new();
			int newId = 0;
			if (EditMode)
				newId = selectedBreed.Id;
			string name = txtBreedName.Text;
			string desc = txtDesc.Text;
			int speciesId = species[cbSpecies.SelectedIndex].Id;

			if (name == "" || desc == "")
			{
				MessageBox.Show("Hay điền tất cả các ô dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Breed newBreed = new Breed
			{
				Id = newId,
				Name = name,
				SpeciesId = speciesId,
				Description = desc
			};
			if (EditMode)
			{
				if (name == selectedBreed.Name && desc == selectedBreed.Description && speciesId == selectedBreed.SpeciesId)
				{
					MessageBox.Show("Bạn chưa thay đổi thông tin nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (bsBreed.UpdateBreed(newBreed))
				{
					MessageBox.Show("Cập nhật thông tin thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetBreeds();
				}
				else
				{
					MessageBox.Show("Cập nhật thông tin thất bại, vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if (bsBreed.AddBreed(newBreed))
				{
					MessageBox.Show("Thêm giống mới thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetBreeds();
				}
				else
				{
					MessageBox.Show("Thêm giống mới thất bại, vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			GetBreeds();
		}
	}
}
