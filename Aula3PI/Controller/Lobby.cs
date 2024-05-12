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
using Aula3PI.Repository;
using Aula3PI.Repository.Models;
using Aula3PI.JogadorEntity;


namespace Aula3PI
{
    public partial class frmLobby : Form
    {
        public Jogador jogadorLocal;
        public frmLobby()
        {
            InitializeComponent();

            lblVersaoDLL.Text = "Versão: " + Jogo.Versao;
            txtGrupo.Text = "Madrid";

            cboStatusPartida.Items.Add("Todas");
            cboStatusPartida.Items.Add("Aberto");
            cboStatusPartida.Items.Add("Jogando");
            cboStatusPartida.Items.Add("Finalizadas");
            cboStatusPartida.SelectedIndex = 0;

        
        
        }

		private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string statusPartida = null;

            switch (cboStatusPartida.SelectedIndex) 
            {
                case 0: statusPartida = "T"; break;
                case 1: statusPartida = "A"; break;
                case 2: statusPartida = "J"; break;
                case 3: statusPartida = "F"; break;
            }

            List<ListarPartidasModel> partidas = JogoTratado.ListarPartidas(statusPartida);

			lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Count; i++)
            {
                string textoFormatado = $"{partidas[i].idPartida} - {partidas[i].nome} - {partidas[i].dataCriacao} - {partidas[i].status}";
                lstPartidas.Items.Add(textoFormatado);
            }
            
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
        
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {

            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenha.Text;
            string nomeGrupo = txtGrupo.Text;


            string partida = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            if (nomePartida.Contains(",") == true)
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + partida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (partida.Substring(0,1) == "E")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                    + partida.Substring(5),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtIdPartida.Text = partida;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {

            int idPartida = Convert.ToInt32(txtIdPartidaEntrar.Text);


            EntrarPartida infoJogadorCriado = JogoTratado.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaPartida.Text);

            //chage realised here, if it's not working check this function
            if (infoJogadorCriado.ToString().Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n"
                + infoJogadorCriado.ToString().Substring(5),
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            txtIdJogador.Text = Convert.ToString(infoJogadorCriado.idjogadorCriado);
            txtSenhaJogador.Text = infoJogadorCriado.senhaGerada;

            jogadorLocal = new Jogador();
            jogadorLocal.idJogador = infoJogadorCriado.idjogadorCriado;
            jogadorLocal.senha = infoJogadorCriado.senhaGerada.Replace("\r", "").Replace("\n", "");
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            
            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            int idPartida = Convert.ToInt32(txtIdPartida.Text);
            string senhaJogador = txtSenhaJogador.Text;

            IniciarPartida jogadorSorteado = JogoTratado.IniciarPartida(idJogador, senhaJogador);
            
            List<Jogador> jogadores = JogoTratado.ListarJogadores(idPartida);


            TelaJogo telaJogo = new TelaJogo(
                idPartida,
                jogadorLocal, 
                jogadores.Find(x => x.idJogador == jogadorSorteado.idPrimeiroJogador), 
                jogadores
            );
            telaJogo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txtIdPartida.Text);

            List<Jogador> jogadores = JogoTratado.ListarJogadores(idPartida);


            TelaJogo telaJogo = new TelaJogo(
                idPartida,
                jogadorLocal,
                null,
                jogadores
            );
            telaJogo.ShowDialog();
        }
    }
}
