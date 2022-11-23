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
    public partial class AddGuestForm : Form
    {
        public AddGuestForm()
        {
            InitializeComponent();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestLastname.Text != "" || txtGuestFirstname.Text != "" || txtGuestPhone.Text != "")
            {
                int id = 0;
                if (ModelLister.Guests.Count > 0)
                {
                    id = ModelLister.Guests.ElementAt(ModelLister.Guests.Count - 1).Id + 1;
                }
                Guest newGuest = new Guest(id, txtGuestFirstname.Text, txtGuestLastname.Text, Convert.ToDateTime(dateOfBirth.Text), txtGuestPhone.Text);

                ModelLister.Guests.Add(newGuest);
                ModelLister.saveGuests();

                Close();
            }
        }
    }
}
