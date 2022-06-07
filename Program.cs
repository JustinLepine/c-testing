 
Console.Title = "Ramen";
Console.ForegroundColor = ConsoleColor.Green;

int num01;
int num02;

Console.WriteLine("input a number: ");

num01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("input a second number: ");

num02 = Convert.ToInt32( Console.ReadLine() );

int result = num01 * num02;

Console.WriteLine("The result is " + result);

Console.ReadKey();