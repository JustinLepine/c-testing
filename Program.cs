 
Console.Title = "Ramen";
Console.ForegroundColor = ConsoleColor.Green;

Random numberGen = new Random();

for( int i = 0; i < 10; i++ ) {
    Console.WriteLine(i);
}

int roll = 0;
int attempts = 0;

while(roll != 6) {
    roll = numberGen.Next(1, 7);
    Console.WriteLine("You rolled: " + roll);
    attempts++;
}

Console.WriteLine("It took you " + attempts + " to roll a 6.");

Console.ReadKey();
