//Задача 2: 

int a, b; 
Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("max = a");
}
else if (a<b)
{
    Console.WriteLine("max = b");
}
