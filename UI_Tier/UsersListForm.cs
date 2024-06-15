using Models;
using Bus_Tier;

namespace UI_Tier
{
	public partial class UsersListForm : Form
	{
		List<DisplayUser> users;
		List<Role> roles;
		DisplayUser selectedUser;
		bool EditMode = false;
		bool IsOwner = Program.CurrentUser.Role == "Chủ cửa hàng";
		public UsersListForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dgvUsers.Rows.Count)
			{
				selectedUser = users.Find(u => u.Id == (int)dgvUsers.Rows[e.RowIndex].Cells[0].Value);
				SetEditMode(true);
			}
		}

		private void GetUsers(bool IsOwner)
		{
			BSUser bsu = new();
			users = bsu.GetUsers(IsOwner);
			if (users == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dgvUsers.Rows.Clear();
			foreach (DisplayUser user in users)
			{
				dgvUsers.Rows.Add(user.Id, user.Name, user.Username, user.BirthDate, user.Role);
			}
		}

		private void GetRoles()
		{
			BSRole bsRole = new();
			roles = bsRole.GetRoles();
			if (roles == null)
			{
				MessageBox.Show("Lỗi truy xuất dữ liệu. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void SetEditMode(bool isEditMode)
		{
			if (isEditMode)
			{
				txtUsername.ReadOnly = true;
				txtPwd.ReadOnly = true;

				txtFullName.Text = selectedUser.Name;
				dtpDate.Value = DateTime.Parse(selectedUser.BirthDate);
				cbRole.SelectedIndex = roles.FindIndex(r => r.Name == selectedUser.Role);
				txtId.Text = selectedUser.Id.ToString();
				txtUsername.Text = selectedUser.Username;
				txtPwd.Text = "********";

				btnSubmit.Text = "Cập nhật";
				btnRPW.Visible = true;
				btnDelete.Enabled = true;

			}
			else
			{
				txtUsername.ReadOnly = false;
				txtPwd.ReadOnly = false;

				txtFullName.Text = "";
				dtpDate.Value = DateTime.Now;
				cbRole.SelectedIndex = roles.FindIndex(r => r.Name == "Nhân viên");
				txtId.Text = "Auto generate";
				txtUsername.Text = "";
				txtPwd.Text = "";

				btnSubmit.Text = "Add";
				btnRPW.Visible = false;
				btnDelete.Enabled = false;
			}
			EditMode = isEditMode;
		}

		private void UsersListForm_Load(object sender, EventArgs e)
		{
			GetUsers(IsOwner);
			GetRoles();
			cbRole.Items.Clear();
			foreach (Role role in roles)
			{
				cbRole.Items.Add(role.Name);
			}
			if (!IsOwner)
			{
				cbRole.SelectedIndex = roles.FindIndex(r => r.Name == "Nhân viên");
				cbRole.Enabled = false;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			BSUser bsUser = new();
			if (selectedUser == null || !EditMode)
			{
				MessageBox.Show("Bạn chưa chọn người dùng nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (bsUser.DeleteUser(selectedUser.Username, selectedUser.Id))
			{
				MessageBox.Show("Xóa người dùng thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetUsers(IsOwner);
			}
			else
			{
				MessageBox.Show("Xóa người dùng thất bại. Vui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnRPW_Click(object sender, EventArgs e)
		{
			BSUser bSUser = new();
			if (selectedUser != null)
			{
				if (MessageBox.Show("Are you sure you want to reset password?", "Reset password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}

				string newPwd = bSUser.ResetPassword(selectedUser.Username);
				if (newPwd != null)
				{
					MessageBox.Show($"New password: {newPwd}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error resetting password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			BSUser bsUser = new();
			string fullName = txtFullName.Text;
			DateTime dateValue = dtpDate.Value;
			string birthDate = dateValue.ToString("yyyy-MM-dd");
			bool isSameDay = DateTime.Compare(dateValue, DateTime.Parse(selectedUser.BirthDate)) == 0;

			string role = roles[cbRole.SelectedIndex].Name;
			int role_id = roles[cbRole.SelectedIndex].Id;

			if (EditMode)
			{
				if (fullName == string.Empty)
				{
					MessageBox.Show("Full name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (fullName == selectedUser.Name && isSameDay && role == selectedUser.Role)
				{
					MessageBox.Show("No changes detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (bsUser.UpdateUserInfo(new User
					{
						Id = selectedUser.Id,
						Name = fullName,
						BirthDate = birthDate,
						RoleId = role_id

					}))
				{
					MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetUsers(IsOwner);
					SetEditMode(false);
				}
				else
				{
					MessageBox.Show("Error updating user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				string username = txtUsername.Text;
				string pwd = txtPwd.Text;
				if (fullName == string.Empty || username == string.Empty || pwd == string.Empty)
				{
					MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (bsUser.AddUser(new User
					{
						Name = fullName,
						BirthDate = birthDate,
						Username = username,
						Password = pwd,
						RoleId = role_id
					}))
				{
					MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetUsers(IsOwner);
					SetEditMode(false);
				}
				else
				{
					MessageBox.Show("Error adding user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCreateMode_Click(object sender, EventArgs e)
		{
			SetEditMode(false);
		}
	}
}
