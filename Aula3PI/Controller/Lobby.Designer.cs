﻿namespace Aula3PI
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
            this.lblVersaoDLL = new System.Windows.Forms.Label();
            this.cboStatusPartida = new System.Windows.Forms.ComboBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblCriacaoPartida = new System.Windows.Forms.Label();
            this.lblAddJogador = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPartidaEntrar = new System.Windows.Forms.TextBox();
            this.lblIdPartidaEntrar = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarPartidas.Location = new System.Drawing.Point(93, 90);
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
            this.lblNomeGrupo.Location = new System.Drawing.Point(293, 9);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(251, 62);
            this.lblNomeGrupo.TabIndex = 0;
            this.lblNomeGrupo.Text = "Madrid\r\nLobby Magic Trick\r\n";
            this.lblNomeGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersaoDLL
            // 
            this.lblVersaoDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersaoDLL.AutoSize = true;
            this.lblVersaoDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoDLL.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVersaoDLL.Location = new System.Drawing.Point(734, 486);
            this.lblVersaoDLL.Name = "lblVersaoDLL";
            this.lblVersaoDLL.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoDLL.TabIndex = 0;
            // 
            // cboStatusPartida
            // 
            this.cboStatusPartida.BackColor = System.Drawing.SystemColors.Window;
            this.cboStatusPartida.FormattingEnabled = true;
            this.cboStatusPartida.ItemHeight = 13;
            this.cboStatusPartida.Location = new System.Drawing.Point(205, 90);
            this.cboStatusPartida.Name = "cboStatusPartida";
            this.cboStatusPartida.Size = new System.Drawing.Size(103, 21);
            this.cboStatusPartida.TabIndex = 1;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomePartida.Location = new System.Drawing.Point(321, 384);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(105, 13);
            this.lblNomePartida.TabIndex = 0;
            this.lblNomePartida.Text = "Nome da Partida:";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(324, 400);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(187, 20);
            this.txtNomePartida.TabIndex = 3;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarPartida.Location = new System.Drawing.Point(448, 429);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(63, 46);
            this.btnCriarPartida.TabIndex = 6;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdPartida.Location = new System.Drawing.Point(323, 91);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(80, 13);
            this.lblIdPartida.TabIndex = 0;
            this.lblIdPartida.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(409, 88);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(101, 20);
            this.txtIdPartida.TabIndex = 7;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarJogadores.Location = new System.Drawing.Point(326, 114);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(184, 23);
            this.btnListarJogadores.TabIndex = 8;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(531, 170);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(182, 20);
            this.txtNomeJogador.TabIndex = 10;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeJogador.Location = new System.Drawing.Point(528, 154);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(110, 13);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrarPartida.Location = new System.Drawing.Point(531, 252);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(182, 23);
            this.btnEntrarPartida.TabIndex = 13;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.BackColor = System.Drawing.SystemColors.Window;
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(93, 120);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(215, 355);
            this.lstPartidas.TabIndex = 2;
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(326, 143);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(184, 199);
            this.lstJogadores.TabIndex = 9;
            // 
            // lblCriacaoPartida
            // 
            this.lblCriacaoPartida.AutoSize = true;
            this.lblCriacaoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriacaoPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCriacaoPartida.Location = new System.Drawing.Point(335, 353);
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
            this.lblAddJogador.Location = new System.Drawing.Point(543, 97);
            this.lblAddJogador.Name = "lblAddJogador";
            this.lblAddJogador.Size = new System.Drawing.Size(159, 40);
            this.lblAddJogador.TabIndex = 29;
            this.lblAddJogador.Text = "Adicionar Jogador \r\nna Partida";
            this.lblAddJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(625, 226);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(88, 20);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(528, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Senha Partida:";
            // 
            // txtIdPartidaEntrar
            // 
            this.txtIdPartidaEntrar.Location = new System.Drawing.Point(618, 199);
            this.txtIdPartidaEntrar.Name = "txtIdPartidaEntrar";
            this.txtIdPartidaEntrar.Size = new System.Drawing.Size(95, 20);
            this.txtIdPartidaEntrar.TabIndex = 11;
            // 
            // lblIdPartidaEntrar
            // 
            this.lblIdPartidaEntrar.AutoSize = true;
            this.lblIdPartidaEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartidaEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdPartidaEntrar.Location = new System.Drawing.Point(528, 202);
            this.lblIdPartidaEntrar.Name = "lblIdPartidaEntrar";
            this.lblIdPartidaEntrar.Size = new System.Drawing.Size(84, 13);
            this.lblIdPartidaEntrar.TabIndex = 33;
            this.lblIdPartidaEntrar.Text = "Id da Partida:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Location = new System.Drawing.Point(321, 432);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(370, 429);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(72, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(370, 455);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(72, 20);
            this.txtGrupo.TabIndex = 5;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrupo.Location = new System.Drawing.Point(323, 458);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(45, 13);
            this.lblGrupo.TabIndex = 26;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenhaJogador.Location = new System.Drawing.Point(528, 317);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(114, 13);
            this.lblSenhaJogador.TabIndex = 39;
            this.lblSenhaJogador.Text = "Senha do Jogador:";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(644, 314);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(69, 20);
            this.txtSenhaJogador.TabIndex = 15;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(625, 285);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(88, 20);
            this.txtIdJogador.TabIndex = 14;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdJogador.Location = new System.Drawing.Point(528, 288);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(89, 13);
            this.lblIdJogador.TabIndex = 36;
            this.lblIdJogador.Text = "Id do Jogador:";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarPartida.Location = new System.Drawing.Point(531, 353);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(182, 20);
            this.btnIniciarPartida.TabIndex = 16;
            this.btnIniciarPartida.Text = "IniciarPartida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtIdPartidaEntrar);
            this.Controls.Add(this.lblIdPartidaEntrar);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddJogador);
            this.Controls.Add(this.lblCriacaoPartida);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtNomeJogador);
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
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.btnListarPartidas);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblVersaoDLL;
        private System.Windows.Forms.ComboBox cboStatusPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblCriacaoPartida;
        private System.Windows.Forms.Label lblAddJogador;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPartidaEntrar;
        private System.Windows.Forms.Label lblIdPartidaEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}

