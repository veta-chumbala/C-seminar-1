Console.WriteLine("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if (second_num * second_num == first_num) 
{Console.WriteLine($"{first_num} является квадратом {second_num}");}
else
{Console.WriteLine($"{first_num} не является квадратом {second_num}");}