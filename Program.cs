// See https://aka.ms/new-console-template for more information

/*
PHASE 1:
Need to display a message to the user asking them to choose a random number
Display a prompt for the users guess
take the users guess as an input and save it to a variable
display the users guess back to the screen*/


Console.WriteLine("Please guess the Secret Number!");
string? choice = null;
string secretNumber = "42";
int Count = 0;
while (secretNumber != choice && Count <= 3)
{
    choice = Console.ReadLine()!.Trim();
    CompareTheNumber(Count, secretNumber, choice);
    Count++;

}
/*we need to compare the users number to the secret number
 we need a function to handle this*/

void CompareTheNumber(int Count, string secret, string choice)
{
    if (choice == secret)
    {
        Console.WriteLine("You guessed right!!!");
    }
    else if (Count <= 2)
    {
        Console.WriteLine($"You guessed {choice}, That was wrong! Guess again!");
    }
    else
    {
        Console.WriteLine("You failed! Goodbye!");
    }
}