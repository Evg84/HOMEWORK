Console.Clear();
Console.WriteLine("Введите день недели цифрой :");
int n = Convert.ToInt32(Console.ReadLine());



if (1 <= n && n <= 5)
{
    Console.WriteLine("Этот день рабочий");
}
else if (6 <= n && n <= 7)
{
    Console.WriteLine("Этот день выходной");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}