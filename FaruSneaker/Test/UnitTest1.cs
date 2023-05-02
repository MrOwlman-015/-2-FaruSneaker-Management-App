using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace Test
{
    [TestClass()]
    public class Account_DataTests
    {
        Account_Data accountData = new Account_Data();

        [TestMethod()]
        public void CheckTest_ReturnTrue()
        {
            bool result = accountData.check("admin", "", 1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CheckTest_ReturnFalse()
        {
            bool result = accountData.check("admin", "password", 1);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LoadTest()
        {
            DataTable table = accountData.load();
            Assert.IsNotNull(table);
            Assert.AreEqual(3, table.Rows.Count);
        }

        [TestMethod()]
        public void AddTest_ReturnTrue()
        {
            bool result = accountData.add("user4", "password4", 2);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AddTest_ReturnFalse()
        {
            bool result = accountData.add("user1", "password1", 1);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void UpdateTest_ReturnTrue()
        {
            bool result = accountData.update("admin", "password", 2);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void UpdateTest_ReturnFalse()
        {
            bool result = accountData.update("user5", "password", 2);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void DeleteTest_ReturnTrue()
        {
            bool result = accountData.delete("user4");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DeleteTest_ReturnFalse()
        {
            bool result = accountData.delete("user5");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void SearchByNameTest()
        {
            DataTable table = accountData.searchByName("user");
            Assert.IsNotNull(table);
            Assert.AreEqual(3, table.Rows.Count);
        }
    }
}
