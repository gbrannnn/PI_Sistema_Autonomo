using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula3PI.Properties;
using MagicTrickServer;
using utils;
using Aula3PI.JogadorEntity;
using Aula3PI.Repository;
using Aula3PI.Repository.Models;
using System.Runtime.CompilerServices;

namespace Aula3PI
{

    public partial class TelaJogo : Form
    {
        public int idPartida;
        public Jogador jogadorLocal;
        public Jogador jogadorDaVez;
        public List<Jogador> jogadores;
        public List<Carta> cartasJogadas;

        public TelaJogo(int idPartida, Jogador jogadorLocal, Jogador jogadorDaVez, List<Jogador> jogadores)
        {
            this.idPartida = idPartida;
            this.jogadorLocal = jogadorLocal;
            this.jogadorDaVez = jogadorDaVez;
            this.jogadores = jogadores;

            InitializeComponent();
            atualizarTela();
        }
        
        public void atualizarTela()
        {
            VerificarVez informacoesSobreARodada = JogoTratado.VerificarVez(idPartida);
            vezDoJogadorText.Text = Convert.ToString(informacoesSobreARodada.idJogadorDaVez);
            statusPartidaText.Text = informacoesSobreARodada.statusPartida;
            statusDaRodadaTxt.Text = informacoesSobreARodada.statusRodada;
            AtribuirCartasParaCadaJogador();
            ListarCartas();
        }

        private void btnSairPartida_Click(object sender, EventArgs e)
        {
            DialogResult mensagemBoxRetorno = MessageBox.Show("Tem certeza que deseja retonar ao Lobby?"
                                              , "Aviso"
                                              , MessageBoxButtons.YesNo
                                              , MessageBoxIcon.Question);

            if (mensagemBoxRetorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void AtribuirCartasParaCadaJogador() 
        {
            List<Carta> cartas = JogoTratado.ConsultarMao(Convert.ToInt32(idPartida), jogadores);
            jogadorLocal.cartas = cartas.FindAll(carta => carta.idJogador == jogadorLocal.idJogador);
        }

        private void bntListarCartas_Click(object sender, EventArgs e)
        {
            int width = 60;
            int height = 100;

            if (jogadores[0] != null) 
            {
                List<Carta> cartasDoJogadorAtual = jogadores[0].cartas;
                Panel painelCarta = new Panel();
                painelCarta.Controls.Clear();

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Point point = new Point(100 + (width * i) + 20, 30);
                    Size size = new Size(width, height);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    this.Controls.Add(painelCarta);
                }  
            }

            if (jogadores[1] != null)
            {
                List<Carta> cartasDoJogadorAtual = jogadores[1].cartas;
                Panel painelCarta = new Panel();
                painelCarta.Controls.Clear();

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Point point = new Point(100 + (width * i + 10), 300);
                    Size size = new Size(width, height);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    this.Controls.Add(painelCarta);
                }
            }

            this.atualizarTela();
        }
        private void ListarCartas()
        {
            int width = 60;
            int height = 100;

            if (jogadores[0] != null)
            {
                List<Carta> cartasDoJogadorAtual = jogadores[0].cartas;
                Panel painelCarta = new Panel();
                painelCarta.Controls.Clear();

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Point point = new Point(100 + (width * i) + 20, 30);
                    Size size = new Size(width, height);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    this.Controls.Add(painelCarta);
                }
            }

            if (jogadores[1] != null)
            {
                List<Carta> cartasDoJogadorAtual = jogadores[1].cartas;
                Panel painelCarta = new Panel();
                painelCarta.Controls.Clear();

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Point point = new Point(100 + (width * i + 10), 300);
                    Size size = new Size(width, height);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    this.Controls.Add(painelCarta);
                }
            }
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            string valorCarta = Jogo.Jogar(jogadorLocal.idJogador, jogadorLocal.senha, Convert.ToInt32(txtIdCarta.Text));
            lblCartaJogada.Text = valorCarta;
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            
            string valorAposta = Jogo.Apostar(jogadorLocal.idJogador, jogadorLocal.senha, Convert.ToInt32(txtIdAposta.Text));
            lblCartaAposta.Text = valorAposta;

            int idProximoJogador = JogoTratado.VerificarVez(this.idPartida).idJogadorDaVez;
            this.jogadorDaVez = jogadores.Find(jogador => jogador.idJogador == idProximoJogador);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int idJogadorDaVez = JogoTratado.VerificarVez(idPartida).idJogadorDaVez;
            bool eMinhaVez = idJogadorDaVez == jogadorLocal.idJogador;

            if (eMinhaVez)
            {
                Random random = new Random();
                // For now it will always by zero but we need to visit this logic again to decide better
                int numeroAposta = 0;
                string payload;
                do {
                    int numeroDaCartaPraSerJogada = random.Next(1, jogadorLocal.cartas.Count);
                    Jogo.Jogar(jogadorLocal.idJogador, jogadorLocal.senha, numeroDaCartaPraSerJogada);
                    payload = Jogo.Apostar(jogadorLocal.idJogador, jogadorLocal.senha, 0);
                    
                } while (payload.StartsWith("E"));

            }
            atualizarTela();
        }
    }
}
