int i = 1;
float total = 0;
int count = 0;

while (i < 8)
{
    Console.WriteLine("Введите число №" + i +" ");
    count = Convert.ToInt32(Console.ReadLine());
    total = total + count;
    i++;
}

total = total / 7;
Console.WriteLine("Среднее арифметическое равно :");
Console.WriteLine(total);