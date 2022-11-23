using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private int role; // 100  - Administrator, 10 - Recepcioner

        public User(int id, string username, string password, string firstname, string lastname, int role)
        {
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.userName = username;
            this.password = password;
            this.role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstName; set => firstName = value; }
        public string Lastname { get => lastName; set => lastName = value; }
        public string Username { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"{id}:{userName}:{password}:{firstName}:{lastName}:{role}";
        }
    }
}
