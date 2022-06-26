//check a number is odd or even
Console.WriteLine("Enter integer number");
int inputValue = Convert.ToInt32(Console.ReadLine());

if (inputValue % 2 == 0)
{
    Console.WriteLine("{0} is even number.", inputValue);
}
else
{
    Console.WriteLine("{0} is odd number.", inputValue);
}
