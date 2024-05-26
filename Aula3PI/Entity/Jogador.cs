using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Aula3PI.Repository;
using Aula3PI.Repository.Interfaces;
using Aula3PI.Repository.Models;
using MagicTrickServer;

namespace Aula3PI.JogadorEntity
{

    interface IJogador : IListarJogadores 
    {
        string senha { get; set; }
        List<Carta> cartas { get; set; }
    }

    public class Jogador : IJogador
    {
        public int idJogador { get; set; }
        public string nome { get; set; }
        public int pontuacaoAtual { get; set; }
        public int qtdRodadasVencidas { get; set; }
        public string senha { get; set; }
        public bool Apostei { get; set; }
        public List<Carta> cartas { get; set; } = new List<Carta>();

        private int[] metodoDeJogar(Jogador jogadorLocal, int idPartida)
        {
            int[] valoresCartaEAposta = { 0, 0 };
            int quantidadeCartas = jogadorLocal.cartas.Count;
            int metadeQuantidadeCartas = quantidadeCartas / 2;

            Random random = new Random();

            List<ExibirJogadas> historicoJogadas = JogoTratado.ExibirJogadas(idPartida);
            int numeroRound = historicoJogadas.Last().numeroDoRound;
            int ultimaJogada = historicoJogadas.Count == 0 ? 0 : historicoJogadas.Count - 1;
            

            int posicaoCarta = 0;

            if (historicoJogadas.Count == 0)
            {
                posicaoCarta = random.Next(1, metadeQuantidadeCartas);
                valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                if (Apostei == false && numeroRound == 1)
                {
                    posicaoCarta = random.Next(metadeQuantidadeCartas, metadeQuantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                    valoresCartaEAposta[1] = 4;
                    Apostei = true;
                }
            }
            else
            {
                if (Apostei == false && numeroRound == 1)
                {
                    posicaoCarta = random.Next(metadeQuantidadeCartas, metadeQuantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                    valoresCartaEAposta[1] = 4;
                    Apostei = true;
                }

                if (historicoJogadas[ultimaJogada].valorNaipe < 3)
                {
                    for (int i = 1; i < metadeQuantidadeCartas; i++)
                    {
                        Carta cartaEscolhida = jogadorLocal.cartas[i];
                        if (cartaEscolhida.naipe == historicoJogadas[ultimaJogada].naipe)
                        {
                            valoresCartaEAposta[0] = cartaEscolhida.posicao;
                            return valoresCartaEAposta;
                        }
                    }

                    posicaoCarta = random.Next(0, quantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;

                }
                else if (historicoJogadas[ultimaJogada].valorNaipe >= 3 && historicoJogadas[ultimaJogada].valorNaipe <= 5)
                {
                    for (int i = metadeQuantidadeCartas; i < quantidadeCartas; i++)
                    {
                        Carta cartaEscolhida = jogadorLocal.cartas[i];
                        if (cartaEscolhida.naipe == historicoJogadas[ultimaJogada].naipe)
                        {
                            valoresCartaEAposta[0] = cartaEscolhida.posicao;
                            return valoresCartaEAposta;
                        }
                    }
                    posicaoCarta = random.Next(0, quantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                }
                else
                {
                    posicaoCarta = random.Next(0, quantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                }
            }

            return valoresCartaEAposta;
        }

        public void Jogar(Jogador jogadorLocal, int idPartida)
        {
            int[] valoresCartaEAposta = metodoDeJogar(jogadorLocal, idPartida);
            int indexCarta = valoresCartaEAposta[0];
            int indexAposta = valoresCartaEAposta[1];

            string erro = Jogo.Jogar(jogadorLocal.idJogador, jogadorLocal.senha, indexCarta);
            string erro2 = Jogo.Apostar(jogadorLocal.idJogador, jogadorLocal.senha, indexAposta);
        } 

    }
}
