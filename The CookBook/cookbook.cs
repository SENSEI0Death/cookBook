using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_CookBook
{
    class cookbook
    {
        string recipename;
        string category;
        string[] ingreds;
        string description;
        Ingredient ing;
        public string[] Ingreds
        {
            get
            {
                return ingreds;
            }
            set
            {
                ingreds = Ingreds;
            }
        }
        public string Recipename
        {
            get
            {
                return recipename;
            }
            set
            {
                recipename = Recipename;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = Category;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = Description;
            }
        }
        public Ingredient Ing
        {
            get { return ing; }
            set { ing = Ing; }
        }
        public cookbook(string recipename , string category , string[] ingreds , string description)
        {
            this.recipename = recipename;
            this.category = category;
            this.description = description;
            this.ingreds = ingreds;
            ing = new Ingredient(ingreds);
        }
    }
}

