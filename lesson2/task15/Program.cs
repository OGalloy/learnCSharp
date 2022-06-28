/*Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int checkNumber(int arg)
{
    if (arg == 6 || arg == 7)
    {
        return 0;
    }
    else
    {
        return -1;
    }
};
Console.Write("Enter number day of the week:");
int number = Convert.ToInt32(Console.ReadLine());
//
if (checkNumber(number) == 0)
{
    Console.WriteLine("This day is weekend.");
}
else if (checkNumber(number) == -1)
{
    Console.WriteLine("This day is not weekend.");
}

