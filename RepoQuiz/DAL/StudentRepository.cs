using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        public StudentContext context { get; set; }
        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }
    }
}