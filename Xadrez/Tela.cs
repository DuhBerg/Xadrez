using System;
using tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int x = 0; x < tab.Colunas; x++)
                {
                    if (tab.peca(i, x) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, x) + " ");
                    }

                }
                Console.WriteLine();
            }


        }
    }


}

