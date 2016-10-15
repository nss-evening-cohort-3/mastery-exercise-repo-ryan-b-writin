using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using Moq;
using RepoQuiz.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    { 
        Mock<StudentContext> mock_context { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        List<Student> studentList { get; set; }
        StudentRepository repo { get; set; }

        public void ConnectMocksToDatastore()
        {
            var queryable_list = studentList.AsQueryable();

            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);

            mock_student_table.Setup(t => t.Add(It.IsAny<Student>())).Callback((Student a) => studentList.Add(a));
            mock_student_table.Setup(t => t.Remove(It.IsAny<Student>())).Callback((Student a) => studentList.Remove(a));
            mock_student_table.Setup(t => t.RemoveRange(It.IsAny<IEnumerable<Student>>())).Callback((IEnumerable<Student> a) => studentList.RemoveRange(0, a.Count<Student>()));
        }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            studentList = new List<Student>();
            repo = new StudentRepository(mock_context.Object);
            ConnectMocksToDatastore();
        }
        [TestCleanup]
        public void Teardown()
        {
            repo = null;
        }
        [TestMethod]
        public void RepoCanCreateInstance()
        {
            Assert.IsNotNull(repo);
        }
        [TestMethod]
        public void RepoCanGetAllStudents()
        {
            studentList.Add(new Student { FirstName = "x", LastName = "y", Major = "z" });
            studentList.Add(new Student { FirstName = "q", LastName = "r", Major = "s" });
            studentList.Add(new Student { FirstName = "t", LastName = "u", Major = "v" });
            studentList.Add(new Student { FirstName = "a", LastName = "b", Major = "c" });
            studentList.Add(new Student { FirstName = "d", LastName = "e", Major = "f" });
            studentList.Add(new Student { FirstName = "g", LastName = "h", Major = "i" });
            studentList.Add(new Student { FirstName = "j", LastName = "k", Major = "l" });
            studentList.Add(new Student { FirstName = "m", LastName = "n", Major = "o" });
            studentList.Add(new Student { FirstName = "w", LastName = "u", Major = "t" });
            studentList.Add(new Student { FirstName = "y", LastName = "o", Major = "o" });

            var expected_student_list = studentList;

            List<Student> actual_student_list = repo.GetStudents();

            CollectionAssert.AreEqual(expected_student_list, actual_student_list);

        }
    }
}
