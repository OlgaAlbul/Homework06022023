// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


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
    numbers[i] = new Random().Next(0,2);
}
Print(numbers);
