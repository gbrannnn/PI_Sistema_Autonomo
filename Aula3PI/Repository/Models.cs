using Aula3PI.Repository.Interfaces;

namespace Aula3PI.Repository.Models
{
    public class Apostar : IApostar
    {
        public string valorDaCartaJogada { get; set; }
    }

    public class ConsultarMao : IConsultarMao
    {
        public string idJogador { get; set; }
        public string posicao { get; set; }
        public string naipe { get; set; }
    }

    public class CriarPartida : ICriarPartida
    {
        public int idPartidaCriada { get; set; }
    }

    public class EntrarPartida : IEntrarPartida
    {
        public int idjogadorCriado { get; set; }
        public string senhaGerada { get; set; }
    }

    public class ExibirJogadas : IExibirJogadas
    {
        public int numeroDoRound { get; set; }
        public int idJogador { get; set; }
        public string naipe { get; set; }
        public int valorNaipe { get; set; }
    }

    public class IniciarPartida: IIniciarPartida
    {
        public int idPrimeiroJogador { get; set; }
    }

    public class Jogar : IJogar
    {
        public int valorCartaJogada { get; set; }
    }

    public class ListarJogadoresModel : IListarJogadores
    {
        public int idJogador { get; set; }
        public string nome { get; set; }
        public int pontuacaoAtual { get; set; }
    }

    public class ListarPartidasModel : IListarPartidas
    {
        public int idPartida { get; set; }
        public string nome { get; set; }
        public string dataCriacao { get; set; }
        public string status { get; set; }
    }

    public class VerificarVez : IVerificarVez
    {
        public string statusPartida { get; set; }
        public int idJogadorDaVez { get; set; }
        public int numeroRodada { get; set; }
        public string status { get; set; }
    }
}