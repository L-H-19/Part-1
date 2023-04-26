using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace Part_1
{
    class Program
    {
        //Arrays declaration as global variables
        private static string[] recipeName = new string[10];
        private static string[] ingrediantName = new string[10];
        private static double[] quantity = new double[10];
        private static double[] measurment = new double[10];
        //static int[] steps = new int[10];
        private static string[] description = new string[10];

        //object for storing in array? ask sir for clarification

        static int i;


        //Program() Ob = new Program();
        static void Main(string[] args)
        {
            Begin();
        }
        static void Begin()
        {
            //this method is a welcome message and asking the user if they would like to enter a recipe
            Console.WriteLine("Welcome ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");

            Console.WriteLine("Select an option: " +
                "\n" +
                "\nEnter a new Recipe....1" +
                "\nTo exit application....0");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Capture();
            }
            /*Console.WriteLine("Select an option: " +
                "\n" +
                "\nEnter a new Recipe....1" +
                "\nDisplay....2" +
                "\nScale....3" +
                "\nReset....4" +
                "\nClear....5" +
                "\nTo exit application....0");
            int choice = Convert.ToInt32(Console.ReadLine());*/
        }

        static void Capture()
        {
            //variable declarations
            string rName;
            int iNumber;
            int stepps;

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");
            // accepting name of recipe user input and storing inside array
            Console.WriteLine("Enter Recipe name: ");
            rName = Console.ReadLine();
            recipeName[i] = rName;

            Console.WriteLine("Enter the amount of Ingrediants needed: ");
            iNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //setting a loop for the amount of ingrediants that needs to be captured
            //once captured will be stored in arrays above
            for (int s = 0; s < iNumber; s++)
            {
                Console.Write("Enter ingrediant name: ");
                ingrediantName[i] = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Enter the quantity: ");
                quantity[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("Enter unit of measurement according to the amount of tablespoon(tsp) " +
                    "\ntsp = ");
                measurment[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.Write("How many steps will this recipe consist of: ");
            stepps = Convert.ToInt32(Console.ReadLine());

            //a loop thats created so the user can insert a desription for each step
            int cnt = 0;
            for (int x = 0; x < stepps; x++)
            {
                cnt = cnt + 1;//this is to counts the steps and used to display user what step is being inserted
                Console.WriteLine("Step: " + cnt);
                description[i] = Console.ReadLine();

            }

            //once the loop is exited from the capturing the recipe 
            //user will be asked to create new recipe or display the one just created

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine("Select option: " +
                "\n" +
                "\nInsert new Recipe....1" +
                "\nDisplay current Recipe....2" +
                "\n Exit....0");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Capture();
            }
            else
            {
                Display();
            }

        }
        //Display method
        static void Display() // this method isnt working i dont know if this format makes logical sense 
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");

            Console.WriteLine("Recipe: " + recipeName[i]);
            Console.WriteLine("");
            Console.WriteLine("Ingredients: ");
            Console.WriteLine("");
            //loop to display the quantity, unit of measurment and ingrediant name
            for (int m = 0; m < quantity.Length && m < measurment.Length && m < ingrediantName.Length; m++)
            {
                Console.WriteLine(quantity[i] + " " + measurment[i] + " " + ingrediantName[i]);
            }
            //loop to display the steps and discription of each step
            int cnt = 0;
            for (int t = 0; t < description.Length; t++)
            {
                cnt = cnt + 1;
                Console.WriteLine("");
                Console.WriteLine("Step " + cnt + ":");
                Console.WriteLine(description[i]);
                Console.WriteLine("");
            }

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine("Select option: " +
                "\nClear Screen to enter new Recipe....1" +
                "\nScale current Recipe....2" +
                "\n Exit....0");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                Capture();
            }
            else if (choice == 2)
            {
                ScaleRecipe();
            }


        }

        static void ScaleRecipe()
        {
            //this section is supposed to scale the data in the measurement array and display the new recipe
            //

            Console.WriteLine("Choose what scale would you prefer between the options: " +
                "\nScale recipe down x0.5(half serving)....1" +
                "\nScale recipe up x2(double serving)....2" +
                "\nScale recipe up x3(triple serving)....3");
            int scale = Convert.ToInt32(Console.ReadLine());
            // the idea with the piece of code is supposed to access the quantity array and to change the value depending what the user enters from options
            if (scale == 1)
            {
                quantity[i] = quantity[i] * 0.5;
            }
            else if (scale == 2)
            {
                quantity[i] = quantity[i] * 2;
            }
            else if (scale == 3)
            {
                quantity[i] = quantity[i] * 3;
            }



            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine("Select option: " +
                "\nClear Screen to enter new Recipe....1" +
                "\nDisplay scaled recipe....2" +
                "\nReset current Recipe....3" +
                "\n Exit....0");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                Capture();
            }
            else if (choice == 2 || choice == 3)
            {
                Display();
            }
        }

    }
}
