//Ex. 2: Scrieti un program care va determina daca un numar negativ citit de la tastatura este divizibil cu 2 si nu este divizibil cu 6

Console.WriteLine("Enter a negative number: ");

while (true)
{
    double number = double.Parse(Console.ReadLine());

    if (number < 0)
    {
        if (number < 0 && number % 2 == 0 && number % 6 != 0)
        {
            Console.WriteLine("This number is divisible by 2 and is not divisible by 6");
        }
        else if (number < 0 && number % 2 == 0 && number % 6 == 0)
        {
            Console.WriteLine("This number is divisible by 2 and by 6");
        }
        else
        {
            Console.WriteLine("This number is not disibile by neither 2 or 6");
        }
        break;
    }
    else
    {
        Console.WriteLine("Enter a negative number");
    }
}