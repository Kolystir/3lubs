// 3 лаба по ЧМ
Console.WriteLine("_________________________РЕШИТЬ СИСТЕМУ ЛИНЕЙНЫХ УРАВНЕНИЙ___________________________________");
Console.Write("Введите кол-во чисел после запятой: ");
int zap = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Вот так будет выглядеть ваша матрица: ");
Console.WriteLine("A11 A12 A13");
Console.WriteLine("A21 A22 A23");
Console.WriteLine("A31 A32 A33");
Console.WriteLine("");
double[] matrica = new double[9];
int n = 0;
int f = 0;



for (int i = 0; i < 9; i++)
{
	if (i >= 0 && i <=2)
	{
		Console.Write($"A1{i+ 1} = ");
        matrica[i] = Convert.ToDouble(Console.ReadLine());

    }
    if (i >= 3 && i <= 5)
    {
        Console.Write($"A2{n + 1} = ");
        matrica[i] = Convert.ToDouble(Console.ReadLine());
        n++;
    }
    if (i >= 6 && i <= 9)
    {
        Console.Write($"A3{f + 1} = ");
        matrica[i] = Convert.ToDouble(Console.ReadLine());
        f++;
    }

}
Console.WriteLine("________________Вот твоя матрица_____________________");

for (int i = 0; i < 9; i++)
{
    if (i >= 0 && i <= 2)
    {
        Console.Write($"A1{i + 1} =" + matrica[i] +" ");
    }
    if (i == 3)
    {
        Console.WriteLine();
    }
    if (i >= 3 && i <= 5)
    {
        Console.Write($"A2{n + 1} =" + matrica[i] + " ");
        n++;
    }
    if (i == 6)
    {
        Console.WriteLine();
    }
    if (i >= 6 && i <= 9)
    {
        Console.Write($"A3{f + 1} =" + matrica[i] + " ");
        f++;
    }

}
