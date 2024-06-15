using Bus_Tier;
using Models;

namespace UI_Tier
{
	public partial class MyAccountForm : Form
	{
		DisplayUser displayUser;
		bool ChangePassword = false;
		public MyAccountForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void GetUser()
		{
			BSUser bsUser = new();
			displayUser = bsUser.GetUser(Program.CurrentUser.Id);
			if (displayUser == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			txtFullName.Text = displayUser.Name;
			dtpDate.Value = DateTime.Parse(displayUser.BirthDate);
			txtRole.Text = displayUser.Role;
			txtUsername.Text = displayUser.Username;
		}

		private void MyAccountForm_Load(object sender, EventArgs e)
		{
			GetUser();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string name = txtFullName.Text;
			DateTime dateValue = dtpDate.Value;
			string birthDate = dateValue.ToString("yyyy-MM-dd");
			bool isSameDay = DateTime.Compare(dateValue, DateTime.Parse(displayUser.BirthDate)) == 0;

			if (name == "" || birthDate == "")
			{
				MessageBox.Show("Hãy điền tất cả thông tin cần thiết.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (name == displayUser.Name && isSameDay)
			{
				MessageBox.Show("Bạn chưa thực hiện thay đổi nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			BSUser bsUser = new();
			if (bsUser.UpdateUserInfo(new User
			{
				Id = Program.CurrentUser.Id,
				Name = name,
				BirthDate = birthDate
			}))
			{
				MessageBox.Show("Cập nhật thông tin thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetUser();
			}
			else
			{
				MessageBox.Show("Lỗi cập nhật thông tin, vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetChangingPwd(bool change)
		{
			lblPwd.Visible = change;
			txtPwd.Visible = change;
			lblNPwd.Visible = change;
			txtNPwd.Visible = change;
			btnCancel.Visible = change;
			btnCPW.Text = change ? "Lưu" : "Đổi mật khẩu";
			ChangePassword = change;
		}

		private void btnCPW_Click(object sender, EventArgs e)
		{
			if (!ChangePassword)
			{
				SetChangingPwd(true);
			}
			else
			{
				if (txtPwd.Text.Length < 6 || txtNPwd.Text.Length < 6)
				{
					MessageBox.Show("Mật khẩu cần có ít nhất 6 kí tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				BSUser bsUser = new();
				if (bsUser.ChangePassword(Program.CurrentUser.Username, txtPwd.Text, txtNPwd.Text))
				{
					MessageBox.Show("Thay đổi mật khẩu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					SetChangingPwd(false);
					txtPwd.Text = "";
					txtPwd.Text = "";
				}
				else
				{
					MessageBox.Show("Bạn đã nhập sai mật khẩu cũ. Vui lòng thử lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			SetChangingPwd(false);
			txtPwd.Text = "";
			txtNPwd.Text = "";
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			GetUser();
		}
	}
}
