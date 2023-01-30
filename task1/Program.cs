Console.WriteLine ("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int maximal = 0;

if (a > b)
{
    maximal = a;
    
    Console.Write("Максимальное число: ");
    Console.Write(maximal);
}
else
{
    maximal = b;

    Console.Write("Максимальное число: ");
    Console.Write(maximal);
}
