// Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());

int pow = A;

for (int i = 1; i < B; i++)
{
    pow = pow * A;
}

Console.WriteLine($"{A} в степени {B} равно {pow}");