// searching maximum value of three integrs.

//declare array of integers.
int[] intArray = new int[3]; 

Console.WriteLine("Enter first value");
intArray[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second value");
intArray[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third value");
intArray[2] = Convert.ToInt32(Console.ReadLine());
 
int maxValue= intArray[0];

for (int i = 0; i < intArray.Length-1; i++)
{
    if (maxValue < intArray[i+1])
    {
        maxValue = intArray[i+1];
    }
}

Console.WriteLine("Maximal value equal {0}", maxValue);
