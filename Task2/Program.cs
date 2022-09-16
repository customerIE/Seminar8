// Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введители количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введители количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,columns];
int [,] array1 = new int[rows,columns];
int [,] array2 = new int[rows,columns];
Random rnd = new Random();
Console.WriteLine("Массив 1:");
for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array1[i,j] = rnd.Next(1,10);
        Console.Write("  " + array1[i,j]);
    }
    Console.WriteLine();

}
Console.WriteLine("Массив 2:");
for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array2[i,j] = rnd.Next(1,10);
        Console.Write("  " + array2[i,j]);
    }
    Console.WriteLine();

}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
                {
                    array[i,j] += array1[i,k] * array2[k,j];
                }
        }
}
void PrintArray(int[,] arr)
{
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            Console.Write(" " + array[i,j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Произведение двух матриц:");
PrintArray(array);
