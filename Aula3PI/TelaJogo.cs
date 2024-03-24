using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3PI
{
    public partial class TelaJogo : Form
    {
        public string IniciarPartida { get; set; }

        public TelaJogo()
        {
            InitializeComponent();
        }
        
        public void atualizarTela()
        {
            label1.Text = IniciarPartida;
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
    }
}
