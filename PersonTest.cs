using Microsoft.VisualStudio.TestTools.UnitTesting;
using FamilyTree;
using FamilyTree.Models;
using FamilyTree.Controllers;

namespace FamilyTreeUnitTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestGetDataForPerson()
        {
            familytreedbContext _context;

            int id = 1;
            Person expected = new Person();
            expected.FullName = "Darth Vader";

            Person actual = new Person();
            
        }
    }
}
