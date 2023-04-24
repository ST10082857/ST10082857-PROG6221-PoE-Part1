using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPartOne
{
    public class Recipe
    {
        // Create am Array instance of the Ingredient and Steps class
        private Ingredients[] ingredient;
        private Steps[] step;

        //Constructor initializing the Arrays to 0
        public Recipe() 
        {
            ingredient = new Ingredients[0];
            step = new Steps[0];
        }
        //The AddIngredient method takes in a name,
        //quantity, and unit for the ingredient,
        //resizes the Ingredients array, and adds
        //a new Ingredients object to the last
        //index of the array.
        public void AddIngredient(string name, double quantity, string unit)
        {
            Array.Resize(ref ingredient, ingredient.Length + 1);
            ingredient[ingredient.Length - 1] = new Ingredients { name = name,
                quantity = quantity, unit = unit };
        }
        //AddSteps method takes in a description
        //for the step, resizes the Steps array,
        //and adds a new Steps object to the
        //last index of the array.
        public void AddSteps(string description)
        {
            Array.Resize(ref step, step.Length + 1);
            step[step.Length - 1] = new Steps { description = description };
        }
        // DisplayRecipe method prints out the
        // Ingredients and Steps arrays
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients: ");
            foreach(var ing in ingredient)
            {
                Console.WriteLine($"{ing.quantity} {ing.unit} of {ing.name}");
            }
            Console.WriteLine();
            Console.WriteLine("Steps: ");
            for (int i = 0; i < step.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {step[i].description}");
            }
        }
        // ScaleRecipe method takes in a
        // factor, and multiplies the
        // quantity of each ingredient in
        // the Ingredients array by that factor.
        public void ScaleRecipe(double factor)
        {
            foreach(var ing in ingredient)
            {
                ing.quantity *= factor;
            }
        }
        //ResetQuantity method divides the
        //quantity of each ingredient in
        //the Ingredients array by 2.
        public void ResetQuantity()
        {
            foreach (var ing in ingredient)
            {
                ing.quantity /= 2;
            }
        }
        //ClearRecipe method resets both the
        //Ingredients and Steps arrays to a
        //length of 0.
        public void ClearRecipe()
        {
            ingredient = new Ingredients[0];
            step = new Steps[0];
        }
    }
}
