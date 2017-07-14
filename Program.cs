using System;
using System.Linq;
using System.Collections.Generic;

public interface IDreamTeam
    {
        string Speciality { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        void Work();
    }

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            Kathy kathy1 = new Kathy ("Kathy", "Weisensel", "asking about your dog"); 
            Tamela tamela1 = new Tamela ("Tamela", "Lerma", "ordering another drink");
            Eliza eliza1 = new Eliza ("Eliza", "Meeks", "wrangling");
            Jackie jackie1 = new Jackie ("Jackie", "Knight", "coding binges");
            Madeline madeline1 = new Madeline ("Madeline", "Power", "keepin it classy");
            Chaz chaz1 = new Chaz ("Chaz", "Henricks", "projecting his voice");

            List<IDreamTeam> serverSide = new List<IDreamTeam>();
            serverSide.Add((kathy1));
            serverSide.Add((eliza1));
            serverSide.Add((madeline1));

            List<IDreamTeam> clientSide = new List<IDreamTeam>();
            clientSide.Add((chaz1));
            clientSide.Add((jackie1));
            clientSide.Add((tamela1));

            Console.WriteLine("My client side Dream Team and their specialities:");
            foreach (IDreamTeam item in clientSide)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} --- {item.Speciality}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("My server side Dream Team and their specialities");
            foreach (IDreamTeam item in serverSide)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} --- {item.Speciality}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("How does each person contribute to the Dream Team?");
            foreach (IDreamTeam item in clientSide)
            {
                item.Work();
            }
             foreach (IDreamTeam item in serverSide)
            {
                item.Work();
            }
        }
    }
}