using System;
public class Madeline : IDreamTeam
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Work() {
            Console.WriteLine("Madeline will plan the shit out of your project.");
        }
        public Madeline (string firstname, string lastname, string speciality)
        {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Speciality = speciality;
        }
    }