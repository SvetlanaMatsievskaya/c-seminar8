int m = 6;

int [,] array =  new int [m,m];
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j].ToString("00")} "); 
        }
    Console.WriteLine();   
    }
        
}
PrintArray(array);
Console.WriteLine();
int s = 1;
for (int i = 0; i < m/2; i++)
{
    for (int j = i; j < m-i; j++)
    {
         array[i,j] = s;
         s++;
    }
    for (int k = i+1; k < m-i; k++)
    {
        array[k,m-i-1]=s;
        s++;
    }
    for (int l = m-i-2; l >= i; l--)
    {
        array[m-1-i,l]= s;
        s++;
    }
    for (int o = m-2-i; o > i; o--)
    {
        array[o,i] = s;
        s++;
    }
}



PrintArray(array);