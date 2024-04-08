using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula3PI.Repository;
using Aula3PI.Repository.Interfaces;

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

    }
}
