using Queen.Models;
using Queen.UserInterfaceModels;

namespace Queen{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(WelcomeBanner.Welcome);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Find out if the queen claims another victim!");
            Console.WriteLine("Enter coordinates for Her Majesty.");
            Console.WriteLine("Then, enter coordinates for her enemy.");
            Console.WriteLine("The Queen's X coordinate (a value from 1 to 8): ");
            string stringQueenX = Console.ReadLine();            
            int queenX = int.Parse(stringQueenX);
            Console.WriteLine("The Queen's Y coordinate (a value from 1 to 8): ");
            string stringQueenY = Console.ReadLine();           
            int queenY = int.Parse(stringQueenY);
             Console.WriteLine("The Enemy's X coordinate (a value from 1 to 8): ");  
            string stringEnemyX = Console.ReadLine();
            int enemyX = int.Parse(stringEnemyX);
            Console.WriteLine("The Enemy's Y coordinate (a value from 1 to 8): ");
            string stringEnemyY = Console.ReadLine();            
            int enemyY = int.Parse(stringEnemyY);

            EnemyCalc enemyLocation = new EnemyCalc(enemyX, enemyY);
            QueenCalc queenLocation = new QueenCalc(queenX, queenY, enemyLocation);
            CheckQueenAttack(queenLocation);
        }

        static void CheckQueenAttack(QueenCalc queenLocation)
        {
            if (queenLocation.CheckRow() || queenLocation.CheckCol() || queenLocation.CheckDiagonal())
            {
                Console.WriteLine("The Queen attacks!");
            }
            else 
            {
              Console.WriteLine("The Queen can't do anything");
            }

            Console.WriteLine("Would you like to check other positions? Type 'yes' if so");
            string userResponse = Console.ReadLine();
            if(userResponse == "yes" || userResponse == "Yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            
        }
    }
}
