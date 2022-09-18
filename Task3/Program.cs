// Сформируйте двухмерный массив из неповторяющихся двузначных чисел 
// (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
Console.WriteLine("Введите количество строк");
int rowLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnLength = Convert.ToInt32(Console.ReadLine());
while (rowLength * columnLength >= 50)
{
Console.WriteLine("Ведите масив поменьше до 50 елементов");
Console.WriteLine("Введите количество строк");
rowLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
columnLength = Convert.ToInt32(Console.ReadLine());
}

int[,] array = new int[rowLength,columnLength];
Random random = new();
for (int i = 0; i < rowLength; i++)
{
for (int j = 0; j < columnLength; j++)
{
array[i,j] = CreatUniqueNumber(array,i,columnLength);
Console.Write(array[i,j] + "\t");
}
Console.WriteLine();
}

int CreatUniqueNumber(int[,] array,int iLength,int jLength)
{
int num = random.Next(10,100);
for (int i = 0; i < iLength + 1; i++)
{
for (int j = 0; j < jLength; j++)
{
if (array[i,j] == num)
{
return CreatUniqueNumber(array,iLength,jLength);
}
}
}
return num;
}