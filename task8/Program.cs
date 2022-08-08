// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Найдем все четные числа от 1 до N. Введите число N");

double N = Convert.ToInt32(Console.ReadLine());

double count = 1, rem = 1;

Console.Write("от 1 to " + N + " четные числа ");

while(count < N + 1)
{
    rem = count % 2;
    if (rem == 0) Console.Write(count + ", ");
    count = count + 1;
}