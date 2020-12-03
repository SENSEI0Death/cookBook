using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_CookBook
{
    class Ingredient
    {
        string name;
        string quantity;
        public Ingredient(string name, string quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public Ingredient(string[] ingreds)
        {
            for (int i = 0; i < ingreds.Length; i++)
            {
                name = ingreds[i].Split('.')[0];
                quantity = ingreds[i].Split('.')[1];
            }
        }
        public string Name { get { return name; } set{ name = Name; } }
        public string Quantity { get{ return quantity; } set { quantity = Quantity; } }
    }
}
