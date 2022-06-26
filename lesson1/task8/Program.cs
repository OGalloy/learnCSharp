//
Console.WriteLine("Enter integer number.");
int inputValue = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= inputValue; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
