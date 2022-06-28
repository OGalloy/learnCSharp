/*
Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
Examples:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int findThirdNumber(int arg)
{
    if (arg < 0) arg *= -1; //For working with negative numbers
    if (arg / 100 == 0) return -1; //if third number does not exist return -1
    return (arg - (arg / 1000) * 1000) / 100;
};

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = findThirdNumber(number);
if  (thirdNumber == -1)
{
    Console.WriteLine("Third number does not exist.");
}
else
{
    Console.WriteLine("Third number equal {0}", thirdNumber);
}
