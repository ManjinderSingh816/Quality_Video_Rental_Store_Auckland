using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quality_Video_Rental_Store_Auckland;

namespace QualityVideoRentalStoreUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        DatabaseLogics databaseLogics = new DatabaseLogics();

        [TestMethod()]
        public void UnitTest()
        {

            databaseLogics.DbChanges("Insert into tdCustomers Values('Name','Contact','Address','Age','Gender','Test')");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void UnitTest2()
        {
            databaseLogics.DbChanges("delete from tdCustomers where CstId = 1");
            Assert.IsTrue(true);
        }
    }
}
