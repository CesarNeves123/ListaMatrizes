using System;
using BibliotecaMatrizes;

public class Exercicio6
{
    static int[,] SomaMatrizes(int[,] mat, int[,] mat2)
    {
        int linhas = mat.GetLength(0); // pega as linhas
        int colunas = mat.GetLength(1); // pega as colunas
        int[,] soma = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma[i, j] = mat[i, j] + mat2[i, j];
            }
        }

        return soma;
    }

    public static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("Digite a quantidade de linhas da matriz:");
        linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de colunas da matriz:");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz1 = new int[linhas, colunas]; // criando a matriz
        matriz.gera(matriz1); // Gera a matriz
        Console.WriteLine("Matriz 1 gerada:");
        matriz.mostra(matriz1); // Mostra a matriz

        int[,] matriz2 = new int[linhas, colunas]; // criando a matriz
        matriz.gera(matriz2); // Gera a matriz
        Console.WriteLine("Matriz 2 gerada:");
        matriz.mostra(matriz2); // Mostra a matriz

        int[,] soma = SomaMatrizes(matriz1, matriz2);
        
        Console.WriteLine("A soma das matrizes é:");
        matriz.mostra(soma);


        Console.ReadKey();
    }
}
