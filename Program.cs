using System;

Main();
void Main()
{
    GamePrompt();
};

void GamePrompt()
{
    Console.WriteLine("Welcome to the guessing game! Guess the secret number between 1 and 50:");
    string input = Console.ReadLine();
    int x;
    bool success = int.TryParse(input, out x);
    if (success)
    {
        Random r = new Random();
        int secretNumber = r.Next(1, 50);
        if (x == secretNumber)
        {
            Console.Write("Congratulations, you guessed the secret number!!!");
        }
        else
        {
            Console.Write("Sorry, you guessed wrong!!");
        }
    }
    else
    {
        Console.WriteLine("You didn't enter a real number!");
    }
};
