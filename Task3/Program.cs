// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} \t");
    }
}

int[] numbers = new int [123];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(10,100);
}
Print(numbers);
int numberStart = 0;
int numberEnd = 0;
int res = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 10)
    {
        numberStart=i;   
    }
    if (numbers[i]== 99)
    {
        numberEnd=i;
    }
}
Console.WriteLine();
Console.WriteLine(numberStart);
Console.WriteLine(numberEnd);
if (numberEnd>numberStart)
{
    Console.WriteLine( numberEnd+1-numberStart);
}
else Console.WriteLine( numberStart+1-numberEnd);