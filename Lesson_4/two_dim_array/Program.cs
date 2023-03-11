//Console.WriteLine("Hello, World!");
//string[,] table = new string[2, 3];
//table[1, 2] = "davy";

// void PrintTable(string[,] MyTable)
/* {
    for (int i = 0; i < MyTable.GetLength(0); i++)
    {
        for (int j = 0; j < MyTable.GetLength(1); j++)
        {
            Console.WriteLine($"-{MyTable[i, j]}-");
        }
    }
} */
//PrintTable(table);


int[,] matrix = new int[8, 10];

void PrintMatrix(int[,] MyMatrix)
{
for (int i = 0; i < MyMatrix.GetLength(0); i++)
{
   for (int j = 0; j < MyMatrix.GetLength(1); j++)
   {
    Console.Write($"{matrix[i, j]} ");
   } 
   Console.WriteLine();
}
}

void FullMatrix(int[,] MyMat)
{
    for (int row = 0; row < MyMat.GetLength(0); row++)
    {
        for (int col = 0; col < MyMat.GetLength(1); col++)
        {
           MyMat[row,col] = new Random().Next(1,10);
        }
    }
}


PrintMatrix(matrix);
Console.WriteLine();
FullMatrix(matrix);
PrintMatrix(matrix);

