//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void Print (int[] numbers)
{
    for (int i=0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i]+ " ");
    }
}

int [] numbers = new int [10];
for (int i = 0; i<numbers.Length; i++)
{
    numbers[i] = new Random().Next(100,1000);
}
 
Print (numbers);
int countEven=0;
int countOdd=0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] %2 == 0)
    {
        countEven++;
    }
    else countOdd++;
}
Console.WriteLine($"Количество четных чисел в массиве {countEven}, количество нечетных чисел в массиве {countOdd}");