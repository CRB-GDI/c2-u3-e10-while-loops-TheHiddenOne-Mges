namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Manages Wether the menu should be active or not
            int menuChoice = 0;

            while (menuChoice != 4)
            {
                // The Menu
                Console.WriteLine("");
                Console.WriteLine("*****************");
                Console.WriteLine("Menu :");
                Console.WriteLine("1- Start New Save");
                Console.WriteLine("2- Load Old Save");
                Console.WriteLine("3- Options");
                Console.WriteLine("4- Quit");
                Console.WriteLine("*****************");
                Console.WriteLine("");
               
                //Where the user input modifies the value of menuChoice.
              
                menuChoice = int.Parse(Console.ReadLine());
                
                // Prevents the allowcation of an invalid paramater
              
                while (menuChoice <= 0 || menuChoice >= 5)
                {
                    Console.WriteLine("Please Insert a Valid Option");
                    menuChoice = int.Parse(Console.ReadLine());
                }
               
                //Actual results for the menu
               
                if (menuChoice == 4)
                {
                    Console.WriteLine("Closing Program...");
                }

                else if (menuChoice == 3)
                {
                    Console.WriteLine("Error: 404 Options Page Not Found");
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("Loading Preveious Game Save... What Save Data You Haven't Player This Game.");
                }
                else if (menuChoice == 1) 
                {
                    Console.WriteLine("Loading Game... What Game?");
                }

            }




        }
}   }