//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число N");
int count = 0;
int number1 = int.Parse(Console.ReadLine());
if (number1 > 0)
{
    count = number1 * (-1);
    while (count <= number1)
    {
    Console.Write($"{count}, ");
    count ++;
    }
}
else
{
    count = number1;
    while (count <= number1 * (-1))
    {
    Console.Write($"{count}, ");
    count ++;
    }
}