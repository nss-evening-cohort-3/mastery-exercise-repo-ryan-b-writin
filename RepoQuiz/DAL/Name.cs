using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class Name {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }

        public Name(string FirstName, string LastName, string Major)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Major = Major;
        }
}
}