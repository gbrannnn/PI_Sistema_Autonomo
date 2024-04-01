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

namespace Aula3PI


{
    enum Jogador
    {
        JOGADOR_1,
        JOGADOR_2,
        JOGADOR_3,
        JOGADOR_4,
    }


    public partial class TelaJogo : Form
    {
        public int IdPartida { get; set; } 
        //public string[] Jogadores { get; set; }
        public string IdJogador { get; set; }
        public string SenhaJogador { get; set; }
        public string IdJogadorSorteado { get; set; }
        public string NomeJogador { get; set; }



        // Variaveis para debug
        // private string DebugidPartida = "2557";
        //private int[] DebugidJogadores = {3032, 3033};
        //private string SenhaJogador3032 = "BCB2F0";
        private string[] DebugJogadores = { "2258,p1,0", "2259,p2,0" };
        public bool modoDebug = false;

        public TelaJogo()
        {
            InitializeComponent();
        }
        
        public void atualizarTela()
        {
            lblTest.Text = IdJogadorSorteado + " " + NomeJogador;
            label1.Text = IdJogador;
            label2.Text = SenhaJogador; 
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
            lstCartasBoxListJogador1.Items.Clear();
            lstCartasBoxListJogador2.Items.Clear();

            string[] maoJogadores = Utils.tratarRetornoDoBanco(Jogo.ConsultarMao(Convert.ToInt32(IdPartida)));

            List<Panel> listaCartas = Cartas.criacaoCarta(maoJogadores);

            foreach(Panel carta in listaCartas)
            {
                this.Controls.Add(carta);
            }

            pnlCarta.Tag = maoJogadores[0];
            label3.Text = pnlCarta.Tag.ToString();

            List<string> maoJogadorUm = new List<string>();
            List<string> maoJogadorDois = new List<string>();
            List<string> maoJogadorTres = new List<string>();
            List<string> maoJogadorQuatro = new List<string>();

            Dictionary<string, string[]> jogadores = new Dictionary<string, string[]>();    

            for(int i = 0; i < DebugJogadores.Length; i++)
            {
                string[] aux = DebugJogadores[i].Split(',');
                jogadores.Add("Jogador" + i + 1, aux);
            }

            
            string idJogadorUm = jogadores[0];
            string idJogadorDois = jogadores[3];

            for(int i = 0; i < maoJogadores.Length; i++)
            {
                if (maoJogadores[i].Contains(idJogadorUm))
                {
                    maoJogadorUm.Add(maoJogadores[i]);
                    lstCartasBoxListJogador1.Items.Add(maoJogadores[i]);
                }
                else if (maoJogadores[i].Contains(idJogadorDois))
                {
                    maoJogadorDois.Add(maoJogadores[i]);
                    lstCartasBoxListJogador2.Items.Add(maoJogadores[i]);
                }
            }

            /*
            Jogador jogadorAtual = Jogador.JOGADOR_1;
            for (int i = 1; i <= maoJogadores.Length; i++)
            {
                if (i % 12 == 0)
                {
                    jogadorAtual++;
                }
                switch (jogadorAtual)
                {
                    case Jogador.JOGADOR_1:
                        maoJogadorUm.Add(maoJogadores[i - 1]);
                        lstCartasBoxListJogador1.Items.Add(maoJogadores[i - 1]);
                        break;
                    case Jogador.JOGADOR_2:
                        maoJogadorDois.Add(maoJogadores[i - 1]);
                        lstCartasBoxListJogador2.Items.Add(maoJogadores[i - 1]);
                        break;
                    case Jogador.JOGADOR_3:
                        maoJogadorTres.Add(maoJogadores[i]);
                        break;
                    case Jogador.JOGADOR_4:
                        maoJogadorQuatro.Add(maoJogadores[i]);
                        break;
                }
            }
            */
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string valorCarta = Jogo.Jogar(Convert.ToInt32(IdJogador), SenhaJogador, Convert.ToInt32(txtIdCarta.Text));
            lblCartaJogada.Text = valorCarta;
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            string valorAposta = Jogo.Apostar(Convert.ToInt32(IdJogador), SenhaJogador, Convert.ToInt32(txtIdAposta.Text));
            lblCartaAposta.Text = valorAposta;
        }
    }
}
