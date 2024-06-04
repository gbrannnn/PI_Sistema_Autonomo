using Aula3PI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Aula3PI.Repository.Interfaces
{
    interface IApostar
    {
        string valorDaCartaJogada { get; set; }
    }

    interface IConsultarMao
    {
        string idJogador { get; set; }
        string posicao { get; set; }
        string naipe { get; set; }

    }

    interface ICriarPartida
    {
        int idPartidaCriada { get; set; }

    }

    interface IEntrarPartida
    {
        int idjogadorCriado { get; set; }
        string senhaGerada { get; set; }
        string erro { get; set; }
    }


    interface IExibirJogadas
    {
        int numeroDoRound { get; set; }
        int idJogador { get; set; }
        string naipe { get; set; }
        int valorNaipe { get; set; }
    }

    interface IIniciarPartida
    {
        int idPrimeiroJogador { get; set; }
        string erro { get; set; }
    }

    interface IJogar
    {
        int valorCartaJogada { get; set; }
    }

    interface IListarJogadores
    {
        int idJogador { get; set; }
        string nome { get; set; }
        int pontuacaoAtual { get; set; }
        int qtdRodadasVencidas { get; set; }
    }


    interface IListarPartidas
    {
        int idPartida { get; set; }
        string nome { get; set; }
        string dataCriacao { get; set; }
        string status { get; set; }

    }

    interface IVerificarVez
    {
        string statusPartida { get; set; }
        int idJogadorDaVez { get; set; }
        int numeroRodada { get; set; }
        string statusRodada { get; set; }
    }
}
