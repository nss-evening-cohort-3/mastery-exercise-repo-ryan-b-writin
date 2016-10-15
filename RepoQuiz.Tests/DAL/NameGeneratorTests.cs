using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void NameCanCreateInstance()
        {
            NameGenerator newNames = new NameGenerator(10);
            Assert.IsNotNull(newNames);
        }
        [TestMethod]
        public void NameCanGenerateName()
        {
            NameGenerator newNames = new NameGenerator(1);
            int expected_name_count = 1;
            int actual_name_count = newNames.names.Count();
            Assert.AreEqual(expected_name_count, actual_name_count);
        }
        [TestMethod]
        public void NameMakeTenNames()
        {
            NameGenerator newNames = new NameGenerator(10);
            int expected_name_count = 10;
            int actual_name_count = newNames.names.Count();
            Assert.AreEqual(expected_name_count, actual_name_count);
        }
        [TestMethod]
        public void NameTenUniqueNames()
        {
            NameGenerator tenNames = new NameGenerator(10);
            bool AllUnique = (tenNames.names.Distinct().Count() == tenNames.names.Count());
            Assert.IsTrue(AllUnique);
        }
    }
}
