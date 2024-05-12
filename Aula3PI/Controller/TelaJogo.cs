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
        public int round;

        public TelaJogo(int idPartida, Jogador jogadorLocal, Jogador jogadorDaVez, List<Jogador> jogadores)
        {
            this.idPartida = idPartida;
            this.jogadorLocal = jogadorLocal;

            this.jogadores = jogadores;

            if (jogadorDaVez == null)
            {
                int idJogadorDaVez = JogoTratado.VerificarVez(idPartida).idJogadorDaVez;
                this.jogadorDaVez = jogadores.Find(jogador => jogador.idJogador == idJogadorDaVez);
            }
            else
            {
                this.jogadorDaVez = jogadorDaVez;
            }
            InitializeComponent();
            atualizarTela();
        }

        public void atualizarTela()
        {
            VerificarVez informacoesSobreARodada = JogoTratado.VerificarVez(idPartida);
            vezDoJogadorText.Text = Convert.ToString(informacoesSobreARodada.idJogadorDaVez);
            statusPartidaText.Text = informacoesSobreARodada.statusPartida;
            statusDaRodadaTxt.Text = informacoesSobreARodada.statusRodada;
            cartasJogadasList.Items.Clear();
            List<ExibirJogadas> x = JogoTratado.ExibirJogadas(idPartida);
            if (x != null)
            {
                foreach (var item in x)
                {
                    cartasJogadasList.Items.Add($"{item.idJogador} + {item.valorNaipe} + {item.naipe}");
                }
            }
            
            AtribuirCartasParaCadaJogador();
            ListarCartas();
        }

        public List<Panel> CriacaoDePanelsCartas(List<Panel> panels, List<Carta> cartasDoJogadorAtual, int pointX, int pointY)
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

        private void CriarCartasDosJogadoresNaTela(List<Jogador> jogadores, int posicaoJogador, int pointX, int pointY) 
        {
            if (jogadores[posicaoJogador] != null)
            {
                List<Carta> cartasDoJogadorAtual = jogadores[posicaoJogador].cartas;
                CriacaoDePanelsCartas(panels, cartasDoJogadorAtual, pointX, pointY);
                cartasDoJogadorAtual.Clear();
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

            CriarCartasDosJogadoresNaTela(jogadores, 0, 100, 200);
            CriarCartasDosJogadoresNaTela(jogadores, 1, 100, 400);
            //CriarCartasDosJogadoresNaTela(jogadores, 2, 100, 600);
            //CriarCartasDosJogadoresNaTela(jogadores, 3, 100, 800);

            foreach (Panel panel in panels)
            {
                this.Controls.Add(panel);
            }
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
            int numeroRodada = JogoTratado.VerificarVez(idPartida).numeroRodada;

            bool eMinhaVez = idJogadorDaVez == jogadorLocal.idJogador;

            if (eMinhaVez)
            {
                jogadorLocal.Jogar(jogadorLocal, numeroRodada, idPartida);
            }
            atualizarTela();
        }
    }
}
