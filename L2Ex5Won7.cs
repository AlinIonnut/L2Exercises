// Ex 5: Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra

Console.WriteLine("Enter how many natural numbers you want to input:");
int n = int.Parse(Console.ReadLine());

int sumOfEvenNumbers = 0;
int countOfEvenNumbers = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter natural number {i + 1}:");
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        sumOfEvenNumbers += number;
        countOfEvenNumbers++;
    }
}

if (countOfEvenNumbers > 0)
{
    double averageOfEvenNumbers = (double)sumOfEvenNumbers / countOfEvenNumbers;
    Console.WriteLine($"The arithmetic mean of the even numbers is: {averageOfEvenNumbers}");
}
else
{
    Console.WriteLine("No even numbers were entered.");
}