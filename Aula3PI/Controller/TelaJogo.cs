﻿using System;
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
using System.Threading;

namespace Aula3PI
{

    public partial class TelaJogo : Form
    {
        public int numeroRodada;
        public int idPartida;
        public int quantidadeJogadores;
        public Jogador jogadorLocal;
        public Jogador jogadorDaVez;
        public VerificarVez informacoesSobreARodada;
        public List<Jogador> jogadores;
        public List<Panel> panels = new List<Panel>();
        public List<Panel> cartasJogadas = new List<Panel>();
        public List<ExibirJogadas> historicoJogadas;

        public TelaJogo(int idPartida, Jogador jogadorLocal, Jogador jogadorDaVez, List<Jogador> jogadores)
        {
            this.idPartida = idPartida;
            this.jogadorLocal = jogadorLocal;

            this.jogadores = jogadores;

            this.quantidadeJogadores = Utils.QuantidadeJogadores(jogadores);
            InitializeComponent();
            atualizarTela();
        }

        public void atualizarTela()
        {
            informacoesSobreARodada = JogoTratado.VerificarVez(idPartida);

            vezDoJogadorText.Text = jogadores.Find(jogador => jogador.idJogador == informacoesSobreARodada.idJogadorDaVez).nome;
            statusPartidaText.Text = informacoesSobreARodada.statusPartida;
            statusDaRodadaTxt.Text = informacoesSobreARodada.statusRodada;
            lblPontuaçãoJogador1.Text = jogadorLocal.pontuacaoAtual.ToString();
            lblPontuaçãoJogador2.Text = jogadores[1].pontuacaoAtual.ToString();
            numeroRodada = JogoTratado.VerificarVez(idPartida).numeroRodada;

            MostrarCartaJogada();
            AtribuirCartasParaCadaJogador();
            ListarCartas();
        }

        public void MostrarCartaJogada()
        {
            int idJogador;
            string cartaJogadaNaipe;
            int cartaJogadaValor;

            historicoJogadas = JogoTratado.ExibirJogadas(idPartida);

            if (historicoJogadas.Count != 0)
            {
               

                idJogador = historicoJogadas.Last().idJogador;
                cartaJogadaNaipe = historicoJogadas.Last().naipe;
                cartaJogadaValor = historicoJogadas.Last().valorNaipe;
                Panel cartaJogada = Utils.VirarCarta(jogadores, idJogador, cartaJogadaNaipe, cartaJogadaValor);

                if(Convert.ToInt32(cartaJogada.Tag) == jogadores[0].idJogador)
                {
                    lblValorCartaJogadaJ1.Text = cartaJogadaValor.ToString();
                }
                else if (Convert.ToInt32(cartaJogada.Tag) == jogadores[1].idJogador)
                {
                    lblValorCartaJogadaJ2.Text = cartaJogadaValor.ToString();
                }
                else if (Convert.ToInt32(cartaJogada.Tag) == jogadores[2].idJogador)
                {
                    lblValorCartaJogadaJ3.Text = cartaJogadaValor.ToString();
                }
                else
                {
                    lblValorCartaJogadaJ4.Text = cartaJogadaValor.ToString();
                }

                if (cartasJogadas.Count == 0 || Convert.ToInt32(cartasJogadas.Last().Tag) != idJogador)
                {
                    cartasJogadas.Add(cartaJogada);
                    this.Controls.Add(cartaJogada);
                }

                Thread.Sleep(3000);
                if (cartasJogadas.Count == quantidadeJogadores)
                {
                    foreach (Panel panel in cartasJogadas)
                    {
                        this.Controls.Remove(panel);
                        panel.Dispose();
                    }
                    cartasJogadas.Clear();
                }
            }
        }

        public List<Panel> CriacaoDePanelsCartas(List<Panel> panels, List<Carta> cartasDoJogadorAtual, int posicaoJogador, int pointX, int pointY)
        {
            Point point = new Point(pointX, pointY);
            Size size = new Size(60, 80);

            if(posicaoJogador % 2 == 0)
            {
                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    if (i == cartasDoJogadorAtual.Count / 2)
                    {
                        point.Y += size.Height + 10;
                        point.X = pointX;
                    }
                    Panel painelCarta = new Panel();
                    painelCarta.Location = point;
                    point.X = point.X + (size.Width + 10);
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    panels.Add(painelCarta);
                }
            }
            else
            {
                for (int i = 0; i < cartasDoJogadorAtual.Count; i++)
                {
                    if (i == cartasDoJogadorAtual.Count / 2)
                    {
                        point.X += size.Width + 10;
                        point.Y = pointY;
                    }
                    Panel painelCarta = new Panel();
                    painelCarta.Location = point;
                    point.Y = point.Y + (size.Height + 10);
                    painelCarta.Size = size;
                    painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
                    painelCarta.BackgroundImage = cartasDoJogadorAtual[i].background;
                    panels.Add(painelCarta);
                }
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
            CriacaoDePanelsCartas(panels, cartasDoJogadorAtual, posicaoJogador, pointX, pointY);
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
                    lblJogador1.Text = this.jogadores[0].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 230, 750);
                    lblJogador2.Text = this.jogadores[1].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 50, 180);
                    break;
                case 3:
                    lblJogador1.Text = this.jogadores[0].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 230, 750);
                    lblJogador2.Text = this.jogadores[1].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 50, 180);
                    lblJogador3.Text = this.jogadores[2].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 2, 230, 50);
                    break;
                case 4:
                    lblJogador1.Text = this.jogadores[0].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 0, 230, 750);
                    lblJogador2.Text = this.jogadores[1].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 1, 50, 180);
                    lblJogador3.Text = this.jogadores[2].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 2, 230, 50);
                    lblJogador4.Text = this.jogadores[3].nome;
                    CriarCartasDosJogadoresNaTela(jogadores, 3, 760, 180);
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
                    jogadorLocal.Jogar(jogadorLocal, idPartida, historicoJogadas, numeroRodada);
                }
            }
        }
    }
}
