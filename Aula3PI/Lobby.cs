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
using utils;

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

            string[] partidas = Utils.tratarRetornoDoBanco(partida);

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

            string partida = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            if (partida.Substring(0,1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + partida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            lblTesteCriacao.Text = partida;
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

            string[] jogadores = Utils.tratarRetornoDoBanco(jogador);


			lstJogadores.Items.Clear();
            for (int i = 0;i < jogadores.Length;i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
     
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {

            int idPartida;
            if (txtIdPartidaEntrar.Text == "")
            {
                idPartida = 0;
            }
            else
            {
                idPartida = Convert.ToInt32(txtIdPartidaEntrar.Text);
            }
            string entrarPartida = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaPartida.Text);

            if (entrarPartida.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + entrarPartida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

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

            string idJogadorSorteado = Jogo.IniciarPartida(idJogador, txtSenhaJogador.Text);
            string[] jogadores = Utils.tratarRetornoDoBanco(Jogo.ListarJogadores(idPartida));
            string[] jogador = null;

            for (int i = 0; i < jogadores.Length; i++)
            {
                if (jogadores[i].Contains(idJogadorSorteado))
                {
                    jogador = jogadores[i].Split(',');
                }
            }

            if (idJogadorSorteado.Substring(0, 1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + idJogadorSorteado.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            telaJogo.IdJogador = txtIdJogador.Text;
            telaJogo.SenhaJogador = txtSenhaJogador.Text;
            telaJogo.IdJogadorSorteado = idJogadorSorteado; 
            telaJogo.NomeJogador = jogador[1];
            telaJogo.IdPartida = idPartida;
            telaJogo.atualizarTela();
            telaJogo.ShowDialog();

        }

        private void irParaJogoDebug_Click_1(object sender, EventArgs e)
        {

            TelaJogo telaJogo = new TelaJogo();
            telaJogo.IdPartida = Convert.ToInt32(txtIdPartidaEntrar.Text);
            telaJogo.IdJogador = txtIdJogador.Text;
            telaJogo.SenhaJogador = txtSenhaJogador.Text;
            telaJogo.modoDebug = true;
            telaJogo.atualizarTela();
            telaJogo.ShowDialog();
            
        }
    }
}
