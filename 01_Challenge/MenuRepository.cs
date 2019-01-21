using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge

{
    public class MenuRepository
    {
        List<Menu> _menus = new List<Menu>();

        public void AddItemToMenu(Menu menu)
        {
            _menus.Add(menu);
        }

        public List<Menu> GetOrderedMenus()
        {
            return _menus;
        }

        public void RemoveOrderedMenu(Menu menu)
        {
            _menus.Remove(menu);
        }

        public bool RemoveMenu(string mealNumber)
        {
            bool successful = false;
            foreach (Menu menu in _menus)
            {
                
                if (menu.MealNumber== mealNumber)
                {
                    RemoveOrderedMenu(menu);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
    }
}