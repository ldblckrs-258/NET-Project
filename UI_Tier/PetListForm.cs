using Bus_Tier;
using Models;

namespace UI_Tier
{
	public partial class PetListForm : Form
	{
		public PetListForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private bool getPetList(string searchValue = "", int isSoldValue = 0)
		{
			BSPet bsPet = new();
			List<BasePet> listPets = bsPet.GetListPets(searchValue, isSoldValue);
			if (listPets == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			dgvPets.Rows.Clear();
			foreach (BasePet pet in listPets)
			{
				dgvPets.Rows.Add(pet.Id, pet.Name, pet.Breed, pet.BornYear, pet.Price, pet.IsSold);
			}
			return true;
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PetListForm_Load(object sender, EventArgs e)
		{
			if (Program.CurrentUser.Role == "Nhân viên")
			{
				txtTotal.Visible = false;
				lblTotal.Visible = false;
			} else 
			{
				getTotal();
			}

			cbIsSold.SelectedIndex = 0;
			if (Program.CurrentUser.Role == "Nhân viên")
			{
				btnAdd.Visible = false;
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			getPetList(txtSearch.Text, cbIsSold.SelectedIndex);
		}

		private void cbIsSold_SelectedIndexChanged(object sender, EventArgs e)
		{
			getPetList(txtSearch.Text, cbIsSold.SelectedIndex);
		}

		private void dgvPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int petId = Convert.ToInt32(dgvPets.Rows[e.RowIndex].Cells[0].Value);
			PetForm petForm = new(petId);
			petForm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			PetForm petForm = new();
			petForm.ShowDialog();
			petForm.FormClosing += (s, ev) => getPetList();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			getPetList();
			txtSearch.Text = "";
			cbIsSold.SelectedIndex = 0;
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				getPetList(txtSearch.Text, cbIsSold.SelectedIndex);
			}
		}

		private void getTotal()
		{
			BSPet bsPet = new();
			int total = bsPet.TotalPriceSold();
			string formattedTotal = total.ToString("N0");
			txtTotal.Text = $"{formattedTotal} đ";
		}
	}
}
