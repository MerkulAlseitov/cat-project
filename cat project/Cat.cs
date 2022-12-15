using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat_project
{
    public class Cat
    {
        public int CurrentHunger { get; set; }
        public int NormalHunger { get; set; }
        public string Name { get; set; }
        public Cat(string name, int currenthunger, int normalhunger)
        {
            Name = name;
            CurrentHunger = currenthunger;
            NormalHunger = normalhunger;
        }
        public void Hunger()
        {
            if (CurrentHunger < NormalHunger)
            {
                Console.WriteLine(Name + " is hungry(");
            }
            if (CurrentHunger == NormalHunger)
            {
                Console.WriteLine(Name + " is ok)");
            }
            if (CurrentHunger > NormalHunger)
            {
                Console.WriteLine(Name + " is fat AF");
            }
        }
    }


}
