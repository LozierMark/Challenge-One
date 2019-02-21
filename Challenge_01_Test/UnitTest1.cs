using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_01_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MenuRepository_AddMenuItem_ShouldReturnCorrectCount()
        {
            //Arrange
            Menu menuItem = new Menu();
            MenuItem itemTwo = new MenuItems();
            MenuRepository  = new MenuRepository();

            //Act
            _menuRepo.AddItemToMenu(menuItem);
            repo.AddMenuItem(itemTwo);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
