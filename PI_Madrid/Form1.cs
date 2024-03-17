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

namespace Aula3PI
{
    public partial class frmLobby : Form
    {
        public frmLobby()
        {
            InitializeComponent();

            lblVersaoDLL.Text = "Versão: " + Jogo.Versao;

            cboStatusPartida.Items.Add("Todas");
            cboStatusPartida.Items.Add("Aberto");
            cboStatusPartida.Items.Add("Jogando");
            cboStatusPartida.Items.Add("Encerrado");
            cboStatusPartida.SelectedIndex = 0;
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

            retornoPartida = retornoPartida.Replace("\r", "");
            retornoPartida = retornoPartida.Substring(0, retornoPartida.Length - 1);
            string[] partidas = retornoPartida.Split('\n');

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

            string retornoCiracaoPartida = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            if (retornoCiracaoPartida.Substring(0, 4) == "ERRO")
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
            if(txtIdPartida.Text == "")
            {
                MessageBox.Show("Aviso! \n" +
                    "preencha o campo 'id da Partida',\n" +
                    "para que possa listar os jogadores",
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }

            int idPartida = Convert.ToInt32(txtIdPartida.Text);
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

            retornoJogador = retornoJogador.Replace("\r", "");
            retornoJogador = retornoJogador.Substring(0, retornoJogador.Length - 1);
            string[] jogador = retornoJogador.Split('\n');

            lstJogadores.Items.Clear();
            for (int i = 0;i < jogador.Length;i++)
            {
                lstJogadores.Items.Add(jogador[i]);
            }
     
        }

    }
}
