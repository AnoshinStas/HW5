void FillArray(int[] numbers)
{
    Random rmd = new Random();
    for(int i = 0; i< numbers.Length; i++)
    {
        numbers[i] = rmd.Next(1,10);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int x = 0; x < numbers.Length; x+=2)
    sum = sum + numbers[x];
    Console.WriteLine($"всего чисел {numbers.Length}, сумма элеметов с нечетными индексами = {sum}"); 
