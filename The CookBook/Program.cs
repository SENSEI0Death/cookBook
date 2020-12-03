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
        static public void addRecipe()
        {
            Console.Clear();
            Console.WriteLine("--------Add New Recipe--------");
            Console.WriteLine("enter your recipe name:");
            string recipe = Console.ReadLine();
            Console.WriteLine("enter the category of the recipe:");
            string cat = Console.ReadLine();
            //obj need for the ingredients 
        }
        static public void SearchRecipe()
        {
            Console.Clear();
            Console.WriteLine("enter your recipe you looking for:");
            string SearchR = Console.ReadLine();

        }
        static public void menu()
        {
            int ch;
            Console.WriteLine("\t   ============");
            Console.WriteLine("\t   =|CookBook|=");
            Console.WriteLine("\t   ============");
            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine("(1) Add new recipe");
            Console.WriteLine("(2) Show All the recipe");
            Console.WriteLine("(3) Search and edit the recipe");
            Console.WriteLine("(4) Exit from the program");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" enter your choice:");
            ch=int.Parse(Console.ReadLine());
            
            switch(ch)
            {
                case 1:
                    Console.WriteLine("ok");
                    addRecipe();              
                    break;
                case 2:
                    Console.WriteLine("ok2");
                    break;
                case 3:
                    Console.WriteLine("ok3");
                    break;
                case 4:
                    Console.WriteLine("exist");
                    break;
                default: 
                    Console.WriteLine("something wrong!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            // Read a text file line by line.
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ZAKARIA\source\repos\The CookBook\recipes.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of recipes.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            Console.ReadLine();

            //string textFile = "recipes.txt";
            /* string[] lines = File.ReadAllLines(textFile);
             if (File.Exists(textFile))
             {
                 // Read a text file line by line.  
                 lines = File.ReadAllLines(textFile);
                 foreach (string line in lines)
                     Console.WriteLine(line);
             }
             else
             {
                 Console.Write("walo makhedamch hadchi");
             }
             //menu();
            */
        }
    }
}
