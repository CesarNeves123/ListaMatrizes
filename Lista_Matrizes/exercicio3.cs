using System;
using BibliotecaMatrizes;

    public class exercicio3
    {
    static int valoresIguais(int[,] ig, int numero)
    { int contador = 0;
        int linhas = ig.GetLength(0); //pega as linhas
        int colunas = ig.GetLength(1); //pega colunas
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < colunas; j++)
            { 
                if (ig[i, j] == numero )
                    
                contador++;
            }
        return contador;
            }
    public static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("Digite a quantidade de linhas da matriz");
        linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de colunas da matriz");
        colunas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero que voce quer ver se esta na matriz");
        int numero = int.Parse(Console.ReadLine());
        int[,] matrix = new int[linhas, colunas]; //criando a matriz
        matriz.gera(matrix);
        matriz.mostra(matrix);
        Console.WriteLine("Matriz gerada: ");
        matriz.mostra(matrix);
        int contador = valoresIguais(matrix,numero);
        Console.WriteLine($"\nO numero {numero} aparece {contador} vezes na matriz:");

        Console.ReadKey();






    }
}
   

