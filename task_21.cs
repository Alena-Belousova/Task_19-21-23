// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между
// ними в 3D пространстве.
Console.WriteLine("задача 21");
Console.Write("введите значение Х_А: ");
int x_A= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение Y_А: ");
int y_A= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение Z_А: ");
int z_A= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение Х_В: ");
int x_B= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение Y_В: ");
int y_B= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение Z_В: ");
int z_B= Convert.ToInt32(Console.ReadLine());
//расстояние_от_точки_1_до_точки_2=(((x2-x1)^2)+((y2-y1)^2)+((z2-z1)^2))^0.5
int long_X =x_B- x_A;
int long_Y =y_B- y_A;
int long_Z =z_B- z_A;
int i_X = Convert.ToInt32(Math.Pow(long_X, 2));//(x2-x1)^2
int i_Y = Convert.ToInt32(Math.Pow(long_Y, 2));//(y2-y1)^2
int i_Z = Convert.ToInt32(Math.Pow(long_Z, 2));//(z2-z1)^2
int summ = i_X + i_Y + i_Z;//((x2-x1)^2)+((y2-y1)^2)+((z2-z1)^2)
double itog = Convert.ToDouble(Math.Sqrt(summ)); //корень от большого выражения
double long_itog = Math.Round(itog, 2);

Console.WriteLine("длинна отрезка = " + long_itog);


