using System;
class Program
{
    static double[,] Inversa2x2(double[,] matriz)
    {
        double determinante = matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
        if (determinante == 0)
        {
            Console.WriteLine("La matriz no tiene inversa.");
            return null;
        }
        double[,] inversa = new double[2, 2];
        inversa[0, 0] = matriz[1, 1] / determinante;
        inversa[0, 1] = -matriz[0, 1] / determinante;
        inversa[1, 0] = -matriz[1, 0] / determinante;
        inversa[1, 1] = matriz[0, 0] / determinante;
        return inversa;
    }
    static void MostrarMatriz(double[,] matriz)
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