using BookReviews;
using DBlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestPeopleManager
    {
        private static MockPersonDB mockPersonDB = new MockPersonDB();
        private readonly PeopleManager peopleManager;

        public TestPeopleManager()
        {
            peopleManager = new PeopleManager(mockPersonDB);
        }
        [TestMethod]
        public void TestGetUser()
        {
            
            int number =peopleManager.GetPeople().Count;

            Assert.AreEqual(number, 3);
        }
    }
}
