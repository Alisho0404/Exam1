  Console.Write("VVedite razmer massiva: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Vvedite elementi massiva");

for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int minValue = array[0];
int maxValue = array[0];
int minIndex = 0;
int maxIndex = 0;
for (int i = 1; i < size; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
        minIndex=i;

    }
}
for (int i = 1; i < size; i++)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
        maxIndex=i;
    }
}
Console.WriteLine($"Index minimalnovo znachenii={minValue}");
Console.WriteLine($"Index maksimalnovo znachenii={maxValue}");
if (minIndex < maxIndex)
{
    for (int i = minIndex; i <= maxIndex; i++)
    {
        Console.Write(array[i] + " ");
    }

}
else
{
    for (int i = maxIndex; i <= minIndex; i++)
    {
        Console.Write(array[i] + " ");
    }
}
