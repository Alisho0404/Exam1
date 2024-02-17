 int Fibonach(int n)
{


    if (n == 0 || n==1)
    {
        return 1;
    }
    else
    {

        return Fibonach(n - 1) + Fibonach(n - 2);

    }
}
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Fibonach(i) + "");
}