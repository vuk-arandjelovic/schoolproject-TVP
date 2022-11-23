using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{

    class Reservation
    {   
        private int id;
        private Guest guest;
        private Room room;
        private DateTime dateFrom;
        private DateTime dateTo;
        private decimal price;
        private string pension;

        public Reservation(int id, Guest guest, Room room, DateTime dateFrom, DateTime dateTo, decimal price, string pension)
        {
            this.Id = id;
            this.Guest = guest;
            this.Room = room;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Price = price;
            this.Pension = pension;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        public DateTime DateTo { get => dateTo; set => dateTo = value; }
        public decimal Price { get => price; set => price = value; }
        public string Pension { get => pension; set => pension = value; }
        internal Guest Guest { get => guest; set => guest = value; }
        internal Room Room { get => room; set => room = value; }

        public override string ToString()
        {
            return $"{id}:{guest.Id}:{room.Id}:{dateFrom.ToShortDateString()}:{dateTo.ToShortDateString()}:{price}:{pension}";
        }
        
    }
}
