using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        public List<Name> names { get; set; }

        public NameGenerator(int v)
        {
            names = new List<Name>();
            this.GenerateNames(v);

        }

        private List<string> FirstNames = new List<string>
        {
            "Ryan", "Paul", "Scott", "Bradley", "Abbie", "Janelle", "Sandy", "Heather", "Robert", "Kate",
            "Scooter", "Doug", "Jimmy", "Timmy", "Joe", "Zoe", "Emily", "Jessie", "Lily", "Sue"
        };

        private List<string> Majors = new List<string>
        {
           "History", "Linguistics", "Underwater Basket Weaving", "Spanish", "Latin",
           "Drama", "Pre-med", "Pre-law", "Computer Science", "Business",
           "Animal Husbandry", "Psychology", "International Espionage", "Criminal Justice", "World of Warcraft"
        };

        private List<string> LastNames = new List<string>
        {
            "Simpson", "Sanchez", "Jimothy", "James", "Bond", "Bone", "Bramblepelt", "Burnsides", "Highchurch", "Binks",
            "Kenobi", "Skywalker", "Brown", "Green", "Bernard", "Wilson", "Parker", "Stark", "Lannister", "Targaryen"
        };

        private void GenerateNames(int v)
        {
            Random rand = new Random();
            for (int i = 0; i < v; i++)
            {
                int firstNameIndex = rand.Next(1, 20);
                int lastNameIndex = rand.Next(1, 20);
                int majorIndex = rand.Next(1, 15);

                string newFirstName = FirstNames[firstNameIndex];
                string newLastName = LastNames[lastNameIndex];
                string newMajor = Majors[majorIndex];

                Name newName = new Name(newFirstName, newLastName, newMajor);
                names.Add(newName);

                bool AllUnique = (this.names.Distinct().Count() == this.names.Count());

                if (!AllUnique)
                {
                    names.Remove(names.Last());
                    i--;
                }
            }
        }


        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)
    }
}