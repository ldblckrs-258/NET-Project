using Bus_Tier;

namespace UI_Tier
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			lblName.Text = $"{Program.CurrentUser.Name} ({Program.CurrentUser.Role})";
			StartPosition = FormStartPosition.CenterScreen;
			if (Program.CurrentUser.Role == "Nhân viên")
			{
				btnUsers.Visible = false;
				layoutMain.Padding = new Padding(0, 20, 0, 0);
			}

		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown)
			{
				return;
			}
			if (MessageBox.Show("Bạn muốn đóng chương trình?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Program.CurrentUser = null;
			BSStore.DeleteUser();
			this.Hide();
			LoginForm lf = new();
			lf.Show();
		}

		private void btnOpenPets_Click(object sender, EventArgs e)
		{
			this.Hide();
			PetListForm plf = new();
			plf.FormClosed += (s, ev) => this.Show();
			plf.Show();
		}

		private void btnOpenBreed_Click(object sender, EventArgs e)
		{
			this.Hide();
			BreedListForm blf = new();
			blf.FormClosed += (s, ev) => this.Show();
			blf.Show();
		}

		private void btnOpenSpecies_Click(object sender, EventArgs e)
		{
			this.Hide();
			SpeciesListForm slf = new();
			slf.FormClosed += (s, ev) => this.Show();
			slf.Show();
		}

		private void btnMyAccount_Click(object sender, EventArgs e)
		{
			this.Hide();
			MyAccountForm maf = new();
			maf.FormClosed += (s, ev) =>
			{
				this.Show();
			};
			maf.Show();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsersListForm ulf = new();
			ulf.FormClosed += (s, ev) => this.Show();
			ulf.Show();
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			lblName.Text = $"{Program.CurrentUser.Name} ({Program.CurrentUser.Role})";
		}
	}
}
