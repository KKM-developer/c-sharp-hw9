/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
string PrintNumber (int m, int n)
{
   if (m == n) return $"{n}";
   return $"{m} {PrintNumber(m+1, n)}";
}
Console.WriteLine("Задача 1");
Console.Write("Введите начало отчета ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(m, n));
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/