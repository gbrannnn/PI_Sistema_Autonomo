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
            this.components = new System.ComponentModel.Container();
            this.btnSairPartida = new System.Windows.Forms.Button();
            this.lblCartaJogada = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblCartaAposta = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.txtIdAposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vezDoJogadorLabel = new System.Windows.Forms.Label();
            this.vezDoJogadorText = new System.Windows.Forms.Label();
            this.statusPartidaLabel = new System.Windows.Forms.Label();
            this.statusPartidaText = new System.Windows.Forms.Label();
            this.statusDaRodadaLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusDaRodadaTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnSairPartida.Location = new System.Drawing.Point(1786, 997);
            this.btnSairPartida.Name = "btnSairPartida";
            this.btnSairPartida.Size = new System.Drawing.Size(106, 32);
            this.btnSairPartida.TabIndex = 1;
            this.btnSairPartida.Text = "Sair da Partida";
            this.btnSairPartida.UseVisualStyleBackColor = false;
            this.btnSairPartida.Click += new System.EventHandler(this.btnSairPartida_Click);
            // 
            // lblCartaJogada
            // 
            this.lblCartaJogada.AutoSize = true;
            this.lblCartaJogada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaJogada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCartaJogada.Location = new System.Drawing.Point(1257, 844);
            this.lblCartaJogada.Name = "lblCartaJogada";
            this.lblCartaJogada.Size = new System.Drawing.Size(101, 16);
            this.lblCartaJogada.TabIndex = 5;
            this.lblCartaJogada.Text = "Carta Jogada";
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
            this.btnJogar.Location = new System.Drawing.Point(1296, 811);
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
            this.btnApostar.Location = new System.Drawing.Point(1296, 886);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(62, 25);
            this.btnApostar.TabIndex = 13;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblCartaAposta
            // 
            this.lblCartaAposta.AutoSize = true;
            this.lblCartaAposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaAposta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCartaAposta.Location = new System.Drawing.Point(1257, 919);
            this.lblCartaAposta.Name = "lblCartaAposta";
            this.lblCartaAposta.Size = new System.Drawing.Size(97, 16);
            this.lblCartaAposta.TabIndex = 16;
            this.lblCartaAposta.Text = "Carta Aposta";
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(1260, 814);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(29, 20);
            this.txtIdCarta.TabIndex = 17;
            // 
            // txtIdAposta
            // 
            this.txtIdAposta.Location = new System.Drawing.Point(1260, 889);
            this.txtIdAposta.Name = "txtIdAposta";
            this.txtIdAposta.Size = new System.Drawing.Size(29, 20);
            this.txtIdAposta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // vezDoJogadorLabel
            // 
            this.vezDoJogadorLabel.AutoSize = true;
            this.vezDoJogadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vezDoJogadorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.vezDoJogadorLabel.Location = new System.Drawing.Point(1229, 102);
            this.vezDoJogadorLabel.Name = "vezDoJogadorLabel";
            this.vezDoJogadorLabel.Size = new System.Drawing.Size(113, 16);
            this.vezDoJogadorLabel.TabIndex = 20;
            this.vezDoJogadorLabel.Text = "Vez do jogador";
            // 
            // vezDoJogadorText
            // 
            this.vezDoJogadorText.AutoSize = true;
            this.vezDoJogadorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vezDoJogadorText.ForeColor = System.Drawing.SystemColors.Control;
            this.vezDoJogadorText.Location = new System.Drawing.Point(1229, 129);
            this.vezDoJogadorText.Name = "vezDoJogadorText";
            this.vezDoJogadorText.Size = new System.Drawing.Size(113, 16);
            this.vezDoJogadorText.TabIndex = 21;
            this.vezDoJogadorText.Text = "Vez do jogador";
            // 
            // statusPartidaLabel
            // 
            this.statusPartidaLabel.AutoSize = true;
            this.statusPartidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPartidaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusPartidaLabel.Location = new System.Drawing.Point(1229, 195);
            this.statusPartidaLabel.Name = "statusPartidaLabel";
            this.statusPartidaLabel.Size = new System.Drawing.Size(125, 16);
            this.statusPartidaLabel.TabIndex = 22;
            this.statusPartidaLabel.Text = "Status da partida";
            // 
            // statusPartidaText
            // 
            this.statusPartidaText.AutoSize = true;
            this.statusPartidaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPartidaText.ForeColor = System.Drawing.SystemColors.Control;
            this.statusPartidaText.Location = new System.Drawing.Point(1229, 225);
            this.statusPartidaText.Name = "statusPartidaText";
            this.statusPartidaText.Size = new System.Drawing.Size(125, 16);
            this.statusPartidaText.TabIndex = 23;
            this.statusPartidaText.Text = "Status da partida";
            // 
            // statusDaRodadaLabel
            // 
            this.statusDaRodadaLabel.AutoSize = true;
            this.statusDaRodadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDaRodadaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusDaRodadaLabel.Location = new System.Drawing.Point(1229, 287);
            this.statusDaRodadaLabel.Name = "statusDaRodadaLabel";
            this.statusDaRodadaLabel.Size = new System.Drawing.Size(126, 16);
            this.statusDaRodadaLabel.TabIndex = 24;
            this.statusDaRodadaLabel.Text = "Status da rodada";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusDaRodadaTxt
            // 
            this.statusDaRodadaTxt.AutoSize = true;
            this.statusDaRodadaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDaRodadaTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.statusDaRodadaTxt.Location = new System.Drawing.Point(1229, 318);
            this.statusDaRodadaTxt.Name = "statusDaRodadaTxt";
            this.statusDaRodadaTxt.Size = new System.Drawing.Size(126, 16);
            this.statusDaRodadaTxt.TabIndex = 25;
            this.statusDaRodadaTxt.Text = "Status da rodada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Jogador 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(100, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "jogador 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Jogador 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(100, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Jogador 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(100, 750);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Jogador 3";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusDaRodadaTxt);
            this.Controls.Add(this.statusDaRodadaLabel);
            this.Controls.Add(this.statusPartidaText);
            this.Controls.Add(this.statusPartidaLabel);
            this.Controls.Add(this.vezDoJogadorText);
            this.Controls.Add(this.vezDoJogadorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAposta);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.lblCartaAposta);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblCartaJogada);
            this.Controls.Add(this.btnSairPartida);
            this.MaximizeBox = false;
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Trick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSairPartida;
        private System.Windows.Forms.Label lblCartaJogada;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblCartaAposta;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.TextBox txtIdAposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vezDoJogadorLabel;
        private System.Windows.Forms.Label vezDoJogadorText;
        private System.Windows.Forms.Label statusPartidaLabel;
        private System.Windows.Forms.Label statusPartidaText;
        private System.Windows.Forms.Label statusDaRodadaLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label statusDaRodadaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}