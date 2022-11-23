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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            foreach(Room r in ModelLister.Rooms)
            {
                if(r.RoomNumber == numRoomNumber.Value)
                {
                    MessageBox.Show("Ova soba vec postoji.");
                    return;
                }
            }
            int id = 0;
            if(ModelLister.Rooms.Count > 0)
            {
                id = ModelLister.Rooms.ElementAt(ModelLister.Rooms.Count - 1).Id + 1;
            }



            Room newRoom = new Room(id, Int32.Parse(numRoomNumber.Value.ToString()), Int32.Parse(numRoomBeds.Value.ToString()), cbRoomType.Text, Int32.Parse(numPrice.Value.ToString()), Int32.Parse(numRoomDiscount.Value.ToString()), Int32.Parse(numRoomDays.Value.ToString()));

            ModelLister.Rooms.Add(newRoom);
            ModelLister.saveRooms();

            Close();
            
        }
    }
}
