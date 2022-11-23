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
    public partial class EditGuestForm : Form
    {
        private int guestId;
        private Guest editGuest;
        public EditGuestForm()
        {
            InitializeComponent();
            guestId = GuestsForm.editGuestId;
            editGuest = ModelLister.Guests.Find(_guest => _guest.Id == guestId);
            if (editGuest == null)
            {
                MessageBox.Show("Gost nije pronadjen!");
                Close();
            }
            txtGuestFirstname.Text = editGuest.FirstName;
            txtGuestLastname.Text = editGuest.LastName;
            txtGuestPhone.Text = editGuest.PhoneNumber;
            dateOfBirth.Value = editGuest.Birthday;
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestLastname.Text != "" || txtGuestFirstname.Text != "" || txtGuestPhone.Text != "")
            {
                
                editGuest.FirstName = txtGuestFirstname.Text;
                editGuest.LastName = txtGuestLastname.Text;
                editGuest.Birthday = Convert.ToDateTime(dateOfBirth.Text);
                editGuest.PhoneNumber = txtGuestPhone.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
        }
    }
}
