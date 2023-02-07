// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
}

int[] numbers = new int [8];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10,11);
}
Print(numbers);
Console.WriteLine();
int max = numbers[0];
int min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>max)
    {
        max=numbers[i];
    }
    else if (numbers[i]<min)
    {
        min=numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом {max-min}");