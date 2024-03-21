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
            string[] valorTratado = valorRetornado
                                                .Replace("\r", "")
                                                .Substring(0, valorRetornado.Length - 1)
                                                .Split('\n');

            return valorTratado;
		}

		private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retornoPartida = null;

            if(cboStatusPartida.SelectedIndex == 0)
            {
                retornoPartida = Jogo.ListarPartidas("T");
            }
            else
            {
                if(cboStatusPartida.SelectedIndex == 1)
                {
                    retornoPartida = Jogo.ListarPartidas("A");
                }
                else
                {
                    if(cboStatusPartida.SelectedIndex == 2)
                    {
                        retornoPartida = Jogo.ListarPartidas("J");
                    }
                    else
                    {
                        retornoPartida = Jogo.ListarPartidas("E");
                    }
                }
            }

            string[] partidas = tratarRetornoDoBanco(retornoPartida);


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

            string retornoCiracaoPartida = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            if (retornoCiracaoPartida.Substring(0,1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + retornoCiracaoPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            lblTesteCriacao.Text = retornoCiracaoPartida;
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

            string retornoJogador = Jogo.ListarJogadores(idPartida);

            if(retornoJogador == "")
            {
                MessageBox.Show("Ocorreu um erro:\n" +
                    "Não há jogadores registrados nesta partida",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                lstJogadores.Items.Clear();
                return;
            }

            if(retornoJogador.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n" 
                    + retornoJogador.Substring(5), 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            string[] jogador = tratarRetornoDoBanco(retornoJogador);


			lstJogadores.Items.Clear();
            for (int i = 0;i < jogador.Length;i++)
            {
                lstJogadores.Items.Add(jogador[i]);
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
            string retornoEntrarPartida = Jogo.EntrarPartida(idPartidaEntrar, txtNomeJogador.Text, txtSenhaPartida.Text);

            if (retornoEntrarPartida.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + retornoEntrarPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            lblIdSenhaJogador.Text = retornoEntrarPartida;

            string[] informacaoJogador = retornoEntrarPartida.Split(',');

            txtIdJogador.Text = informacaoJogador[0];
            txtSenhaJogador.Text = informacaoJogador[1];
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            int idJogador;
            if (txtIdJogador.Text == "")
            {
                idJogador = 0;
            }
            else
            {
                idJogador = Convert.ToInt32(txtIdJogador.Text);
            }

            string retornoIniciarPartida = Jogo.IniciarPartida(idJogador, txtSenhaJogador.Text);

            if (retornoIniciarPartida.Substring(0, 1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + retornoIniciarPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtJogadorVez.Text = retornoIniciarPartida;
        }
    }
}
