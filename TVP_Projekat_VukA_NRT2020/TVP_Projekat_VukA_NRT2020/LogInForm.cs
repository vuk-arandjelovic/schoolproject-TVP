using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat_VukA_NRT2020
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            User user = ModelLister.Users.Find(_user => _user.Username == username && Utils.Decrypt(_user.Password, Utils.keyEncrypt) == password);

            if (user != null)
            {
                if (user.Role == 10)
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                }
                else if (user.Role == 100)
                {
                    ReservationsForm reception = new ReservationsForm();
                    reception.Show();
                }
                txtPassword.Clear();
                txtUsername.Clear();
                ModelLister.AuthUser = user;
                Hide();
            }
            else
            {
                MessageBox.Show("Korisnik nije pronadjen");
            }
        }
    }
}
