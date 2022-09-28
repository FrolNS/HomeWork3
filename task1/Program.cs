/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int reverse (int number)
{
    int rev = 0;
    int lastDigit = 0;
    while (number > 0)
    {
        lastDigit = number % 10;
        rev = rev * 10 + lastDigit;
        number = number / 10;
    }
    return rev;
}
void result (int number, int revNumber)
{
    if (number == revNumber)
    {
        Console.WriteLine("Это палиндром");
    }
    else 
    {
        Console.WriteLine("Это не палиндром");
    }
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int revNumber = reverse(number);
result(number, revNumber);