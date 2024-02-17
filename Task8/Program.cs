 void Swap(ref int a, ref int b)
{
    a = a + b;
    b = a - b;
    a=a-b;
    Console.WriteLine($"X = {a}"); 
    Console.WriteLine($"Y = {b}"); 
}
Console.Write("X = ");
int a=int.Parse(Console.ReadLine());
Console.Write("Y = ");
int b = int.Parse(Console.ReadLine());

Swap(ref a,ref b);