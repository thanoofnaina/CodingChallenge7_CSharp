

Console.Write("Enter the passenger name: ");
var name  = Console.ReadLine();

Console.Write("Enter the travel distance (in miles): ");
var distance = Convert.ToDouble(Console.ReadLine());

var flyerPoint = 0;

if (distance > 100_000)
{
    flyerPoint = 50;
}
else if (distance > 50_000)
{
    flyerPoint = 30;
}
else if (distance > 20_000)
{
    flyerPoint = 20;
}
else if (distance > 10_000)
{
    flyerPoint = 10;
}

Console.WriteLine($"Mr./Mrs. {name} has {flyerPoint} frequent flyer points");