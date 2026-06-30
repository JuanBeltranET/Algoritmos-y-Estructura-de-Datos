using System;
class Program
{
    static void RotarDerecha(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int ultimo = matriz[filas - 1, columnas - 1];
        for (int i = filas - 1; i >= 0; i--)
        {
            for (int j = columnas - 1; j >= 0; j--)
            {
                if (i == 0 && j == 0)
                {
                    matriz[i, j] = ultimo;
                }
                else if (j == 0)
                {
                    matriz[i, j] = matriz[i - 1, columnas - 1];
                }
                else
                {
                    matriz[i, j] = matriz[i, j - 1];
                }
            }
        }
    }
    static void MostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}