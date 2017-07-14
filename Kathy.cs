using System;
public class Kathy : IDreamTeam
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Work() {
            Console.WriteLine("Kathy will stalk your dog on Instagram.");
        }
        public Kathy (string firstname, string lastname, string speciality)
        {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Speciality = speciality;
        }
    }
