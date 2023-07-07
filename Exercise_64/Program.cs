// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RangeFromNTo1 (int n)
{
   if (n > 1)
    {
        Console.Write($"{n}, ");
        RangeFromNTo1 (n - 1);
    }
    if (n == 1)
            Console.Write($"{n}.");
    
}

Console.WriteLine("Input your N: ");
int userN = Convert.ToInt32(Console.ReadLine());
while (userN < 1)
{
    Console.WriteLine("Error! Try again with your N >= 1:");
    userN = Convert.ToInt32(Console.ReadLine());
}
RangeFromNTo1 (userN);
