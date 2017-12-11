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
                Partidas partida = new Partidas();             

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (tabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }


        
    }
}
