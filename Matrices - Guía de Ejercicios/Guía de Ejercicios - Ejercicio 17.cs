class Program
{
    static double[,] MultiplicarMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz2.GetLength(1);
        int comun = matriz1.GetLength(1);
        double[,] resultado = new double[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = 0;

                for (int k = 0; k < comun; k++)
                {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }
        return resultado;
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