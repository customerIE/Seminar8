// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введители количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введители количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,columns];
Random rnd = new Random();
for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array[i,j] = rnd.Next(1,10);
        Console.Write("  " + array[i,j]);
    }
    Console.WriteLine();

}
int Sum(int[,] arr, int row,int col)
{
    int sum = 0;
    for(int j=0; j<col; j++)
    {
        sum = sum + arr[row,j];
    }
    return sum;
}
int minEl = Sum(array, 0, columns);
int minRow = 0;
for(int i=1; i<rows; i++)
{
    if(minEl>Sum(array, i, columns))
    {
        minEl = Sum(array, i, columns);
        minRow = i;
    }
}
Console.WriteLine($"Строка №{minRow+1} с наименьшей суммой элементов = " + minEl);
