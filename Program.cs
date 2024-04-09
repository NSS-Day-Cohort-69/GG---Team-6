// See https://aka.ms/new-console-template for more information

/*
PHASE 1:
Need to display a message to the user asking them to choose a random number
Display a prompt for the users guess
take the users guess as an input and save it to a variable
display the users guess back to the screen*/

// We are gonna need the random number, and display the number of guesses they have left.
Random random = new Random();
int randomNumber = 0;
while (randomNumber == 0)
{
    int chosenRandomNumber = random.Next(1, 100);
    randomNumber = chosenRandomNumber;
}
Console.WriteLine(randomNumber);
int choice = 0;
int secretNumber = randomNumber;
int Count = 0;
SetGuessCount(ReadDifficultyLevel());
Console.WriteLine("Please guess the Secret Number!");
while (secretNumber != choice && Count > 0)
{
    CompareTheNumber();
}
/*we need to compare the users number to the secret number
 we need a function to handle this*/

void CompareTheNumber()
{
    choice = int.Parse(Console.ReadLine()!.Trim());
    Count--;
    if (choice == secretNumber)
    {
        Console.WriteLine("You guessed right!!!");
    }
    else if (Count >= 1)
    {
        DetermineDifference();
        Console.WriteLine($"Your choice was {choice}, you have {Count} more guesses left, Guess again!");
    }
    else
    {
        Console.WriteLine("You failed! Goodbye!");
    }
}
// program should inform user if their guess was too high or too low
// if else statement?
// if (choice > secretNumber) {Console.WriteLine("Your guess was too low!)}
void DetermineDifference()
{
    if (choice > secretNumber)
    {
        Console.WriteLine("You guessed too high!");
    }
    else
    {
        Console.WriteLine("You guessed too low!");
    }
}
// Implement a menu function
int ReadDifficultyLevel()
{
    int mode = 0;
    while (mode == 0)
    {
        Console.WriteLine(@"Welcome to Guessing Game! Please Pick a difficulty level:
                            1. Easy
                            2. Medium
                            3. Hard");
        mode = int.Parse(Console.ReadLine());
    }
    return mode;
};
void SetGuessCount(int mode)
{
    if (mode == 1)
    {
        Count = 8;
    }
    else if (mode == 2)
    {
        Count = 6;
    }
    else if (mode == 3)
    {
        Count = 4;
    }
};
/* @Welcome to Guessing Game! Please Pick a difficulty level:
    1. Easy
    2. Medium
    3. Hard

    while (mode == 0)
    {
        display menu
        readline for user's input
    }
    if user chooses easy {
        make count equal 8
    }
    if user chooses medium {
        count equal 6
    }
    if user chooses hard {
        count equal 4
    }
*/
// options will be 1. Easy, 2. Medium, 3. Hard
// Whatever choice they make determines how many choices the user gets
// for easy, the user gets 8 choices
// for medium, the user gets 6 choices
// for hard, the user gets 4 choices


// LEFT OFF AT CHANGING COUNT TO RESPECTIVE MODE