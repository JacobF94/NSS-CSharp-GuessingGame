using System;

Main();
void Main()
{
    GamePrompt(DifficultySelect());
};

void GamePrompt(int difficulty)
{
    for (int i = 0; i < difficulty; i++)
    {
    Console.WriteLine($"Welcome to the guessing game! You are on guess #{i + 1} of {difficulty}. Guess the secret number between 1 and 100:");
    string input = Console.ReadLine();
    int x;
    bool success = int.TryParse(input, out x);
    if (success)
    {
        Random r = new Random();
        int secretNumber = r.Next(1, 100);
        if (x == secretNumber)
        {
            Console.Write("Congratulations, you guessed the secret number!!!");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, you guessed wrong!!");
            if (x > secretNumber)
                {
                    Console.WriteLine("Your guess was too high!!");
                }
            else
                {
                    Console.WriteLine("Your guess was too low!!");
                }
        }
    }
    else
    {
        Console.WriteLine("You didn't enter a real number!");
    }
}
};

int DifficultySelect()
{
    Console.Write("Welcome to the guessing game!! Please type the difficulty you want to do, easy, medium, or hard: ");
    string userAnswer = Console.ReadLine().ToLower();
    if (userAnswer == "easy")
    {
        return 8;
    }
    else if (userAnswer == "medium")
    {
        return 4;
    }
    else if (userAnswer == "hard")
    {
        return 2;
    }
    else
    {
        Console.Write("Please enter a correct difficulty setting!!");
        return 0;
    }
}