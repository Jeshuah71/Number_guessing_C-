// Create a random number generator
Random random = new Random();

// Generate a number between 1 and 10
int secretNumber = random.Next(1, 11);

// Initialize variables
int guess = 0;
int attempts = 0; 

// Display welcome message
Console.WriteLine("Welcome to the Number Guessing Game!");