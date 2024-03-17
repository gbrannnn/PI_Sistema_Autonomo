namespace Aula3PI
{
    partial class frmLobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblLobby = new System.Windows.Forms.Label();
            this.lblVersaoDLL = new System.Windows.Forms.Label();
            this.cboStatusPartida = new System.Windows.Forms.ComboBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblCriacaoPartida = new System.Windows.Forms.Label();
            this.lblAddJogador = new System.Windows.Forms.Label();
            this.lblTesteCriacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarPartidas.Location = new System.Drawing.Point(147, 106);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(106, 23);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partida";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeGrupo.Location = new System.Drawing.Point(368, 9);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(102, 31);
            this.lblNomeGrupo.TabIndex = 3;
            this.lblNomeGrupo.Text = "Madrid";
            // 
            // lblLobby
            // 
            this.lblLobby.AutoSize = true;
            this.lblLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLobby.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLobby.Location = new System.Drawing.Point(331, 40);
            this.lblLobby.Name = "lblLobby";
            this.lblLobby.Size = new System.Drawing.Size(181, 24);
            this.lblLobby.TabIndex = 4;
            this.lblLobby.Text = "Lobby Magic Trick";
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoDLL.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVersaoDLL.Location = new System.Drawing.Point(750, 489);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoDLL.TabIndex = 5;
            // 
            // cboStatusPartida
            // 
            this.cboStatusPartida.BackColor = System.Drawing.SystemColors.Window;
            this.cboStatusPartida.FormattingEnabled = true;
            this.cboStatusPartida.Location = new System.Drawing.Point(259, 106);
            this.cboStatusPartida.Name = "cboStatusPartida";
            this.cboStatusPartida.Size = new System.Drawing.Size(103, 21);
            this.cboStatusPartida.TabIndex = 6;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomePartida.Location = new System.Drawing.Point(144, 370);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(101, 13);
            this.lblNomePartida.TabIndex = 7;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(147, 386);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(215, 20);
            this.txtNomePartida.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Location = new System.Drawing.Point(144, 418);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(193, 415);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(72, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarPartida.Location = new System.Drawing.Point(271, 415);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(91, 46);
            this.btnCriarPartida.TabIndex = 11;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdPartida.Location = new System.Drawing.Point(481, 106);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(80, 13);
            this.lblIdPartida.TabIndex = 12;
            this.lblIdPartida.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(567, 103);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(66, 20);
            this.txtIdPartida.TabIndex = 13;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarJogadores.Location = new System.Drawing.Point(484, 129);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(149, 23);
            this.btnListarJogadores.TabIndex = 14;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeJogador.Location = new System.Drawing.Point(481, 370);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(106, 13);
            this.lblNomeJogador.TabIndex = 17;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrarPartida.Location = new System.Drawing.Point(484, 413);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(149, 23);
            this.btnEntrarPartida.TabIndex = 18;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            // 
            // lstPartidas
            // 
            this.lstPartidas.BackColor = System.Drawing.SystemColors.Window;
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(147, 133);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(215, 173);
            this.lstPartidas.TabIndex = 20;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(193, 441);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(72, 20);
            this.txtGrupo.TabIndex = 25;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrupo.Location = new System.Drawing.Point(144, 444);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(41, 13);
            this.lblGrupo.TabIndex = 26;
            this.lblGrupo.Text = "Grupo";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(484, 158);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(149, 147);
            this.lstJogadores.TabIndex = 27;
            // 
            // lblCriacaoPartida
            // 
            this.lblCriacaoPartida.AutoSize = true;
            this.lblCriacaoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriacaoPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCriacaoPartida.Location = new System.Drawing.Point(173, 339);
            this.lblCriacaoPartida.Name = "lblCriacaoPartida";
            this.lblCriacaoPartida.Size = new System.Drawing.Size(157, 20);
            this.lblCriacaoPartida.TabIndex = 28;
            this.lblCriacaoPartida.Text = "Criação de Partida";
            // 
            // lblAddJogador
            // 
            this.lblAddJogador.AutoSize = true;
            this.lblAddJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddJogador.Location = new System.Drawing.Point(480, 339);
            this.lblAddJogador.Name = "lblAddJogador";
            this.lblAddJogador.Size = new System.Drawing.Size(154, 20);
            this.lblAddJogador.TabIndex = 29;
            this.lblAddJogador.Text = "Adicionar Jogador";
            // 
            // lblTesteCriacao
            // 
            this.lblTesteCriacao.AutoSize = true;
            this.lblTesteCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesteCriacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTesteCriacao.Location = new System.Drawing.Point(291, 474);
            this.lblTesteCriacao.Name = "lblTesteCriacao";
            this.lblTesteCriacao.Size = new System.Drawing.Size(39, 13);
            this.lblTesteCriacao.TabIndex = 30;
            this.lblTesteCriacao.Text = "Teste";
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.lblTesteCriacao);
            this.Controls.Add(this.lblAddJogador);
            this.Controls.Add(this.lblCriacaoPartida);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.cboStatusPartida);
            this.Controls.Add(this.lblVersaoDLL);
            this.Controls.Add(this.lblLobby);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblLobby;
        private System.Windows.Forms.Label lblVersaoDLL;
        private System.Windows.Forms.ComboBox cboStatusPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblCriacaoPartida;
        private System.Windows.Forms.Label lblAddJogador;
        private System.Windows.Forms.Label lblTesteCriacao;
    }
}

