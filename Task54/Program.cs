int m = 0;
int n = 0;
Console.Write("Введите количество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите количество столбцов: ");
int.TryParse(Console.ReadLine(), out n);
int[,] array = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j<n; j++)
    {
        array[i,j] = new Random().Next(100);
    }
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} "); 
        }
    Console.WriteLine();   
    }
        
}
PrintArray(array);
Console.WriteLine();
void RankArray (int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = array.GetLength(1)-1; j > 0 ; j--)
    {
        for (int k = 0; k < j; k++)
        {
            if (array[i,k] < array [i,k+1])
            {
                int buffer = array[i,k+1];
                array[i,k+1] = array[i,k];
                array[i,k] = buffer;
            }
               
            
        }
    }
   } 
}


RankArray(array);
PrintArray(array);