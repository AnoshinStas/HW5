void FillArray(int[] numbers)
{
    Random rmd = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rmd.Next(100, 1000);
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
int count = 0;

for (int x = 0; x < numbers.Length; x++)
if (numbers[x] % 2 == 0)
count++;

Console.WriteLine($"всего чисел {numbers.Length}, чётных {count}");
