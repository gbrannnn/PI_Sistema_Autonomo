namespace Aula3PI
{
    partial class TelaJogo
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
            this.lblTest = new System.Windows.Forms.Label();
            this.btnSairPartida = new System.Windows.Forms.Button();
            this.lstCartasBoxListJogador1 = new System.Windows.Forms.ListBox();
            this.lblMaoJogador1 = new System.Windows.Forms.Label();
            this.lblCartaJogada = new System.Windows.Forms.Label();
            this.lstCartasBoxListJogador2 = new System.Windows.Forms.ListBox();
            this.lblMaoJogador2 = new System.Windows.Forms.Label();
            this.bntListarCartas = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCartaAposta = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.txtIdAposta = new System.Windows.Forms.TextBox();
            this.pnlCarta = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTest.Location = new System.Drawing.Point(266, 568);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(50, 16);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "label1";
            // 
            // btnSairPartida
            // 
            this.btnSairPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnSairPartida.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSairPartida.FlatAppearance.BorderSize = 2;
            this.btnSairPartida.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSairPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairPartida.Location = new System.Drawing.Point(1073, 606);
            this.btnSairPartida.Name = "btnSairPartida";
            this.btnSairPartida.Size = new System.Drawing.Size(106, 32);
            this.btnSairPartida.TabIndex = 1;
            this.btnSairPartida.Text = "Sair da Partida";
            this.btnSairPartida.UseVisualStyleBackColor = false;
            this.btnSairPartida.Click += new System.EventHandler(this.btnSairPartida_Click);
            // 
            // lstCartasBoxListJogador1
            // 
            this.lstCartasBoxListJogador1.BackColor = System.Drawing.SystemColors.Info;
            this.lstCartasBoxListJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCartasBoxListJogador1.FormattingEnabled = true;
            this.lstCartasBoxListJogador1.Location = new System.Drawing.Point(35, 288);
            this.lstCartasBoxListJogador1.Name = "lstCartasBoxListJogador1";
            this.lstCartasBoxListJogador1.Size = new System.Drawing.Size(139, 171);
            this.lstCartasBoxListJogador1.TabIndex = 2;
            // 
            // lblMaoJogador1
            // 
            this.lblMaoJogador1.AutoSize = true;
            this.lblMaoJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaoJogador1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaoJogador1.Location = new System.Drawing.Point(46, 255);
            this.lblMaoJogador1.Name = "lblMaoJogador1";
            this.lblMaoJogador1.Size = new System.Drawing.Size(111, 16);
            this.lblMaoJogador1.TabIndex = 4;
            this.lblMaoJogador1.Text = "Mao Jogador 1";
            // 
            // lblCartaJogada
            // 
            this.lblCartaJogada.AutoSize = true;
            this.lblCartaJogada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaJogada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCartaJogada.Location = new System.Drawing.Point(47, 547);
            this.lblCartaJogada.Name = "lblCartaJogada";
            this.lblCartaJogada.Size = new System.Drawing.Size(101, 16);
            this.lblCartaJogada.TabIndex = 5;
            this.lblCartaJogada.Text = "Carta Jogada";
            // 
            // lstCartasBoxListJogador2
            // 
            this.lstCartasBoxListJogador2.BackColor = System.Drawing.SystemColors.Info;
            this.lstCartasBoxListJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCartasBoxListJogador2.FormattingEnabled = true;
            this.lstCartasBoxListJogador2.Location = new System.Drawing.Point(221, 288);
            this.lstCartasBoxListJogador2.Name = "lstCartasBoxListJogador2";
            this.lstCartasBoxListJogador2.Size = new System.Drawing.Size(139, 171);
            this.lstCartasBoxListJogador2.TabIndex = 6;
            // 
            // lblMaoJogador2
            // 
            this.lblMaoJogador2.AutoSize = true;
            this.lblMaoJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaoJogador2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaoJogador2.Location = new System.Drawing.Point(232, 255);
            this.lblMaoJogador2.Name = "lblMaoJogador2";
            this.lblMaoJogador2.Size = new System.Drawing.Size(111, 16);
            this.lblMaoJogador2.TabIndex = 7;
            this.lblMaoJogador2.Text = "Mao Jogador 2";
            // 
            // bntListarCartas
            // 
            this.bntListarCartas.BackColor = System.Drawing.Color.Transparent;
            this.bntListarCartas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntListarCartas.FlatAppearance.BorderSize = 2;
            this.bntListarCartas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntListarCartas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntListarCartas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntListarCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntListarCartas.ForeColor = System.Drawing.SystemColors.Control;
            this.bntListarCartas.Location = new System.Drawing.Point(49, 465);
            this.bntListarCartas.Name = "bntListarCartas";
            this.bntListarCartas.Size = new System.Drawing.Size(108, 25);
            this.bntListarCartas.TabIndex = 11;
            this.bntListarCartas.Text = "Listar Cartas";
            this.bntListarCartas.UseVisualStyleBackColor = false;
            this.bntListarCartas.Click += new System.EventHandler(this.bntListarCartas_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnJogar.FlatAppearance.BorderSize = 2;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJogar.Location = new System.Drawing.Point(86, 514);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(62, 25);
            this.btnJogar.TabIndex = 12;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.Transparent;
            this.btnApostar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApostar.FlatAppearance.BorderSize = 2;
            this.btnApostar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApostar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApostar.Location = new System.Drawing.Point(86, 589);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(62, 25);
            this.btnApostar.TabIndex = 13;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(407, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(463, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "label1";
            // 
            // lblCartaAposta
            // 
            this.lblCartaAposta.AutoSize = true;
            this.lblCartaAposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaAposta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCartaAposta.Location = new System.Drawing.Point(47, 622);
            this.lblCartaAposta.Name = "lblCartaAposta";
            this.lblCartaAposta.Size = new System.Drawing.Size(97, 16);
            this.lblCartaAposta.TabIndex = 16;
            this.lblCartaAposta.Text = "Carta Aposta";
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(50, 517);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(29, 20);
            this.txtIdCarta.TabIndex = 17;
            // 
            // txtIdAposta
            // 
            this.txtIdAposta.Location = new System.Drawing.Point(50, 592);
            this.txtIdAposta.Name = "txtIdAposta";
            this.txtIdAposta.Size = new System.Drawing.Size(29, 20);
            this.txtIdAposta.TabIndex = 18;
            // 
            // pnlCarta
            // 
            this.pnlCarta.BackgroundImage = global::Aula3PI.Properties.Resources.Copas1;
            this.pnlCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCarta.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCarta.Location = new System.Drawing.Point(644, 422);
            this.pnlCarta.Name = "pnlCarta";
            this.pnlCarta.Size = new System.Drawing.Size(126, 162);
            this.pnlCarta.TabIndex = 19;
            this.pnlCarta.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(689, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1191, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlCarta);
            this.Controls.Add(this.txtIdAposta);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.lblCartaAposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.bntListarCartas);
            this.Controls.Add(this.lblMaoJogador2);
            this.Controls.Add(this.lstCartasBoxListJogador2);
            this.Controls.Add(this.lblCartaJogada);
            this.Controls.Add(this.lblMaoJogador1);
            this.Controls.Add(this.lstCartasBoxListJogador1);
            this.Controls.Add(this.btnSairPartida);
            this.Controls.Add(this.lblTest);
            this.MaximizeBox = false;
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Trick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnSairPartida;
        private System.Windows.Forms.ListBox lstCartasBoxListJogador1;
        private System.Windows.Forms.Label lblMaoJogador1;
        private System.Windows.Forms.Label lblCartaJogada;
        private System.Windows.Forms.ListBox lstCartasBoxListJogador2;
        private System.Windows.Forms.Label lblMaoJogador2;
        private System.Windows.Forms.Button bntListarCartas;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCartaAposta;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.TextBox txtIdAposta;
        private System.Windows.Forms.Panel pnlCarta;
        private System.Windows.Forms.Label label3;
    }
}