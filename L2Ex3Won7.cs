// Ex. 3:  Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura.

Console.WriteLine("Enter a number: ");

int number = int.Parse(Console.ReadLine());

int sum = 0;


while ( number != 0)
{
   int digit = number % 10;

    sum += digit;

    number /= 10;
}

Console.WriteLine(sum);
