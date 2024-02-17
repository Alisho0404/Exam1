 Console.Write("VVedite razmer massiva: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Vvedite elementi massiva");

for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Vvedite chislo");
int givenNumber=int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
	if (givenNumber == array[i])
	{
		count++;
	}
}
Console.WriteLine(count);