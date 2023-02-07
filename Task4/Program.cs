// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
}

int[] numbers = new int [25];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,100);
}
Print(numbers);

Console.WriteLine();

int sum=0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i%2 != 0)
    {
        sum=sum+numbers[i];
        Console.Write(numbers[i]+ " ");
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетной позиции равна {sum}");