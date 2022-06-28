/*Задача 10: Напишите программу,
которая принимает на вход трёхзначное
число и на выходе показывает вторую цифру этого числа.
example:
456 -> 5
782 -> 8
918 -> 1
*/


int findSecondNumber()
{
    Console.Write("Enter three-digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Your number is not three-digit.");
        Console.WriteLine("Try again or press CTRL+C to exit");
        return findSecondNumber();
    }
    int secondNumber = (number - (number / 100) * 100) / 10;
    return secondNumber;
}

Console.WriteLine("Second number equal {0}.", findSecondNumber());