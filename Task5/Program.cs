// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


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
    numbers[i] = new Random().Next(1,20);
}
Print(numbers);
Console.WriteLine();

for (int i = 0; i < numbers.Length/2; i++)
{
    Console.WriteLine(numbers[i]*numbers[numbers.Length-1-i]);
}

