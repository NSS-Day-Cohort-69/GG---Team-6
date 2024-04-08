// See https://aka.ms/new-console-template for more information

/*
PHASE 1:
Need to display a message to the user asking them to choose a random number
Display a prompt for the users guess
take the users guess as an input and save it to a variable
display the users guess back to the screen*/


Console.WriteLine("Please guess the Secret Number!");
int response = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine($"You chose: {response}");
