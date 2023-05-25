// // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int PromptNumber()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [] FiboNumbers (int num)
{
    int [] fiboNumber = new int[num];
    fiboNumber[0] = 0;
    fiboNumber[1] = 1;

    for (int i=2; i<fiboNumber.Length; i++)
    {
        fiboNumber[i] = fiboNumber[i - 1] + fiboNumber[i - 2];
    }
    return fiboNumber;
}

void PrintArray (int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($" {arr[i]} "); 
    }
} 

PrintArray(FiboNumbers(PromptNumber())); 
Console.WriteLine();
