using System;
 
 
namespace NumberGuesserGame
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            GetAppilicationInformation();
 
            GreetUser(); 
 
            while (true)
            {
 
                
                Random random = new Random();
 
            
                int correctNumber = random.Next(1, 10);
 
                
                int guess = 0;
 
                
                Console.WriteLine("Guess a number between 1 and 10");
 
                
                while (guess != correctNumber)
                {
                    
                    string input = Console.ReadLine();
 
                    
                    if (!int.TryParse(input, out guess))
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
 
                        
                        continue;
                    }
 
                    
                    guess = Int32.Parse(input);
 
                    
                    if (guess != correctNumber)
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
 
                
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");
 
                
                Console.WriteLine("Play Again? [Y or N]");
 
                
                string answer = Console.ReadLine().ToUpper();
 
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }           
 
        }
 
        
        static void GetAppilicationInformation() {
            
            string applicationName = "Number Guesser Game";
            string applicationVersion = "3.2.1";
            string applicationAuthor = "Caleb Obi";
 
            
            Console.ForegroundColor = ConsoleColor.Green;
 
            
            Console.WriteLine("{0}: Version {1} by {2}", applicationName, applicationVersion, applicationAuthor);
 
            
            Console.ResetColor();
        }
 
        
        static void GreetUser() 
        {
            
            Console.WriteLine("Enter your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string inputLastName = Console.ReadLine();
            Console.WriteLine("Enter Age: **(Must be 10+ to play) ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
 
 
            if (inputAge < 10)
            {
                Console.WriteLine("You are not above Years, Therefore you are not allowed to play");
                return;
            }
            
            else 
            {
                Console.WriteLine("Hello {0}, let's play a game...", inputName);
            }
 
 
            
        }
 
    
        static void PrintColorMessage(ConsoleColor color, string message) {
            
            Console.ForegroundColor = color;
 
            
            Console.WriteLine(message);
 
            
            Console.ResetColor();
        }
    }
}
