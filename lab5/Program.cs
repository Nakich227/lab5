Console.Write("введите значение x = ");
double x = double.Parse(Console.ReadLine());
double s = 0;
int n = 0;
double a = 10 / x;
const double e = 0.001;
while(a>=e)
{
    s=s+a; 
    n++;
    a = a / n;
}
Console.WriteLine($"s ={s} n={n}");