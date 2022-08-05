Console.WriteLine("Напишите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
if (num > 0)
{while (i <= num)
    {
        Console.Write($" {i}");
        i += 1;
    }
}
else Console.WriteLine("Введено неверное число");