 void OddEven(int a, int b)
{
    if (a < b)
    {
        if (a % 2 == 0)
        {


            OddEven(a + 1, b);
            Console.Write(a + " ");
             

        }

        else
        {
            Console.Write(a + " ");
            OddEven(a + 1, b);
            Console.WriteLine();
           
        }
    }
}
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
OddEven(a, b);