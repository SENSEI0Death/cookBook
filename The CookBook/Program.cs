using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_CookBook
{
    class Program
    {
        public static string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ZAKARIA\source\repos\The CookBook\recipes.txt");
        public static void addRecipe()
        {
            Console.Clear();
            Console.WriteLine("--------Add New Recipe--------");
            Console.Write("enter your recipe name:");
            string recipe = Console.ReadLine();
            Console.Write("enter the category of the recipe:");
            string cat = Console.ReadLine();
            Console.WriteLine("The Ingredinets(joinning by commas ',') :");//salt,pepper,duck,tomatos,potatos....
            string InputIngreds = Console.ReadLine();
            string[] Ingreds = InputIngreds.Split(new char[] { ',' });

            Console.Write("The description:");
            string descript = Console.ReadLine();

        }
        public static void AllRecipes()
        {
            Console.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string recipename = line.Split('@')[0];
                Console.WriteLine(recipename);
            }
        }
        public static void SearchRecipe()
        {
            Console.Clear();
            Console.Write("recipe you looking for:");
            string SearchR = Console.ReadLine();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string recipename = line.Split('@')[0];
                string category = line.Split('@')[1].Split('$')[0];
                string ingreds = line.Split('@')[1].Split('$')[1].Split('#')[0];
                string description = line.Split('@')[1].Split('$')[1].Split('#')[1];
                if (SearchR == recipename)
                {
                    Console.WriteLine($"{recipename} , {category} , {ingreds} , {description}");
                }
                else
                {
                    Console.WriteLine("We Dont Have any recipe match!");
                    break;
                }
            }
        }
        public static void SearchCategory()
        {
            Console.Clear();
            Console.Write("Category you looking for:");
            string SearchC = Console.ReadLine();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string recipename = line.Split('@')[0];
                string category = line.Split('@')[1].Split('$')[0];
                string ingreds = line.Split('@')[1].Split('$')[1].Split('#')[0];
                string description = line.Split('@')[1].Split('$')[1].Split('#')[1];
                if (SearchC == category)
                {
                    Console.WriteLine($"{recipename} , {category} , {ingreds} , {description}");
                }
                else
                {
                    Console.WriteLine("We Dont Have any category match!");
                    break;
                }
            }
        }
        public static void SearchIngreds()
        {
            Console.Clear();
            Console.Write("Ingredients you looking for(must be connected with comma ','):");
            string SearchI = Console.ReadLine();
            string[] arrayIngreds = SearchI.Split(new char[] {','});//cheese.10kg,lettuce.5kg,oil.10L,minced garlic.6L,french baguette.5kg,cloves.2kg
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string recipename = line.Split('@')[0];
                string category = line.Split('@')[1].Split('$')[0];
                string description = line.Split('@')[1].Split('$')[1].Split('#')[1];
                string ingreds = line.Split('@')[1].Split('$')[1].Split('#')[0];
                string[] ingredarray = ingreds.Split(new char[] { ',' });
                string[] Name = new string[ingredarray.Length];
                string[] Quantity = new string[ingredarray.Length];
                for (int j = 0; j < ingredarray.Length; j++)
                {
                    Name[j] = ingredarray[j].Split('.')[0];
                    Quantity[j] = ingredarray[j].Split('.')[1];
                }
                for (int k = 0; k < Name.Length; k++)
                {
                    for (int x = 0; x < arrayIngreds.Length; x++)
                    {
                        if (arrayIngreds[x]==Name[k])
                        {
                            Console.WriteLine($"{recipename}");
                        }
                    }
                }
            }
        }
        public static void menu()
        {
            int ch;
            Console.WriteLine("\t   ============");
            Console.WriteLine("\t   =|CookBook|=");
            Console.WriteLine("\t   ============");
            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine("(1) Add new recipe");
            Console.WriteLine("(2) Show All the recipes");
            Console.WriteLine("(3) Search Recipe");
            Console.WriteLine("(4) Search Category");
            Console.WriteLine("(5) Search Ingredients");
            Console.WriteLine("(6) Exit!");
            Console.WriteLine("----------------------------------");
            Console.Write(" enter your choice: ");
            ch=int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("ok");
                    addRecipe();              
                    break;
                case 2:
                    Console.WriteLine("ok2");
                    AllRecipes();
                    break;
                case 3:
                    Console.WriteLine("ok3");
                    SearchRecipe();
                    break;
                case 4:
                    Console.WriteLine("ok4");
                    SearchCategory();
                    break;
                case 5:
                    Console.WriteLine("ok5");
                    SearchIngreds();
                    break;
                case 6:
                    Console.WriteLine("Exit!");
                    break;
                default: 
                    Console.WriteLine("something wrong!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
