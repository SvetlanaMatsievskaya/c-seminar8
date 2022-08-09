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
        array[i,j] = new Random().Next(10);
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
int[] C = new int[m]; //массив, где будут собираться суммы каждой строки
for (int i = 0; i < m; i++) //считаем сумму построчно
{
    int Summa = 0;
    for (int j = 0; j < n; j++)
        {
            Summa = Summa + array[i,j];
        }
        C[i]=Summa;
        Summa = 0;
}
for (int i = 0; i < C.Length; i++)
{
    Console.Write($"{C[i]} ");
}
      
Console.WriteLine();
int imin = 0;
int min = 100000;
for (int i = 0; i < m; i++) //ищем минимальный элемент
   {
    if (C[i] < min)
    {
        min = C[i];
        imin = i;
    }
   }         

Console.WriteLine($"{imin+1} строка");         
