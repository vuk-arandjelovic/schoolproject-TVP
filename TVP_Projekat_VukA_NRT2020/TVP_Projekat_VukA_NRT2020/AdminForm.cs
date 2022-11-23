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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.ShowDialog();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            GuestsForm guestForm = new GuestsForm();
            guestForm.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomForm = new RoomsForm();
            roomForm.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationForm = new ReservationsForm();
            reservationForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInFormProvider.provide().Show();
            Close();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogInFormProvider.provide().Show();
        }
    }
}
