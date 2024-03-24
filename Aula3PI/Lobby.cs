using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MagicTrickServer;

namespace Aula3PI
{
    public partial class frmLobby : Form
    {
        private string IniciarPartida;

        public frmLobby()
        {
            InitializeComponent();

            lblVersaoDLL.Text = "Versão: " + Jogo.Versao;
            txtGrupo.Text = "Madrid";

            cboStatusPartida.Items.Add("Todas");
            cboStatusPartida.Items.Add("Aberto");
            cboStatusPartida.Items.Add("Jogando");
            cboStatusPartida.Items.Add("Encerrado");
            cboStatusPartida.SelectedIndex = 0;
        }

        private string[] tratarRetornoDoBanco(string valorRetornado)
        {
            valorRetornado = valorRetornado.Replace("\r", "");
            valorRetornado = valorRetornado.Substring(0, valorRetornado.Length - 1);
            string[] valorTratado = valorRetornado.Split('\n');

            return valorTratado;
		}

		private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string partida = null;

            if(cboStatusPartida.SelectedIndex == 0)
            {
                partida = Jogo.ListarPartidas("T");
            }
            else
            {
                if(cboStatusPartida.SelectedIndex == 1)
                {
                    partida = Jogo.ListarPartidas("A");
                }
                else
                {
                    if(cboStatusPartida.SelectedIndex == 2)
                    {
                        partida = Jogo.ListarPartidas("J");
                    }
                    else
                    {
                        partida = Jogo.ListarPartidas("E");
                    }
                }
            }

            string[] partidas = tratarRetornoDoBanco(partida);

			lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
            
        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {

            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenha.Text;
            string nomeGrupo = txtGrupo.Text;

            if (nomePartida.Contains(",") == true)
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + "Nome de partida não pode ter virgula",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string criacaoPartida = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            if (criacaoPartida.Substring(0,1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + criacaoPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            lblTesteCriacao.Text = criacaoPartida;
        }


        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int idPartida;
            if(txtIdPartida.Text == "")
            {
                idPartida = 0;
            }
            else
            {
                idPartida = Convert.ToInt32(txtIdPartida.Text);
            }

            string jogador = Jogo.ListarJogadores(idPartida);

            if(jogador == "")
            {
                MessageBox.Show("Ocorreu um erro:\n" +
                    "Não há jogadores registrados nesta partida",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                lstJogadores.Items.Clear();
                return;
            }

            if(jogador.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n" 
                    + jogador.Substring(5), 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            string[] jogadores = tratarRetornoDoBanco(jogador);


			lstJogadores.Items.Clear();
            for (int i = 0;i < jogadores.Length;i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
     
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartidaEntrar;
            if (txtIdPartidaEntrar.Text == "")
            {
                idPartidaEntrar = 0;
            }
            else
            {
                idPartidaEntrar = Convert.ToInt32(txtIdPartidaEntrar.Text);
            }
            string entrarPartida = Jogo.EntrarPartida(idPartidaEntrar, txtNomeJogador.Text, txtSenhaPartida.Text);

            if (entrarPartida.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + entrarPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            lblIdSenhaJogador.Text = entrarPartida;

            string[] informacaoJogador = entrarPartida.Split(',');

            txtIdJogador.Text = informacaoJogador[0];
            txtSenhaJogador.Text = informacaoJogador[1];
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            TelaJogo telaJogo = new TelaJogo();

            int idJogador;
            int idPartida;
            if (txtIdJogador.Text == "")
            {
                idJogador = 0;
                idPartida = 0;
            }
            else
            {
                idJogador = Convert.ToInt32(txtIdJogador.Text);
                idPartida = Convert.ToInt32(txtIdPartidaEntrar.Text);
            }

            string iniciarPartida = Jogo.IniciarPartida(idJogador, txtSenhaJogador.Text);
            string[] jogadores = tratarRetornoDoBanco(Jogo.ListarJogadores(idPartida));
            string[] informacaoJogador = null;

            for (int i = 0; i < jogadores.Length; i++)
            {
                if (jogadores[i].Contains(iniciarPartida))
                {
                    informacaoJogador = jogadores[i].Split(',');
                }
            }

            if (iniciarPartida.Substring(0, 1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + iniciarPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            telaJogo.IniciarPartida = iniciarPartida + " " + informacaoJogador[1];
            telaJogo.atualizarTela();
            telaJogo.ShowDialog();

        }
    }
}
