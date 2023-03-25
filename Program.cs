// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задание 47

/*Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
double[,] Massiv = new double[stroka, stolbez];

FillMassiv();
PrintMassiv();

void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
        {
            Massiv[i,j] = Math.Round((new Random().NextDouble()) * 100, 2, MidpointRounding.AwayFromZero);
            if (new Random().Next(1, 99) > 49)
            {
                Massiv [i,j] = Massiv[i,j] * -1;
            }
        }    
    }
}

void PrintMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
            Console.Write($"{Massiv[i, j]} ");
            Console.WriteLine();
    }
}*/
// Задание 50

/*Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
Console.WriteLine("Введите число которое хотите найти");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
bool Sovpadenie = false;

FillMassiv();
PrintMassiv();
Console.WriteLine("");
Poisk();

void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 10);
        
}

void PrintMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
            Console.Write($"{Massiv[i, j]} ");
            Console.WriteLine();
    }
}

void Poisk()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
        {
            if (Massiv[i,j] == Number)
            {
                Sovpadenie = true;
                Console.WriteLine($"{i}, {j}");
            }
            // else
            // {
            //     Console.WriteLine("Такого числа нет");
            // }
        }
    }
    if (Sovpadenie)
    {

    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}*/
// Задача 52

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
double[] Massiv1 = new double[stolbez];
double SredAriph = 0;
Console.WriteLine("");

FillMassiv();
PrintMassiv();
Console.WriteLine("");
SredAriphStolbza();
PrintMassiv1(Massiv1);

void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 10);

}

void PrintMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
            Console.Write($"{Massiv[i, j]} ");
        Console.WriteLine();
    }
}

void SredAriphStolbza()
{
    for (int j = 0; j < stolbez; j++)
    {
        for (int i = 0; i < stroka; i++)
        {
            SredAriph = SredAriph + Massiv[i, j];
        }
        SredAriph = SredAriph / stroka;
        Massiv1[j] = SredAriph;
        SredAriph = 0;
    }
}

void PrintMassiv1(double [] Massiv1)
{
    for (int j = 0; j < stolbez; j++)
        Console.Write($"{Massiv1[j]} ");
    Console.WriteLine();
}