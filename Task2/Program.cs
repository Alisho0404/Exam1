Console.Write("VVedite razmer massiva: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Vvedite elementi massiva");

for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Vvedite index: ");
int index = int.Parse(Console.ReadLine());
for (int i = 0;i < size; i++)
{
    if (i == index)
    {
        continue;
    } 
    else
    Console.Write(array[i]+" ");
}