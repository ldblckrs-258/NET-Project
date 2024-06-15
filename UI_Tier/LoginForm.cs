using Bus_Tier;
using Models;

namespace UI_Tier
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			AcceptButton = btnLogin;
		}

		private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private bool ValidateInput()
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			if (username.Length < 6)
			{
				MessageBox.Show("Tên đăng nhập cần dài ít nhất 6 kí tự", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (password.Length < 6)
			{
				MessageBox.Show("Mật khẩu cần dài ít nhất 6 kí tự.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private bool AuthenticateUser()
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			bool remember = cbRemember.Checked;

			BSUser bsu = new();
			DisplayUser user = bsu.Login(username, password);
			if (user != null)
			{
				Program.CurrentUser = user;
				if (remember)
				{
					BSStore.SaveUser(user.Id);
				}
				return true;
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại. Tên đăng nhập hoặc mật khẩu không đúng.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (ValidateInput())
			{
				if (AuthenticateUser())
				{
					this.Hide();
					MainForm mainForm = new();
					mainForm.Location = this.Location;
					mainForm.StartPosition = FormStartPosition.Manual;
					mainForm.FormClosed += (s, args) => this.Close();
					mainForm.Show();
				}
			}
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
