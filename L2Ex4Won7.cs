//  Ex 4: Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura.

Console.WriteLine("Enter a number: ");

int number = int.Parse(Console.ReadLine());

int factorial = 1;

for(int i = 1; i <= number; i++)
{
    factorial *= i;
}
Console.WriteLine("The factorial of " + number + " is " + factorial);