/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int [,] InitMatrix ()
 {
    int [,] result = new int [2,2];
    Random rnd = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(1,10);
        }
    }
    return result;
 }

 void PrintMatrix (int [,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
           Console.Write($"{matr[i,J]} ") ;
        }
    Console.WriteLine();
    }
    Console.WriteLine();
 }

 void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int [,] FirsMatrix = InitMatrix();
int [,] SecondMatrix = InitMatrix();
 PrintMatrix(SecondMatrix);PrintMatrix(FirsMatrix);
int[,] resultMatrix = new int[2,2];
MultiplyMatrix(FirsMatrix,SecondMatrix,resultMatrix);
PrintMatrix(resultMatrix);