using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    public class Manager
    {
        /*List<Recipe> recipes = new List<Recipe>();
        Recipe recipe = new Recipe();
        public Manager() { }

        public void EnterRecipe()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Enter recipe name (or type 'exit' to quit):");
                string option = Console.ReadLine();
                Console.WriteLine();
                if (option.ToLower() == "exit")
                {
                    break;
                }

                Recipe recipe = new Recipe(option);

                while (true)
                {
                    Console.WriteLine("Enter ingredient name (or type 'done' when finished):");
                    string ingredientName = Console.ReadLine();

                    if (ingredientName.ToLower() == "done")
                    {
                        break;
                    }
                    Console.Write($"Enter the quantity >> ");
                    double quantity = double.Parse(Console.ReadLine() );

                    Console.Write("Enter the unit of Measurement >> ");
                    string unitOfMeasurement = Console.ReadLine();

                    Console.Write("Enter number of calories >> ");
                    int calories = int.Parse(Console.ReadLine());

                    Console.Write("Enter food group >> ");
                    string foodGroup = Console.ReadLine();

                    Ingredient ingredient = new Ingredient(ingredientName, quantity, unitOfMeasurement, calories, foodGroup);
                    recipe.Ingredients.Add(ingredient);
                    Console.WriteLine();

                    recipe.Steps = new List<string>();
                    Console.WriteLine("Enter number of steps");
                    int numOfSteps = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numOfSteps; i++)
                    {
                        Console.WriteLine($"Enter step {i + 1} >> ");
                        string step = Console.ReadLine();

                        recipe.Steps.Add(step);
                    }

                    Console.WriteLine("Ingredient added successfully!");
                    Console.WriteLine();
                }

                recipes.Add(recipe);
                Console.WriteLine();
                Console.WriteLine("Recipe added successfully!");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void ListRecipe()
        {
            recipes = recipes.OrderBy(x => x.Name).ToList();
            Console.WriteLine();
            Console.WriteLine("List of recipes >> ");

            foreach (var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }
        public void DisplayRecipe()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Enter recipe name you want to view the ingredient of (or type 'exit' to quit)");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                Recipe recipe = recipes.FirstOrDefault(x => x.Name.ToLower() == input.ToLower());

                if (recipe == null)
                {
                    Console.WriteLine("Recipe not found. Try again.");
                }
                else
                {
                    recipe.Print();
                }
            }
        }

        public void ScaleRecipe(double factor)
        {

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                ingredient.Quantity = (int)Math.Round(ingredient.Quantity * factor);
            }

            recipe.TotalCalories = recipe.Ingredients.Sum(i => i.Calories * (int)Math.Round(factor));

            Console.WriteLine($"Recipe scaled by {factor}.");
        }*/
    }
}
