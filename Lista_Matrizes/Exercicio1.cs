using System;
using BibliotecaMatrizes;
class Exercicio1
{
    public static void Main()
    {
        int linhas, colunas;

        Console.WriteLine("Matrizes");
        Console.WriteLine("Quantidade de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, colunas]; // criando a matriz
        Console.WriteLine("Entre com dados para a matriz");
        Listamatriz.gera(matriz);
        Console.WriteLine("Dados da matriz");
        Listamatriz.mostra(matriz);

        Console.ReadKey();

    }
}
