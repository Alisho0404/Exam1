 int size=int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i]=int.Parse(Console.ReadLine());
}
int differentElement = 1;

for (int i = 0; i < size-1; i++)
{
    if (array[i] != array[i + 1])
    {
        differentElement++;
    } 
}
Console.WriteLine(differentElement);