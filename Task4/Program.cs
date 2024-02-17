 Console.Write("VVedite razmer massiva: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Vvedite elementi massiva");

for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
foreach (int elements in array)
{
    if (elements > 0)
    {
        Console.Write(0+" ");
    }
    else
    {
        Console.Write(elements+" ");
    }
}
