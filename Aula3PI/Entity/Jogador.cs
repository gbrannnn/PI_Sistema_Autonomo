using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula3PI.Repository;
using Aula3PI.Repository.Interfaces;
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
        public List<Carta> cartas { get; set; } = new List<Carta>();
        

        public void Jogar() 
        {
            Random rand = new Random();
            Carta cartaSorteada = cartas[rand.Next(0, cartas.Count)];
        }

        private int[] metodoDeJogar(Jogador jogadorLocal, int numeroRodada, int idPartida)
        {
            int[] valoresCartaEAposta = { 0, 0 };
            Random random = new Random();

            int valorCarataJogada = 0;
            if (JogoTratado.ExibirJogadas(idPartida).valorNaipe != null)
            {
                valorCarataJogada = JogoTratado.ExibirJogadas(idPartida).valorNaipe;
            }

            //Estratégia para jogar
            if (valorCarataJogada > 3)
            {
                valoresCartaEAposta[0] = random.Next(5, jogadorLocal.cartas.Count);
            }
            else
            {
                valoresCartaEAposta[0] = random.Next(0, 5);
            }


            //Estratégia para aposta
            if (numeroRodada == 2)
            {
                valoresCartaEAposta[1] = random.Next(4, 9); 
            }

            return valoresCartaEAposta;
        }

        public string Jogar(Jogador jogadorLocal, int numeroRodada, int idPartida)
        {
            int[] valoresCartaEAposta = metodoDeJogar(jogadorLocal, numeroRodada, idPartida);
            int indexCarta = valoresCartaEAposta[0];
            int indexAposta = valoresCartaEAposta[1];

            Jogo.Jogar(jogadorLocal.idJogador, jogadorLocal.senha, indexCarta);
            return Jogo.Apostar(jogadorLocal.idJogador, jogadorLocal.senha, indexAposta);
        } 

    }
}
