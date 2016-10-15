using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepoQuiz.Models;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        public StudentContext context { get; set; }
        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }

        public StudentRepository()
        {
            context = new StudentContext();
        }

        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }
    }
}