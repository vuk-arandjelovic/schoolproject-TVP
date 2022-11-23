using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    class Room
    {
        private int id; 
        private int roomNumber;
        private int beds;
        private string type;
        private int price;
        private int discount;
        private int minDays;
        private bool taken;

        public Room(int id, int roomNumber, int beds, string type, int price, int discount, int minDays, bool taken = false)
        {
            this.Id = id;
            this.RoomNumber = roomNumber;
            this.Beds = beds;
            this.Type = type;
            this.Price = price;
            this.Discount = discount;
            this.MinDays = minDays;
            this.taken = taken;
        }

        public int Id { get => id; set => id = value; }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public int Beds { get => beds; set => beds = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int MinDays { get => minDays; set => minDays = value; }
        public bool Taken { get => taken; set => taken = value; }

        public override string ToString()
        {
            return $"{Id}:{RoomNumber}:{Beds}:{Type}:{Price}:{Discount}:{MinDays}:{Taken}";
        }
    }
}
