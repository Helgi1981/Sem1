// Написать программу, которая на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Это число являетья чётным");
}
else
{
    Console.WriteLine("Это число являетья нечётным");
}