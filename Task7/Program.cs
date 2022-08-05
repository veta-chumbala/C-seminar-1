Console.WriteLine("Напишите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{Console.Write($"Последняя цифра числа {number} - это {number % 10}");}
else {Console.WriteLine("Введено неверное число.");}