// Сформируйте двухмерный массив из неповторяющихся двузначных чисел 
// (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
// ----Создание массива----
Console.Write("Введители количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введители количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,columns];
//-------------------------
//----Создаем массив случайных чисел----
Random rnd = new Random();
int Contains(int[,] arr)
{
    int element = 0;
    bool contains = false;
    do
    {        
        int temp = rnd.Next(10,99);
        for(int k=0; k<rows; k++ )
        {
            for(int m=0; m<columns; m++)
            {
                if (array[k,m] == temp)
                {
                    contains = true;
                    break;
                }
            }
        }
        element = temp;
    }while(contains);
    return element;
}        
//-------------------------
for (int i = 0; i < rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array[i,j] = Contains(array);
    }    
}              
for(int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
}





