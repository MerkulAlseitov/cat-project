using cat_project;
using System.Xml.Linq;

//Задание 1
//Random rnd = new Random();
//int hunger = rnd.Next(0, 100);
//Random rnd1 = new Random();
//int OKhunger = rnd1.Next(0, 100);
//Cat Tom = new Cat("Tom", hunger, OKhunger);
//Food Milk = new Food("Milk", 20);
//Food Fish = new Food("Fish", 40);
//Food Jerry = new Food("Jerry", 80);
//Food JSLesson = new Food("JS Lesson", -20);
//Food NoFood = new Food("Weed", 1);
//Console.WriteLine("Tom's current hunger is " + Tom.CurrentHunger);
//int[] meallist = new int[5] { Milk.Calories, Fish.Calories, Jerry.Calories, JSLesson.Calories, NoFood.Calories };
//string[] mealnamelist = new string[] { Milk.Meal, Fish.Meal, Jerry.Meal, JSLesson.Meal, NoFood.Meal };
//for (int i = 0; i < mealnamelist.Length; i++)
//{
//    int b = i + 1;

//    Console.WriteLine(b + " " + mealnamelist[i] + " = " + meallist[i]);
//}
//for (; true;)
//{
//    int a;
//    while (int.TryParse(Console.ReadLine(), out a))
//    {
//        while (1 <= a && a <= 5)
//        {
//            Tom.CurrentHunger = Tom.CurrentHunger + meallist[a-1];
//            Console.WriteLine("Tom's current hunger level is " + Tom.CurrentHunger);
//            break;
//        }
//        break;
//    }
//}

//Задание 2
//Random rnd = new Random();
//int hunger = rnd.Next(0, 100);
//Random rnd1 = new Random();
//int OKhunger = rnd1.Next(0, 100);
//Cat Tom = new Cat("Tom", hunger, OKhunger);
//Food Milk = new Food("Milk", 20);
//Food Fish = new Food("Fish", 40);
//Food Jerry = new Food("Jerry", 80);
//Food JSLesson = new Food("JS Lesson", -20);
//Food NoFood = new Food("Weed", 1);
//Console.WriteLine("Tom's current hunger is " + Tom.CurrentHunger);
//Console.WriteLine("To make Tom happy, you need to get to " + Tom.NormalHunger);
//int[] meallist = new int[5] { Milk.Calories, Fish.Calories, Jerry.Calories, JSLesson.Calories, NoFood.Calories };
//string[] mealnamelist = new string[] { Milk.Meal, Fish.Meal, Jerry.Meal, JSLesson.Meal, NoFood.Meal };
//for (int i = 0; i < mealnamelist.Length; i++)
//{
//    int b = i + 1;

//    Console.WriteLine(b + " " + mealnamelist[i] + " = " + meallist[i]);
//}
//for (; Tom.CurrentHunger <= Tom.NormalHunger;)
//{
//    int a;
//    while (int.TryParse(Console.ReadLine(), out a))
//    {
//        while (1 <= a && a <= 5)
//        {
//            Tom.CurrentHunger = Tom.CurrentHunger + meallist[a - 1];
//            Console.WriteLine("Tom's current hunger level is " + Tom.CurrentHunger);
//            break;
//        }
//        Tom.Hunger();
//        if (Tom.CurrentHunger>=Tom.NormalHunger)
//        {
//            break;
//        }
//    }
//    if (Tom.CurrentHunger >= Tom.NormalHunger)
//    {
//        break;
//    }
//}




//Задание 3
//Random rnd = new Random();
//int hunger = rnd.Next(0, 100);
//Random rnd1 = new Random();
//int OKhunger = rnd1.Next(0, 100);
//Cat Tom = new Cat("Tom", hunger, OKhunger);
//Food Milk = new Food("Milk", 20);
//Food Fish = new Food("Fish", 40);
//Food Jerry = new Food("Jerry", 80);
//Food JSLesson = new Food("JS Lesson", -20);
//Food NoFood = new Food("Weed", 1);
//Console.WriteLine("Tom's current hunger is " + Tom.CurrentHunger);
//Console.WriteLine("To make Tom happy, you need to get to " + Tom.NormalHunger);
//int[] meallist = new int[5] { Milk.Calories, Fish.Calories, Jerry.Calories, JSLesson.Calories, NoFood.Calories };
//string[] mealnamelist = new string[] { Milk.Meal, Fish.Meal, Jerry.Meal, JSLesson.Meal, NoFood.Meal };
//for (int i = 0; i < mealnamelist.Length; i++)
//{
//    int b = i + 1;

//    Console.WriteLine(b + " " + mealnamelist[i] + " = " + meallist[i]);
//}
//for (; Tom.CurrentHunger<=Tom.NormalHunger ;)
//{
//    Random random = new Random();
//    int feeding = random.Next(0, 4);
//    Tom.CurrentHunger = Tom.CurrentHunger + meallist[feeding];
//    Console.WriteLine("Tom's current hunger level is " + Tom.CurrentHunger);
//    if (Tom.CurrentHunger >= Tom.NormalHunger)
//    {
//        break;
//    }

//}
//Tom.Hunger();
