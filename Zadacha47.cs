Console.WriteLine("Введите m:");
int m =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n:");
int n =int.Parse(Console.ReadLine()!);

double[,] matrix = new double [m,n];
double[,] CreateMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double x = new Random().NextDouble() ; 

        matrix[i,j] = x * (10-0) + 0; //10 -max, 0-min 
        matrix[i,j] = Math.Round(matrix[i,j],2);

    }
}

    return matrix;
}

void PrintMatrix(double[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
 }
 PrintMatrix(CreateMatrix(matrix));
