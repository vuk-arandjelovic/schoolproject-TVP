using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    class Guest
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private string phoneNumber;

        public Guest(int id, string firstName, string lastName, DateTime birthday, string phoneNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.PhoneNumber = phoneNumber;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override string ToString()
        {
            return $"{id}:{firstName}:{lastName}:{birthday.ToShortDateString()}:{phoneNumber}";
        }
    }
}
