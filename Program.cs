// Create a random number generator
Random random = new Random();

// Generate a number between 1 and 10
int secretNumber = random.Next(1, 11);

// Initialize variables
int guess = 0;
int attempts = 0; 

// Display welcome message
Console.WriteLine("Welcome to the Number Guessing Game!");

// Keep playing until the correct guess 
while (guess != secretNumber)
{
    // Ask user for a number
    Console.Write("Guess a number between 1 and 10: ");

    // Read User input
    string? input = Console.ReadLine();

    // Convert input to integer
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Please enter a valid number");
        continue; // Restart the loop
    }

    attempts ++;

    // Check if the guess is too log
    if (guess < secretNumber)
    {
        Console.WriteLine("Too low!");
    }

    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high!");
    }

    // Correct guess
    else
    {
        Console.WriteLine("Congratulations!");

        // Display total attempts
        Console.WriteLine($"You won in {attempts} attempts! ");
    }
}