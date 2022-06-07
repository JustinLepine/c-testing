// See https://aka.ms/new-console-template for more information
Console.WindowHeight = 40;
Console.Title = "Ramen";
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Hello whats your name?");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName + ". My Name is Takumi");
Console.WriteLine("Whats your favourite car?");
string userCar = Console.ReadLine();
Console.WriteLine("Nice that's sick! How much horsepower does that " + userCar + " have");
string userHp = Console.ReadLine();
Console.WriteLine(userName + " your " + userCar + " with " + userHp + " is a solid car");

Console.ReadKey();