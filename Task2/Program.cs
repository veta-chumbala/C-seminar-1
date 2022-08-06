Console.WriteLine("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}