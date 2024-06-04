using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicTrickServer;
using Aula3PI.Repository.Models;
using Aula3PI.Repository.Interfaces;
using utils;
using Aula3PI.JogadorEntity;

namespace Aula3PI.Repository
{
    class JogoTratado
    {   
        static public List<Carta> ConsultarMao(int idPartida, List<Jogador> jogadores)
        {
            string[] cartas = Utils.tratarRetornoDoBanco(Jogo.ConsultarMao(idPartida));
            List<Carta> listaCartas = new List<Carta>();

            foreach (Jogador jogador in jogadores)
            {
                jogador.cartas.Clear();
            }

            foreach (string carta in cartas)
            {
                string[] auxCarta = carta.Split(',');
                Carta Temp = new Carta();
                Temp.idJogador = Convert.ToInt32(auxCarta[0]);
                Temp.posicao = Convert.ToInt32(auxCarta[1]);
                Temp.naipe = auxCarta[2];


                switch (Temp.naipe)
                {
                    case "C": Temp.background = Properties.Resources.Copas1; break;
                    case "E": Temp.background = Properties.Resources.Espadas1; break;
                    case "L": Temp.background = Properties.Resources.Lua1;break;
                    case "O": Temp.background = Properties.Resources.Ouros1; break;
                    case "P": Temp.background = Properties.Resources.Paus1; break;
                    case "S": Temp.background = Properties.Resources.Estrela1; break;
                    case "T": Temp.background = Properties.Resources.Triângulo1; break;
                    default: break;
                }


                int indexJogadorPraReceberACarta = jogadores.IndexOf(jogadores.Find(x => x.idJogador == Temp.idJogador));
                jogadores[indexJogadorPraReceberACarta].cartas.Add(Temp);

                listaCartas.Add(Temp);
            }
            return listaCartas;
        }

        static public EntrarPartida EntrarPartida(int idPartida, string nome, string senha)
        {
            string[] x = Jogo.EntrarPartida(idPartida, nome, senha).Split(',');
            EntrarPartida TempModel = new EntrarPartida();
            if (x[0].Substring(0, 4) == "ERRO")
            {
                TempModel.erro = x[0];
                return TempModel;
            }

            TempModel.erro = "sem erro";
            TempModel.idjogadorCriado = Convert.ToInt32(x[0]);
            TempModel.senhaGerada = x[1];

            return TempModel;
        }

        static public IniciarPartida IniciarPartida(int idJogador, string senhaJogador) 
        {
            string idPrimeiroJogador = Jogo.IniciarPartida(idJogador, senhaJogador);
            IniciarPartida TempModel = new IniciarPartida();
            if (idPrimeiroJogador.Substring(0, 4) == "ERRO")
            {
                TempModel.erro = idPrimeiroJogador;
                return TempModel;
            }
            TempModel.erro = "sem erro";
            TempModel.idPrimeiroJogador = Convert.ToInt32(idPrimeiroJogador);
            return TempModel;
        }

        static public List<Jogador> ListarJogadores(int idPartida)
        {
            string[] retornoDoBanco = Utils.tratarRetornoDoBanco(Jogo.ListarJogadores2(idPartida));
            List<Jogador> jogadores = new List<Jogador>();

            foreach(string jogador in retornoDoBanco)
            {
                Jogador TempModel = new Jogador();
                string[] aux = jogador.Split(',');
                TempModel.idJogador = Convert.ToInt32(aux[0]);
                TempModel.nome = aux[1];
                TempModel.pontuacaoAtual = Convert.ToInt32(aux[2]);
                TempModel.qtdRodadasVencidas = Convert.ToInt32(aux[3]);
                jogadores.Add(TempModel);
            }
            return jogadores;
        }

        static public List<ListarPartidasModel> ListarPartidas(string statusDaPartida) 
        {
            List<ListarPartidasModel> partidasTratadas = new List<ListarPartidasModel>();
            string[] partidas = Utils.tratarRetornoDoBanco(Jogo.ListarPartidas(statusDaPartida));
            
            for(int i = 0; i < partidas.Length; i++)
            {
                ListarPartidasModel TempModel = new ListarPartidasModel();
                string[] x = partidas[i].Split(',');

                TempModel.idPartida = Convert.ToInt32(x[0]);
                TempModel.nome = x[1];
                TempModel.dataCriacao = x[2];
                TempModel.status = x[3];
                
                partidasTratadas.Add(TempModel);
            }
            return partidasTratadas;
        }

        static public VerificarVez VerificarVez(int idPartida) 
        {
            string[] informacoesDaRodadaAtual = Utils.tratarRetornoDoBanco(Jogo.VerificarVez2(idPartida))[0].Split(',');

            VerificarVez payload = new VerificarVez();
            payload.statusPartida = informacoesDaRodadaAtual[0];
            payload.idJogadorDaVez = Convert.ToInt32(informacoesDaRodadaAtual[1]);
            payload.numeroRodada = Convert.ToInt32(informacoesDaRodadaAtual[2]);
            payload.statusRodada = informacoesDaRodadaAtual[3];
            return payload;
        }
        static public List<ExibirJogadas> ExibirJogadas(int idPartida)
        {
            string[] jogadasDaRodada;
            List<ExibirJogadas> payload = new List<ExibirJogadas>();
            string[] retornoDoBanco = Utils.tratarRetornoDoBanco(Jogo.ExibirJogadas(idPartida));

            if (retornoDoBanco != null)
            {
                for (int i = 0; i < retornoDoBanco.Length; i++)
                {
                    jogadasDaRodada = retornoDoBanco[i].Split(',');
                    ExibirJogadas temp = new ExibirJogadas();
                    temp.numeroDoRound = Convert.ToInt32(jogadasDaRodada[0]);
                    temp.idJogador = Convert.ToInt32(jogadasDaRodada[1]);
                    temp.naipe = jogadasDaRodada[2];
                    temp.valorNaipe = Convert.ToInt32(jogadasDaRodada[3]);
                    payload.Add(temp);
                }
            }

            return payload;

        }

        static public List<ExibirJogadas> ExibirJogadas(int idPartida, int numeroRodada)
        {
            string[] jogadasDaRodada;
            List<ExibirJogadas> payload = new List<ExibirJogadas>();
            string[] retornoDoBanco = Utils.tratarRetornoDoBanco(Jogo.ExibirJogadas2(idPartida, numeroRodada));

            if (retornoDoBanco != null)
            {
                if (retornoDoBanco[0].Substring(0, 4) == "ERRO")
                {
                    return null;
                }

                for (int i = 0; i < retornoDoBanco.Length; i++)
                {
                    jogadasDaRodada = retornoDoBanco[i].Split(',');
                    ExibirJogadas temp = new ExibirJogadas();
                    temp.numeroDoRound = Convert.ToInt32(jogadasDaRodada[0]);
                    temp.idJogador = Convert.ToInt32(jogadasDaRodada[1]);
                    temp.naipe = jogadasDaRodada[2];
                    temp.valorNaipe = Convert.ToInt32(jogadasDaRodada[3]);
                    payload.Add(temp);
                }
            }

            return payload;
        }

    }
}
