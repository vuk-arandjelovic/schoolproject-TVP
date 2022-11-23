using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat_VukA_NRT2020
{
    public partial class EditUserForm : Form
    {
        private int userId;
        private User editUser;
        public EditUserForm()
        {
            InitializeComponent();
            userId = UsersForm.editUserId;
            editUser = ModelLister.Users.Find(_user => _user.Id == userId);
            if(editUser == null)
            {
                MessageBox.Show("Korisnik nije pronadjen!");
                Close();
            }
            txtUserFirstname.Text = editUser.Firstname;
            txtUserLastname.Text = editUser.Lastname;
            txtUserPassword.Text = Utils.Decrypt(editUser.Password, Utils.keyEncrypt);
            txtUserUsername.Text = editUser.Username;
            cbUserRole.Text = editUser.Role == 10 ? "Admin" : "Recepcioner";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(txtUserUsername.Text != "" || txtUserPassword.Text != "" || txtUserLastname.Text != "" || txtUserFirstname.Text != "" || cbUserRole.Text != "")
            {
                editUser.Firstname = txtUserFirstname.Text;
                editUser.Lastname = txtUserLastname.Text;
                editUser.Password = Utils.Encrypt(txtUserPassword.Text, Utils.keyEncrypt);
                editUser.Username = txtUserUsername.Text;
                editUser.Role = cbUserRole.Text == "Admin" ? 10 : 100;
                Close();
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
        }
    }
}
