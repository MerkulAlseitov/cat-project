using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat_project
{
    public class Food
    {
        public string Meal { get; set; }
        public int Calories { get; set; }

        public Food(string meal, int calories)
        {
            Meal = meal;
            Calories = calories;
        }

    }

}
