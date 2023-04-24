using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPartOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Recipe class
            Recipe recipe = new Recipe();

            // Declare variables for the menu options
            int option;
            string name;
            double quantity;
            string unit;
            string description;
            double factor;

            // Welcome message
            Console.WriteLine("Welcome to the Recipe Console Application !");
            Console.WriteLine();

            // Display menu options in a loop until the user chooses to quit
            while (true) 
            {
                Console.WriteLine("Please select an option from the menu: ");
                Console.WriteLine();
                Console.WriteLine("1. Add an ingredient.");
                Console.WriteLine("2. Add a step.");
                Console.WriteLine("3. Display recipe.");
                Console.WriteLine("4. Scale recipe.");
                Console.WriteLine("5. Reset Quantity.");
                Console.WriteLine("6. Clear recipe.");
                Console.WriteLine("7. Quit.");

                // Prompt the user for their choice
                Console.Write("Enter your choice (1 - 7): ");

                // Get the user's choice and store it in the option variable
                option = int.Parse(Console.ReadLine());

                // Use a switch statement to perform the selected action
                switch (option) 
                {
                    // If the user selects option 1, prompt them for an
                    // ingredient name, quantity, and unit, and then add
                    // the ingredient to the recipe
                    case 1:
                        Console.Write("Enter an ingredient name: ");
                        name = Console.ReadLine();

                        // Use a try-catch block to handle any format
                        // that may occur when parsing the quantity
                        try
                        {
                            Console.Write("Enter the quantity: ");
                            quantity = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.Write("Quantity must be a number. Please try again: ");
                            quantity = double.Parse(Console.ReadLine());
                        }
                        Console.Write("Enter unit: ");
                        unit = Console.ReadLine();
                        recipe.AddIngredient(name, quantity, unit);
                        break;

                    // If the user selects option 2, prompt them for a
                    // step description and add it to the recipe
                    case 2:
                        Console.Write("Enter the step description: ");
                        description = Console.ReadLine();
                        recipe.AddSteps(description);
                        break;

                    // If the user selects option 3, display the recipe
                    case 3:
                        recipe.DisplayRecipe();
                        break;

                    // If the user selects option 4, prompt them for a
                    // scaling factor and scale the recipe
                    case 4:
                        // Use a try-catch block to handle any format
                        // exceptions that may occur when parsing the
                        // scaling factor
                        try
                        {
                            Console.Write("Enter the scaling factor: ");
                            factor = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.Write("Scaling factor must be a number. " +
                                "Please try again: ");
                            factor = double.Parse(Console.ReadLine());
                        }
                        recipe.ScaleRecipe(factor);
                        break;

                    // If the user selects option 5, reset the recipe
                    // quantity to 1
                    case 5:
                        recipe.ResetQuantity();
                        break;

                    // If the user selects option 6, clear the recipe
                    case 6:
                        recipe.ClearRecipe();
                        break;

                    // If the user selects option 7, exit the program
                    case 7:
                        return;

                    // If the user selects an invalid option, display
                    // an error message and prompt them again
                    default:
                        Console.WriteLine("Invalid Option, Please try again :)");
                        break;
                }
            }
        }
    }
}
