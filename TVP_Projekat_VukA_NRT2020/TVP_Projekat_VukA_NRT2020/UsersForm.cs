using System;
using System.Collections;
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
    public partial class UsersForm : Form
    {
        public static int editUserId;
        public UsersForm()
        {
            InitializeComponent();

            lstViewUsers.View = View.Details;
            lstViewUsers.FullRowSelect = true;
            lstViewUsers.GridLines = true;
            lstViewUsers.Columns.Add("ID", 65);
            lstViewUsers.Columns.Add("Ime",100);
            lstViewUsers.Columns.Add("Prezime", 100);
            lstViewUsers.Columns.Add("Korisnicko ime", 100);
            lstViewUsers.Columns.Add("Sifra", 100);
            lstViewUsers.Columns.Add("Vrsta Korisnika", 100);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

            populateList();


        }

        private void populateList()
        {
            lstViewUsers.Items.Clear();
            foreach (User k in ModelLister.Users)
            {
                string role = k.Role == 10 ? "Admin" : "Recepcioner";
                ListViewItem redLista = new ListViewItem();
                redLista.Text = k.Id.ToString();
                redLista.SubItems.Add(k.Firstname);
                redLista.SubItems.Add(k.Lastname);
                redLista.SubItems.Add(k.Username);
                redLista.SubItems.Add(k.Password);
                redLista.SubItems.Add(role);
                lstViewUsers.Items.Add(redLista);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm dodajKorisnika = new AddUserForm();
            dodajKorisnika.ShowDialog();
            populateList();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try { 
                int id  = Int32.Parse(lstViewUsers.SelectedItems[0].SubItems[0].Text);
                User removedUser = ModelLister.Users.Find(_user => _user.Id == id);
                if(removedUser != null) { 
                    if(removedUser != ModelLister.AuthUser) { 
                        ModelLister.Users.Remove(removedUser);
                        ModelLister.saveUsers();
                        populateList();
                    }
                    else
                    {
                        MessageBox.Show("Ne mozete obrisati nalog sa kojim ste prijavljeni");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nije uspelo brisanje korisnika");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                editUserId = Int32.Parse(lstViewUsers.SelectedItems[0].SubItems[0].Text);
                User selectedUser = ModelLister.Users.Find(_user => _user.Id == editUserId);


                if (selectedUser != null)
                {
                    EditUserForm izmeniKorsnika = new EditUserForm();
                    izmeniKorsnika.ShowDialog();
                    populateList();
                }
                else
                {
                    MessageBox.Show("Izaberite korisnika");
                }
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju korsnika");
            }
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            ModelLister.saveUsers();
            Close();
        }
    }
}
