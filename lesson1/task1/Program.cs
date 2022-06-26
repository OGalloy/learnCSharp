//searching maximal and minimal value of two integers.
Console.WriteLine("Enter first integer number");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second integer number");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue)
{
    Console.WriteLine("{0} is maximal value.", firstValue);
    Console.WriteLine("{0} is minimal value.", secondValue);
}
else
{
    Console.WriteLine("{0} is maximal value.", secondValue);
    Console.WriteLine("{0} is minimal value.", firstValue);    
}