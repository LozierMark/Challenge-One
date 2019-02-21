using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_03_UnitTest_03
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OutingRepository_AddOutingToList_ShouldReturnCorrectCount()
        {
            //Arrange
            OutingEvent outing = new OutingEvent();
            OutingEvent outingTwo = new OutingEvent();
            OutingRepository repo = new OutingRepository();

            //Act
            repo.AddOutingToList(outing);
            repo.AddOutingToList(outingTwo);

            int actual = repo.GetOutingList().Count;
            int expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


