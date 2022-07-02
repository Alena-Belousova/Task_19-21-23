// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

Console.WriteLine("задача 19");
Console.Write("введите пятизначное число: ");
int numb= Convert.ToInt32(Console.ReadLine());
int Digit_1 = numb/10000;
int Digit_5 =numb%10;
int A = numb/1000;
int Digit_2 = A%10;
int N =numb%100;
int Digit_4= N/10;
if (Digit_1==Digit_5&&Digit_2==Digit_4)
{
 Console.WriteLine("да");   
}
else{
   Console.WriteLine("нет");   
}

