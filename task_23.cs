// Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("задача 23");
Console.Write("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int numb = 1;
while (numb<= n)
{int cub= Convert.ToInt32(Math.Pow(numb, 3));
Console.Write (cub+ ", ");
numb++;

}
