// See https://aka.ms/new-console-template for more information

/*
PHASE 1:
Need to display a message to the user asking them to choose a random number
Display a prompt for the users guess
take the users guess as an input and save it to a variable
display the users guess back to the screen*/

// We are gonna need the random number, and display the number of guesses they have left.
Random random = new Random();

    int chosenRandomNumber = random.Next(1, 100);

Console.WriteLine(chosenRandomNumber);
Console.WriteLine("Please guess the Secret Number!");
int choice = 0;
int Count = 4;
while (chosenRandomNumber != choice && Count > 0)
{
    CompareTheNumber();


}
/*we need to compare the users number to the secret number
 we need a function to handle this*/

void CompareTheNumber()
{
    choice =int.Parse(Console.ReadLine()!.Trim());
    Count--;
    if (choice == chosenRandomNumber)
    {
        Console.WriteLine("You guessed right!!!");
    }
    else if (Count >= 1)
    {
        ProvideNumberFeedback();
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
void ProvideNumberFeedback()
{
    if (choice > chosenRandomNumber)
    {
        Console.WriteLine("You guessed too high!");
    }
    else
    {
        Console.WriteLine("You guessed too low!");
    }
}