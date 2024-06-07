using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog6221_POE
{
    public class Recipe
    {
        //creating getter and setters for local variable
        public string RecipeName { get; set; }
        public string IngredientName { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        //creating a constructor for the recipe class
        public Recipe(string recipeName, string ingredientName, double quantity, string unitOfMeasurements, double calories, string foodGroup)
        {
            RecipeName = recipeName;
            IngredientName = ingredientName;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurements;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        public override string ToString()
        {
            return $"Recipe Name: {RecipeName}\n" +
                   $"{Quantity} {UnitOfMeasurement} of {IngredientName}\n" +
                   $"Calories: {Calories}\n" +
                   $"Food Group: {FoodGroup}\n";
        }
    }
}

