using System;
using tabuleiro;
using xadrez01;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (tabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }


        
    }
}
