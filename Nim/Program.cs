using System.ComponentModel.Design.Serialization;

namespace Nim
{
    class Program
    {
        static void Main()
        {
            int currentMatches = 24;
            string matches = "||||||||||||||||||||||||";
            Random random = new Random();

            //Here is the function where we can change the matches
            void MatchControl(int changeMatch)
            {
                matches = "";
                currentMatches -= changeMatch;
                int i = 0;
                while (i < currentMatches)
                {
                    matches += "|";
                    ++i;
                }
            }
            
            //Game start
            Console.WriteLine("Welcome to Nim!");
            Console.WriteLine("In this game you and an ai will take turns drawing matches");
            Console.WriteLine("You can only draw 1, 2 or 3 matches at a time");
            Console.WriteLine("Whoever has to draw the last match loses");
            Console.WriteLine("We start with 24 matches! Good luck.");
            Console.WriteLine(matches);
           
            //Game loop
            while (currentMatches != 100)
            {
                //Check if game is over
                if (currentMatches == 1) goto lose;
                else if (currentMatches <= 0) goto win;
                
                //Player turn
                Console.WriteLine("Do you want to draw 1, 2 or 3 matches?");
                fuckup:
                int changeMatch = Convert.ToInt32(Console.ReadLine());
                if (changeMatch > 3 || changeMatch < 1)
                {
                    Console.WriteLine("please only type 1, 2 or 3");
                    goto fuckup;
                }
                MatchControl(changeMatch);
                Console.WriteLine($"You drew {changeMatch} matches,");
                Console.WriteLine(matches);
                
                //Check if game is over
                if (currentMatches == 1) goto win;
                else if (currentMatches <= 0) goto lose;
                
                //Ai turn
                int aiNum = random.Next(1, 4);
                changeMatch = aiNum;
                MatchControl(changeMatch);
                Console.WriteLine($"The ai drew {changeMatch} matches,");
                Console.WriteLine(matches);
            }
            
            //Game over state
            win: Console.WriteLine("You win");
            return;
            lose: 
            Console.WriteLine("You lose");

        }
    }
}