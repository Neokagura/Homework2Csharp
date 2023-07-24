// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

System.Console.WriteLine("add a number of five symbols");
string num= Console.ReadLine();

if (num[0]==num[4]&& num[1]==num[3])
{
    System.Console.WriteLine("It is a palindrome");
}
else
{
    System.Console.WriteLine("This is not a palindrome");
}
