// // Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Prompt()
{
    Console.Write("Введите сторону треугольника: ");
    int side = int.Parse(Console.ReadLine());
    return side;
}

void CheckValid(int sideA, int sideB, int sideC)
{
    bool check = false;
    if (sideA<(sideB+sideC) && sideB<(sideA+sideC) && sideC<(sideB+sideA))  
    {
        check = true;
    }
    if(check == true)
    { 
    Console.WriteLine("Треугольник с заданными сторонами существует");
    }
    else
    {
    Console.WriteLine("Треугольник с заданными сторонами не существует");
    }
}

int sideA = Prompt();
int sideB = Prompt();
int sideC = Prompt();

CheckValid(sideA, sideB, sideC);