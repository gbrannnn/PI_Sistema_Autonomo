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
        //Revisitar essa lógica 
        public void atualizarTela()
        {
            VerificarVez informacoesSobreARodada = JogoTratado.VerificarVez(idPartida);

            vezDoJogadorText.Text = Convert.ToString(informacoesSobreARodada.idJogadorDaVez);
            statusPartidaText.Text = informacoesSobreARodada.statusPartida;
            statusDaRodadaTxt.Text = informacoesSobreARodada.statusRodada;
            lblPontuaçãoJogador1.Text = jogadorLocal.pontuacaoAtual.ToString();
            lblPontuaçãoJogador2.Text = jogadores[1].pontuacaoAtual.ToString();
            cartasJogadasList.Items.Clear();
            /*
            List<ExibirJogadas> x = JogoTratado.ExibirJogadas(idPartida);
            if (x != null)
            {
                foreach (var item in x)
                {
                    cartasJogadasList.Items.Add($"{item.idJogador} + {item.valorNaipe} + {item.naipe}");
                }
            }
            */
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
            List<Carta> cartasDoJogadorAtual = jogadores[posicaoJogador].cartas;
            CriacaoDePanelsCartas(panels, cartasDoJogadorAtual, pointX, pointY);
            cartasDoJogadorAtual.Clear();
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

            switch (jogadores.Count)
            {
                case 2:
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 100, 200);
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 100, 400);
                    break;
                case 3:
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 100, 200);
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 100, 400);
                    CriarCartasDosJogadoresNaTela(jogadores, 2, 100, 600);
                    break;
                case 4:
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 100, 200);
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 100, 400);
                    CriarCartasDosJogadoresNaTela(jogadores, 2, 100, 600);
                    CriarCartasDosJogadoresNaTela(jogadores, 3, 100, 800);
                    break;
                default:
                    break;
            }

            foreach (Panel panel in panels)
            {
                this.Controls.Add(panel);
            }
        }
        private Jogador VerificarGanhador(List<Jogador> jogadores)
        {
            List<int> pontuacaoJogadores = new List<int>();
                
            foreach(Jogador jogador in jogadores)
            {
                pontuacaoJogadores.Add(jogador.pontuacaoAtual); 
            }
            
            int maiorPontuacao = pontuacaoJogadores.Max();
            Jogador vencedor = jogadores.Find(jogador => jogador.pontuacaoAtual == maiorPontuacao);

            return vencedor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string statusPartida = JogoTratado.VerificarVez(idPartida).statusPartida;
            if (statusPartida == "E" || statusPartida == "F") 
            {
                timer1.Stop();

                jogadores = JogoTratado.ListarJogadores(idPartida);
                Jogador vencedor = VerificarGanhador(jogadores);

                DialogResult mensagemBoxRetorno = MessageBox.Show($"O jogador vencedor é o {vencedor.nome} com {vencedor.pontuacaoAtual} pontos"
                                              , "Aviso"
                                              , MessageBoxButtons.OK
                                              , MessageBoxIcon.Information);

                if (mensagemBoxRetorno == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                int idJogadorDaVez = JogoTratado.VerificarVez(idPartida).idJogadorDaVez;

                bool eMinhaVez = idJogadorDaVez == jogadorLocal.idJogador;

                atualizarTela();
                if (eMinhaVez)
                {
                    jogadorLocal.Jogar(jogadorLocal, idPartida);
                }
            }
        }
    }
}
