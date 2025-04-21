using System.Runtime.CompilerServices;
int year;
Console.WriteLine("Enter a year to check if it is a leap year.");
year = Convert.ToInt32(Console.ReadLine());

void IfYearIsLeap()
{

    if (year % 4 == 0 && year % 100 != 0)
    {
        Console.WriteLine("This is a leap year.");
    }
    else if (year % 400 == 0)
    {
        Console.WriteLine("This is a leap year.");
    }
    else
    {
        Console.WriteLine("This is not a leap year.");
    }
}

IfYearIsLeap();