using System;
using System.IO;


namespace BibliotecaMatrizes
{
    public class matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"Digite para [{i},{j}]");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i

        }// fim leia


        public static void mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mat[i, j],3} |");
                }// fim for j
                Console.WriteLine();
            }// fim for i
        }// fim mostra
        public static void gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    mat[i, j] = random.Next(0, 100);
                }// fim for j
            }// fim for i

        }// fim gera
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
        }//fim de função maior

            static int menorValor(int[,] mat)
            {
                int menor = mat[0, 0];
                int linhas = mat.GetLength(0); //pega as linhas
                int colunas = mat.GetLength(1); //pega colunas
                for (int i = 0; i < linhas; i++)
                    for (int j = 0; j < colunas; j++)
                    {
                        if (mat[i, j] < menor)
                        {
                            menor = mat[i, j];
                        }

                    }// fim for
                return menor;



            }
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
        static int valoresIguais(int[,] ig, int numero)
        {
            int contador = 0;
            int linhas = ig.GetLength(0); //pega as linhas
            int colunas = ig.GetLength(1); //pega colunas
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                {
                    if (ig[i, j] == numero)

                        contador++;
                }
            return contador;
        }
    }
    }
