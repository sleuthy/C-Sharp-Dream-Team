using System;
public class Chaz : IDreamTeam
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Work() {
            Console.WriteLine("Chaz doesn't need a microphone.");
        }
        public Chaz (string firstname, string lastname, string speciality)
        {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Speciality = speciality;
        }
    }