 int SumOfDigits(int n)
{
    int sum = 0;
    
    while (n > 0)
    {
        int lastInteger = n % 10;
        n /= 10; 
        sum += lastInteger;

    } 
    return sum;

} 
int n=int.Parse(Console.ReadLine());
Console.WriteLine($"The sum of the digits of the number {n} is : {SumOfDigits(n)}");