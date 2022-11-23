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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtUserFirstname.Text != "" || txtUserLastname.Text != "" || txtUserPassword.Text != "" || txtUserUsername.Text != "")
            {
                int id = ModelLister.Users.ElementAt(ModelLister.Users.Count - 1).Id + 1;
                int role = cbUserRole.Text == "Admin" ? 10 : 100;
                User newUser = new User(id, txtUserUsername.Text, Utils.Encrypt(txtUserPassword.Text, Utils.keyEncrypt), txtUserFirstname.Text, txtUserLastname.Text, role);

                ModelLister.Users.Add(newUser);
                ModelLister.saveUsers();

                Close();
            }
        }
    }
}
