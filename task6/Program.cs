// Напишите программу, которая на вход принимает число и выдаёт
//является ли число чётным

{
    Console.Write("Введите число");
}
double num = Convert.ToInt32(Console.ReadLine());

double rem = num %2;

if (rem == 0) Console.WriteLine(num + "Четное число");

else Console.WriteLine(num + "Не четное число");