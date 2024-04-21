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

namespace Aula3PI
{
    enum EJogador
    {
        JOGADOR_1,
        JOGADOR_2,
        JOGADOR_3,
        JOGADOR_4,
    }


    public partial class TelaJogo : Form
    {
        public int idPartida;

        public Jogador jogadorLocal;
        public List<Jogador> jogadores;
        public Jogador jogadorDaVez;
        public List<Carta> cartasJogadas;
        public string[] DebugJogadores;
        public TelaJogo()
        {
            InitializeComponent();
        }
        
        public void atualizarTela()
        {
            

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

        private void bntListarCartas_Click(object sender, EventArgs e)
        {
            
            List<Carta> cartas = JogoTratado.ConsultarMao(Convert.ToInt32(idPartida), jogadores);

            int width = 60;
            int height = 100;
            int tamanho = Controls.Count;
            /*
            for (int i = tamanho -1; i <= 0; i--)
            {
                if(Controls[i] is Panel)
                {
                    panel.Controls.Clear();
                }
            }
            */

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
        }

        private void pnlCarta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
