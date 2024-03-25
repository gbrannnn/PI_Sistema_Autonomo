using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public string IniciarPartida { get; set; }


        // Variaveis para debug
        private string DebugidPartida = "2557";
        private int[] DebugidJogadores = {3032, 3033};
        private string SenhaJogador3032 = "BCB2F0";
        public bool modoDebug = false;

        public TelaJogo()
        {
            InitializeComponent();
        }
        
        public void atualizarTela()
        {
            label1.Text = IniciarPartida ?? DebugidPartida;
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

        private void lstCartasBtn_Click(object sender, EventArgs e)
        {

            string[] maoJogadores = Utils.tratarRetornoDoBanco(Jogo.ConsultarMao(Convert.ToInt32(DebugidPartida)));

            List<string> maoJogadorUm = new List<string>();
            List<string> maoJogadorDois = new List<string>();
            List<string> maoJogadorTres = new List<string>();
            List<string> maoJogadorQuatro = new List<string>();


            Jogador jogadorAtual = Jogador.JOGADOR_1;
            for (int i = 1; i <= maoJogadores.Length; i++)
            {

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
                if (i % 12 == 0)
                {
                    jogadorAtual++;
                }
            }
        }

        private void jogar_Click(object sender, EventArgs e)
        {
            string x = Jogo.Jogar(3032, this.SenhaJogador3032, 4);
            variavelPraDebug.Text = x;
        }

        private void apostar_Click(object sender, EventArgs e)
        {
            string x = Jogo.Apostar(3032, this.SenhaJogador3032, 0);
            label4.Text = x;
        }
    }
}
