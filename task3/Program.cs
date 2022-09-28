/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int[] thirdPow (int number)
{
    int[] result = new int [number];
    for (int i = 1; i <= number; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
}

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] res = thirdPow (number);
var str = string.Join(" ", res);
Console.WriteLine(str);