Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine ());
int max;
if (a > b & a>c)  
{
    max = a;
    } 
    else
    {
if (b > c)  
{
    max = b;
} 
else max = c;}
Console.WriteLine(max);
