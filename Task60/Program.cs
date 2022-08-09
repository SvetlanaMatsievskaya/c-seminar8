int[, ,] myArray = new int[2,2,2];
for (int i =0; i < myArray.GetLength(0); i++)
{
   for (int j =0; j < myArray.GetLength(1); j++)
   {
    for (int k = 0; k < myArray.GetLength(2); k++)
    {
     myArray[i,j,k] = new Random().Next(100);   
    }
   }
}
for (int i =0; i < myArray.GetLength(0); i++)
{
   for (int j =0; j < myArray.GetLength(1); j++)
   {
    for (int k = 0; k < myArray.GetLength(2); k++)
    {
        Console.Write($"{myArray[i,j,k]}({i},{j},{k})  ");   
    }
    Console.WriteLine();
   }

}
