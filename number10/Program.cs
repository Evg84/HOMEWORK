Console.Clear();
Console.WriteLine("\nВведите число :");
int n = Convert.ToInt32(Console.ReadLine());

int a = n / 10;
int b = a % 10;

if (b < 0) b = b* -1;

Console.WriteLine("Вторая цифра числа :");
Console.WriteLine(b);
