using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string senha { get; set; }
        public bool Apostei { get; set; }
        public List<Carta> cartas { get; set; } = new List<Carta>();
        

        public void Jogar() 
        {
            Random rand = new Random();
            Carta cartaSorteada = cartas[rand.Next(0, cartas.Count)];
        }

        private int[] metodoDeJogar(Jogador jogadorLocal, int numeroRodada, int idPartida)
        {
            int[] valoresCartaEAposta = { 0, 0 };
            int quantidadeCartas = jogadorLocal.cartas.Count;
            int metadeQuantidadeCartas = quantidadeCartas / 2;

            Random random = new Random();
            ExibirJogadas historicoJogadas = JogoTratado.ExibirJogadas(idPartida, numeroRodada);


            int posicaoCarta = 0;
            if (historicoJogadas == null)
            {
                posicaoCarta = random.Next(0, metadeQuantidadeCartas);
                valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                if (Apostei == false)
                {
                    posicaoCarta = random.Next(metadeQuantidadeCartas, quantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                    valoresCartaEAposta[1] = 4;
                    Apostei = true;
                }
            }
            else
            {
                if (Apostei == false)
                {
                    posicaoCarta = random.Next(metadeQuantidadeCartas, quantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                    valoresCartaEAposta[1] = 4;
                    Apostei = true;
                }

                if (historicoJogadas.valorNaipe < 3)
                {
                    posicaoCarta = random.Next(1, metadeQuantidadeCartas);
                    valoresCartaEAposta[0] = jogadorLocal.cartas[posicaoCarta].posicao;
                }
                else if (historicoJogadas.valorNaipe >= 3 && historicoJogadas.valorNaipe <= 5)
                {
                    posicaoCarta = random.Next(metadeQuantidadeCartas, quantidadeCartas);
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

        public void Jogar(Jogador jogadorLocal, int numeroRodada, int idPartida)
        {
            int[] valoresCartaEAposta = metodoDeJogar(jogadorLocal, numeroRodada, idPartida);
            int indexCarta = valoresCartaEAposta[0];
            int indexAposta = valoresCartaEAposta[1];

            Jogo.Jogar(jogadorLocal.idJogador, jogadorLocal.senha, indexCarta);
            Jogo.Apostar(jogadorLocal.idJogador, jogadorLocal.senha, indexAposta);
        } 

    }
}
