// Написать программу, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 1;

    while (count <= number)
    {
        if (count % 2 == 0)
            Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Число не является положительным!");
}
