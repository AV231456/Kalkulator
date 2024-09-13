Console.WriteLine("Введите первое значение");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию");
var o = Console.ReadLine();
if (o == "*")
{
    Console.WriteLine($"Ответ {a * b}");
}

