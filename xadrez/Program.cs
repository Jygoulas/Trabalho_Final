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

                while (!partida.terminada)
                {
                    try {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaodestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(tabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (tabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }


        
    }
}
