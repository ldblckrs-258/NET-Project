using Bus_Tier;
using Models;

namespace UI_Tier
{
	public partial class SpeciesListForm : Form
	{
		bool EditMode = false;
		List<Species> species;
		Species selectedSpecies;

		public SpeciesListForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void GetSpecies()
		{
			BSSpecies bsSpecies = new();
			species = bsSpecies.GetSpecies();
			if (species == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dgvSpecies.Rows.Clear();
			foreach (Species species in species)
			{
				dgvSpecies.Rows.Add(species.Id, species.Name);
			}
		}

		private void SpeciesListForm_Load(object sender, EventArgs e)
		{
			GetSpecies();
			if (Program.CurrentUser.Role == "Nhân viên")
			{
				btnDelete.Visible = false;
				btnSubmit.Visible = false;
				btnClear.Visible = false;
				lblId.Visible = false;
				lblIdValue.Visible = false;
				lblSpcName.Visible = false;
				txtSpcName.Visible = false;
				dgvSpecies.Location = new Point(150, 87);
			}
		}

		private void SetEditMode(bool editMode)
		{
			if (editMode)
			{
				btnSubmit.Text = "Lưu";
				btnDelete.Enabled = true;
				lblIdValue.Text = selectedSpecies.Id.ToString();
				txtSpcName.Text = selectedSpecies.Name;
				EditMode = true;
			}
			else
			{
				btnSubmit.Text = "Thêm";
				btnDelete.Enabled = false;
				lblIdValue.Text = "Auto generate";
				txtSpcName.Text = "";
				EditMode = false;
			}
		}

		private void dgvSpecies_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dgvSpecies.Rows.Count)
			{
				selectedSpecies = species.Find(s => s.Id == (int)dgvSpecies.Rows[e.RowIndex].Cells[0].Value);
				SetEditMode(true);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			SetEditMode(false);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			BSSpecies bsSpecies = new();
			if (bsSpecies.DeleteSpecies(selectedSpecies.Id))
			{
				MessageBox.Show("Xóa thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetSpecies();
				SetEditMode(false);
			}
			else
			{
				MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string name = txtSpcName.Text;
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("Tên không thể để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (EditMode)
			{
				if (name == selectedSpecies.Name)
				{
					MessageBox.Show("Bạn chưa thay đổi thông tin nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				BSSpecies bsSpecies = new();
				if (bsSpecies.UpdateSpecies(new Species
				{
					Id = selectedSpecies.Id,
					Name = name
				}))
				{
					MessageBox.Show("Cập nhật thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetSpecies();
					SetEditMode(false);
				}
				else
				{
					MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại sau.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				BSSpecies bsSpecies = new();
				if (bsSpecies.AddSpecies(name))
				{
					MessageBox.Show("Thêm mới thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetSpecies();
					SetEditMode(false);
				}
				else
				{
					MessageBox.Show("Thêm vào thất bại. Vui lòng thử lại sau.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			GetSpecies();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
