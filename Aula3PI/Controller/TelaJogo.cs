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
        public List<Panel> panels = new List<Panel>();

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

        public List<Panel> CriacaoPanelsCartas(List<Panel> panels, List<Carta> cartasDoJogadorAtual, int pointX, int pointY)
        {
            Point point = new Point(pointX, pointY);
            Size size = new Size(60, 100);

            for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
            {
                Panel painelCarta = new Panel();
                point.X = point.X + (size.Width + 10);
                painelCarta.Location = point;
                painelCarta.Size = size;
                painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                panels.Add(painelCarta);
            }
            return panels;
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

            if(panels != null)
            {
                foreach(Panel panel in panels)
                {
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
                panels.Clear();
            }


            if (jogadores[0] != null) 
            {
                Point point = new Point(100, 30);
                Size size = new Size(60, 100);
                List<Carta> cartasDoJogadorAtual = jogadores[0].cartas;

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Panel painelCarta = new Panel();
                    point.X = point.X + (size.Width + 10);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    panels.Add(painelCarta);
                }
            }

            if (jogadores[1] != null)
            {
                Point point = new Point(100, 300);
                Size size = new Size(60, 100);
                List<Carta> cartasDoJogadorAtual = jogadores[1].cartas;

                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    Panel painelCarta = new Panel();
                    point.X = point.X + (size.Width + 10);
                    painelCarta.Location = point;
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    panels.Add(painelCarta);
                }
            }

            foreach(Panel panel in panels)
            {
                this.Controls.Add(panel);
            }

        }
        private void ListarCartas()
        {
            if (panels != null)
            {
                foreach (Panel panel in panels)
                {
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
                panels.Clear();
            }

            if (jogadores[0] != null)
            {
                int pointX = 100;
                int pointY = 30;
                List<Carta> cartasDoJogadorAtual = jogadores[0].cartas;
                CriacaoPanelsCartas(panels, cartasDoJogadorAtual, pointX, pointY);
                cartasDoJogadorAtual.Clear();
            }

            if (jogadores[1] != null)
            {
                int pointX = 100;
                int pointY = 300;
                List<Carta> cartasDoJogadorAtual = jogadores[1].cartas;
                CriacaoPanelsCartas(panels, cartasDoJogadorAtual, pointX, pointY);
                cartasDoJogadorAtual.Clear();
            }

            foreach (Panel panel in panels)
            {
                this.Controls.Add(panel);
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
