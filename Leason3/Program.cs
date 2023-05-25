// // /*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в 
//двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10*/

int Prompt()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

string ConvertToBinary(int num)
{
    string binary = string.Empty;
    while (num > 0)
    {
        binary = Convert.ToString(num%2) + binary;
        num = num / 2;
    }
    return binary;
}

Console.WriteLine(ConvertToBinary(Prompt()));
