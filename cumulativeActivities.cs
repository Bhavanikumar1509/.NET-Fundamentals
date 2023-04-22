/*Factorizer*/
using System;
class Factorizer{
    public static void Main(String[] args){
        Console.WriteLine ("Please enter an integer value:");
    int num = Convert.ToInt32(Console.ReadLine());

    int factorSum = 0;
    string factors = "";

    bool isPrime = true;
    for (int i = 2; i <= Math.Sqrt(num); i++) {
      if (num % i == 0) {
        isPrime = false;
        break;
      }
    }
    for (int i = 1; i <= num; i++) {
      if (num % i == 0) {
        factors += i.ToString() + " ";
        factorSum += i;
      }
    }
    bool isPerfect = (factorSum - num == num);
    Console.WriteLine("Factors: " + factors);
    Console.WriteLine("Is Perfect: " + isPerfect);
    Console.WriteLine("Is Prime: " + isPrime);
  }

    }

/*FizzBuzz*/
using System;
class FizzBuzz{
    public static void Main(String[] args){
    for (int i = 1; i <= 100; i++)
    {
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz " + i);
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz " + i);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz " + i);
    }
    else
    {
        Console.WriteLine(i);
    }
    }
}
}


/*Interest Calculator*/

using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the annual interest rate % growth? ");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.Write("How much do you want to invest? ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("How many years are investing? ");
            int numYears = int.Parse(Console.ReadLine());

            double quarterlyInterestRate = annualInterestRate / 4 / 100;
            double balance = principal;

            Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20}", "Year", "Beginning balance", "Interest earned", "Ending balance");

            for (int year = 1; year <= numYears; year++)
            {
                double interestEarned = 0;

                for (int quarter = 1; quarter <= 4; quarter++)
                {
                    interestEarned += balance * quarterlyInterestRate;
                    balance *= (1 + quarterlyInterestRate);
                }

                Console.WriteLine("{0,-10} {1,-20:C} {2,-20:C} {3,-20:C}", year, principal, interestEarned, balance);

                principal = balance;
            }
        }
    }
}


/*Lucky Sevens*/

using System;

class LuckySevens
{
    static void Main(string[] args)
    {
        Console.Write("How many dollars do you have? ");
        int balance = int.Parse(Console.ReadLine());

        int rolls = 0; 
        int maxBalance = balance; 
        int maxRolls = 0; 

        while (balance > 0) 
        {
            int dice1 = new Random().Next(1, 7); 
            int dice2 = new Random().Next(1, 7); 
            int sum = dice1 + dice2; 

            if (sum == 7) 
            {
                balance += 4; 
            }
            else 
            {
                balance -= 1; 
            }

            rolls++; 
            if (balance > maxBalance) 
            {
                maxBalance = balance; 
                maxRolls = rolls; 
            }
        }

        Console.WriteLine("You are broke after {0} rolls.", rolls);
        Console.WriteLine("You should have quit after {0} rolls when you had ${1}.", maxRolls, maxBalance);
    }
}


/*The Guessing Game*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.Write("Before we start, what is your name? ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Hello {playerName}!");

        int minNumber = 1;
        int maxNumber = 20;
        Console.WriteLine("Please select a difficulty level:");
        Console.WriteLine("1 - Easy (1-5)");
        Console.WriteLine("2 - Normal (1-20)");
        Console.WriteLine("3 - Hard (1-50)");
        Console.Write("Enter your choice: ");
        string difficultyChoice = Console.ReadLine();

        switch (difficultyChoice)
        {
            case "1":
                maxNumber = 5;
                break;
            case "3":
                maxNumber = 50;
                break;
            default:
                break;
        }

        Random random = new Random();
        int randomNumber = random.Next(minNumber, maxNumber + 1);

        int numberOfGuesses = 0;
        while (true)
        {
            Console.Write($"Guess a number between {minNumber} and {maxNumber} or enter Q to quit: ");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Q")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Thanks for playing, {playerName}!");
                break;
            }

            if (!int.TryParse(input, out int guess) || guess < minNumber || guess > maxNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number within the valid range.");
                continue;
            }

            numberOfGuesses++;

            if (guess == randomNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (numberOfGuesses == 1)
                {
                    Console.WriteLine($"Amazing {playerName}! You guessed it on your first try!");
                }
                else
                {
                    Console.WriteLine($"Congratulations, {playerName}! You guessed the number in {numberOfGuesses} attempts.");
                }
                break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(guess < randomNumber ? "Too low. Try again!" : "Too high. Try again!");
        }

        Console.ResetColor();
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}