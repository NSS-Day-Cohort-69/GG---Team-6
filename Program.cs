// See https://aka.ms/new-console-template for more information

/*
PHASE 1:
Need to display a message to the user asking them to choose a random number
Display a prompt for the users guess
take the users guess as an input and save it to a variable
display the users guess back to the screen*/


Console.WriteLine("Please guess the Secret Number!");
int response = int.Parse(Console.ReadLine()!.Trim());
int secretNumber = 42;
CompareTheNumber();
/*we need to compare the users number to the secret number
 we need a function to handle this*/

void CompareTheNumber()
{
    if (response == secretNumber)
    {
        Console.WriteLine("You guessed right!!!");
    }
    else
    {
        Console.WriteLine("You failed! Guess again!");
    }
}