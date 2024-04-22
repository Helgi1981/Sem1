
// Написать программу, которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число больше");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше");
}
else if (num1 == num2)
{
    Console.WriteLine("Введённые числа равны");
}
