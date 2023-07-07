// Задача 68*: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunc (int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    if (numM > 0 && numN == 0)
        return AckermannFunc(numM - 1, 1);
    if (numM > 0 && numN > 0)
        return AckermannFunc(numM - 1, AckermannFunc(numM, numN - 1));
    return AckermannFunc(numM, numN);
}

Console.WriteLine("Input your number M:");
int userNumM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number N:");
int userNumN = Convert.ToInt32(Console.ReadLine());

int ackerResult = AckermannFunc(userNumM, userNumN);
Console.WriteLine($"Ackerman Function result is {ackerResult}");