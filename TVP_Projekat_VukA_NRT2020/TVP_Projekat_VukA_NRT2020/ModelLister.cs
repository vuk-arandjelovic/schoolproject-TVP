using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    public class ModelLister
    {
        private static List<User> users = new List<User>();
        private static List<Room> rooms = new List<Room>();
        private static List<Guest> guests = new List<Guest>();
        private static List<Reservation> reservations = new List<Reservation>();
        private static User authUser;
        private static bool flag = false;

        public static void populateLister()
        {
            if (!flag) { 
                populateUsers();
                populateRooms();
                populateGuests();
                populateReservations();
                flag = true;
            }

        }

        private static void populateUsers()
        {
            FileStream fileStream = File.Open("users.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string row;
            while ((row = streamReader.ReadLine()) != null)
            {
                String[] data = row.Split(':');

                Users.Add(new User(Int32.Parse(data[0]), data[1], data[2], data[3], data[4], Int32.Parse(data[5])));
            }
            streamReader.Close();
            fileStream.Close();
        }


        private static void populateRooms()
        {
            FileStream fileStream = File.Open("rooms.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string row;
            while ((row = streamReader.ReadLine()) != null)
            {
                String[] data = row.Split(':');

                Rooms.Add(new Room(Int32.Parse(data[0]), Int32.Parse(data[1]), Int32.Parse(data[2]), data[3], Int32.Parse(data[4]), Int32.Parse(data[5]), Int32.Parse(data[6]), Boolean.Parse(data[7])));
            }
            streamReader.Close();
            fileStream.Close();
        }

        private static void populateGuests()
        {
            FileStream fileStream = File.Open("guests.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string row;
            while ((row = streamReader.ReadLine()) != null)
            {
                String[] data = row.Split(':');

                Guests.Add(new Guest(Int32.Parse(data[0]), data[1], data[2], DateTime.Parse(data[3]), data[4]));
            }
            streamReader.Close();
            fileStream.Close();
        }

        private static void populateReservations()
        {
            FileStream fileStream = File.Open("reservations.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string row;
            while ((row = streamReader.ReadLine()) != null)
            {
                String[] data = row.Split(':');

                Guest g = Guests.Find(guest => guest.Id == Int32.Parse(data[1]));
                Room r = Rooms.Find(room => room.Id == Int32.Parse(data[2]));

                Reservations.Add(new Reservation(Int32.Parse(data[0]), g, r, DateTime.Parse(data[3]), DateTime.Parse(data[4]), Decimal.Parse(data[5]), data[6]));
            }
            streamReader.Close();
            fileStream.Close();
        }

        internal static void saveAll()
        {
            saveUsers();
            saveRooms();
            saveGuests();
            saveReservations();
        }

        internal static void saveUsers()
        {
            try { 
                FileStream fileStream = File.Open("users.txt", FileMode.Open);
                fileStream.SetLength(0);
                StreamWriter streamWriter = new StreamWriter(fileStream);


                foreach(User u in Users)
                {
                    streamWriter.WriteLine(u.ToString());
                }

                streamWriter.Close();
                fileStream.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        internal static void saveRooms()
        {
            try { 
                FileStream fileStream = File.Open("rooms.txt", FileMode.Open);
                fileStream.SetLength(0);
                StreamWriter streamWriter = new StreamWriter(fileStream);


                foreach (Room r in Rooms)
                {
                    streamWriter.WriteLine(r.ToString());
                }

                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal static void saveGuests()
        {
            try
            {
                FileStream fileStream = File.Open("guests.txt", FileMode.Open);
                fileStream.SetLength(0);
                StreamWriter streamWriter = new StreamWriter(fileStream);


                foreach (Guest g in Guests)
                {
                    streamWriter.WriteLine(g.ToString());
                }

                streamWriter.Close();
                fileStream.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
}

        internal static void saveReservations()
        {
            try
            {
                FileStream fileStream = File.Open("reservations.txt", FileMode.Open);
                fileStream.SetLength(0);
                StreamWriter streamWriter = new StreamWriter(fileStream);


                foreach (Reservation r in Reservations)
                {
                    streamWriter.WriteLine(r.ToString());
                }

                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal static List<User> Users { get => users; set => users = value; }
        internal static List<Room> Rooms { get => rooms; set => rooms = value; }
        internal static List<Guest> Guests { get => guests; set => guests = value; }
        internal static List<Reservation> Reservations { get => reservations; set => reservations = value; }
        internal static User AuthUser { get => authUser; set => authUser = value; }
    }
}