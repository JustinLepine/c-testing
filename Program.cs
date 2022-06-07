 
Console.Title = "Ramen";
Console.ForegroundColor = ConsoleColor.Green;

double num01;
double num02;
double num03;

Console.WriteLine("input a number: ");
num01 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("input a second number: ");
num02 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("input a third number: ");
num03 = Convert.ToDouble( Console.ReadLine() );

double result = (num01 + num02 + num03) / 3;

Console.WriteLine("The result is " + result);

Console.ReadKey();


