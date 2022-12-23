//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет 12821 -> да 23432 -> да
Console.WriteLine("ВВедите 5-и значное число");
int  num=Convert.ToInt32(Console.ReadLine());
string gth=Convert.ToString(num);

    if (gth[0]==gth[4]&&gth[1]==gth[3])
    {
        Console.WriteLine("Yes");
        }

 else
 {
        Console.WriteLine("No");
    }
