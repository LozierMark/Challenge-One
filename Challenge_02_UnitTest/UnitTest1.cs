using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_02_UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void ClaimsRepository_AddClaimToQueue_ShouldReturnCorrectCount()
        {
            //Arrange
            ClaimItem claim = new Claimitem();
            Claimitem claimTwo = new Claimitem();
            ClaimRepository repo = new ClaimRepository();

            //Act
            repo.AddClaimToQueue(claim);
            repo.AddClaimToQueue(claimTwo);

            int actual = repo.GetClaimitem().Count;
            int expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimsRepository_RemoveClaimFromQueue_ShouldReturnCorrectCount()
        {
            //Arrange
            Claimitem claim = new Claimitem();
            Claimitem claimTwo = new Claimitem();
            Claimitem claimThree = new Claimitem();
            ClaimRepository repo = new ClaimRepository();

            //Act
            repo.AddClaimToQueue(claim);
            repo.AddClaimToQueue(claimTwo);
            repo.AddClaimToQueue(claimThree);
            repo.RemoveClaimFromQueue();

            int actual = repo.GetClaimitem().Count;
            int expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}