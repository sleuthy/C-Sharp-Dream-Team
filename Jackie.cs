using System;
public class Jackie : IDreamTeam
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Work() {
            Console.WriteLine("Jackie's coding binges push the rest of the team through their darkest hours.");
        }

        public Jackie(string firstname, string lastname, string speciality)
        {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Speciality = speciality;
        }
    }