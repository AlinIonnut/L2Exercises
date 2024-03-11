//Ex. 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru x citit de la tastatura

Console.WriteLine("Enter a number: ");

double number = double.Parse(Console.ReadLine());

double y;

if(number <= -2)
{
    y = 7 * Math.Pow(2, number);
}
else if(number <= 0.5)
{
    y = 4 * number - 5;
}
else 
{
    y = 14 * number - 7;
}

Console.WriteLine("The value of the function for x = " + number + " is y = " + y);