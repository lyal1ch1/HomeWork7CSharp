// Console.WriteLine("Введите m:");
// int m =int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n:");
// int n =int.Parse(Console.ReadLine()!);

// double[,] matrix = new double [m,n];
// double[,] CreateMatrix(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double x = new Random().NextDouble() ; 

//         matrix[i,j] = x * (10-0);
//         matrix[i,j] = Math.Round(matrix[i,j],2);

//     }
// }

//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
//  {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//  }
//  PrintMatrix(CreateMatrix(matrix));
////////////////////////////////////////////////////////////////
// Console.WriteLine("Введите m:");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n:");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = new int[m, n];
// int[,] CreateMatrix(int m, int n)
// {


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 101);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// CreateMatrix(m, n);
// matrix = CreateMatrix(m, n);
// PrintMatrix(matrix);
// bool a = false;
// Console.WriteLine("Чтобы проверить элемент, введите номер строки:");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Теперь номер столбца:");
// int y = int.Parse(Console.ReadLine()!);

// void FindNumberOfMatrix()
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             if (i == x-1 && j == y-1)
//             {
//                 Console.WriteLine("В этой ячейке лежит:" + matrix[i, j]);
                
//                 a = true;
//             }


//         }
//     }
//     if (a == false)
//     {

//         Console.WriteLine("Такого элемента нет!");
//     }
// }
// FindNumberOfMatrix();
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[m, n];
double[] array = new double[n];
double[,] CreateMatrix(int m, int n)
{
            


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
CreateMatrix(m, n);
matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
double[] FillArray()
{
   double sum = 0; 
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        
        // sum = sum + matrix[i,j];
        // array[j] = matrix[i,j];
        // j++;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           
         sum = sum + matrix[j,i];   
        }
        array[i] = Math.Round(sum/m, 2);
        sum=0;
    }
    return array;
}
void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ") ;
    }
}
FillArray();
Console.WriteLine();
PrintArray();

