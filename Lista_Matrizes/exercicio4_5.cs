using System;
using BibliotecaMatrizes;
class Exercicio_4_e_5
{
    static void diagonalPrincipal(int[,] mat)
    {
      
        int linhas = mat.GetLength(0);
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{mat[i, i]}|");
            Console.WriteLine();
        }
        
    }
    
    static void diagonalSecundaria(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        int j = colunas - 1;

        for (int i = 0; i < linhas; i++, j--)
        
            Console.Write($"{mat[i, j]}|");
            
            Console.WriteLine();
        }

    public static void Main()
    {
         int linhas, colunas;
         Console.WriteLine("Digite a quantidade de linhas e colunas da matriz");
         linhas = int.Parse(Console.ReadLine());        
         colunas = int.Parse(Console.ReadLine());
         if (linhas == colunas) ;
         int[,] matrix = new int[linhas, colunas]; //criando a matriz
         matriz.gera(matrix);
         Console.WriteLine("Matriz gerada: ");
         matriz.mostra(matrix);
        Console.Write($"Diagonal principal:");
        diagonalPrincipal(matrix);
        Console.Write($"Diagonal secundaria:");
        diagonalSecundaria(matrix);
}
}
