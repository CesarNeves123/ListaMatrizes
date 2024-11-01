using System;
using BibliotecaMatrizes;
class Exercicio_1_e_2
{
    static int maiorValor(int[,] mat)
    {
        int maior = mat[0, 0];
        int linhas = mat.GetLength(0); //pega as linhas
        int colunas = mat.GetLength(1); //pega colunas
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < colunas; j++)
            {
                if (mat[i, j] > maior)
                {
                    maior = mat[i, j];
                }

            }// fim for
        return maior;
        //fim de função maior
    }
        static int menorValor(int[,] mat)
        {
            int menor = mat[0, 0];
            int linhas = mat.GetLength(0); //pega as linhas
            int colunas = mat.GetLength(0); //pega colunas
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] < menor)
                    {
                        menor = mat[i, j];
                    }

                }// fim for
            return menor;

        }// fim função menor
    
    public static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("Digite a quantidade de linhas da matriz");
        linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de colunas da matriz");
        colunas = int.Parse(Console.ReadLine());
        int[,] matrix = new int[linhas, colunas]; //criando a matriz
        matriz.gera(matrix);
        Console.WriteLine("Matriz gerada: ");
        matriz.mostra(matrix);
        int menor = menorValor(matrix);
        int maior = maiorValor(matrix);
        Console.WriteLine($"\nO maior vetor é {maior}:");

        Console.WriteLine($"\n O menor vetor é:{menor}:");
        
        Console.ReadKey();






    }
}