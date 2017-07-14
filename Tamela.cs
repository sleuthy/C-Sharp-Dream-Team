using System;
public class Tamela : IDreamTeam
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Work() {
            Console.WriteLine("Tamela will definitely have a drink with you after a hard day.");
        }
        public Tamela (string firstname, string lastname, string speciality)
        {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Speciality = speciality;
        }
    }