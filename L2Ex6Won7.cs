//Ex. 6: Scrieti un program care va determina daca un numar este sau nu palindrom.

Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

int originalNumber = number;
int reversedNumber = 0;

while (number > 0)
{
    int lastDigit = number % 10;
    reversedNumber = reversedNumber * 10 + lastDigit;
    number /= 10;
}

if (originalNumber == reversedNumber)
{
    Console.WriteLine($"{originalNumber} is a palindrome.");
}
else
{
    Console.WriteLine($"{originalNumber} is not a palindrome.");
}