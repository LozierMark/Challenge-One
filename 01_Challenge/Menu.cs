using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge

{
   
    public class Menu
    {
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal OrderPrice { get; set; }

        public Menu( string mealNumber,string mealName, string description, string ingredients, decimal orderPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            OrderPrice = orderPrice;
        }

        public Menu()
        {

        }
    }
}