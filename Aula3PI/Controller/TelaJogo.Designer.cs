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
            this.label1 = new System.Windows.Forms.Label();
            this.vezDoJogadorLabel = new System.Windows.Forms.Label();
            this.vezDoJogadorText = new System.Windows.Forms.Label();
            this.statusPartidaLabel = new System.Windows.Forms.Label();
            this.statusPartidaText = new System.Windows.Forms.Label();
            this.statusDaRodadaLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusDaRodadaTxt = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador4 = new System.Windows.Forms.Label();
            this.lblPontuaçãoJogador1 = new System.Windows.Forms.Label();
            this.lblPontuaçãoJogador2 = new System.Windows.Forms.Label();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.lblValorCartaJogadaJ1 = new System.Windows.Forms.Label();
            this.lblValorCartaJogadaJ2 = new System.Windows.Forms.Label();
            this.lblValorCartaJogadaJ3 = new System.Windows.Forms.Label();
            this.lblValorCartaJogadaJ4 = new System.Windows.Forms.Label();
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
            this.btnSairPartida.Location = new System.Drawing.Point(1066, 917);
            this.btnSairPartida.Name = "btnSairPartida";
            this.btnSairPartida.Size = new System.Drawing.Size(106, 32);
            this.btnSairPartida.TabIndex = 1;
            this.btnSairPartida.Text = "Sair da Partida";
            this.btnSairPartida.UseVisualStyleBackColor = false;
            this.btnSairPartida.Click += new System.EventHandler(this.btnSairPartida_Click);
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
            this.vezDoJogadorLabel.Location = new System.Drawing.Point(1032, 13);
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
            this.vezDoJogadorText.Location = new System.Drawing.Point(1032, 40);
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
            this.statusPartidaLabel.Location = new System.Drawing.Point(1032, 106);
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
            this.statusPartidaText.Location = new System.Drawing.Point(1032, 136);
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
            this.statusDaRodadaLabel.Location = new System.Drawing.Point(1032, 198);
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
            this.statusDaRodadaTxt.Location = new System.Drawing.Point(1032, 229);
            this.statusDaRodadaTxt.Name = "statusDaRodadaTxt";
            this.statusDaRodadaTxt.Size = new System.Drawing.Size(126, 16);
            this.statusDaRodadaTxt.TabIndex = 25;
            this.statusDaRodadaTxt.Text = "Status da rodada";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJogador1.Location = new System.Drawing.Point(230, 730);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(0, 16);
            this.lblJogador1.TabIndex = 26;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJogador2.Location = new System.Drawing.Point(50, 160);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(0, 16);
            this.lblJogador2.TabIndex = 27;
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJogador4.Location = new System.Drawing.Point(760, 160);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(0, 16);
            this.lblJogador4.TabIndex = 30;
            // 
            // lblPontuaçãoJogador1
            // 
            this.lblPontuaçãoJogador1.AutoSize = true;
            this.lblPontuaçãoJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuaçãoJogador1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPontuaçãoJogador1.Location = new System.Drawing.Point(1032, 283);
            this.lblPontuaçãoJogador1.Name = "lblPontuaçãoJogador1";
            this.lblPontuaçãoJogador1.Size = new System.Drawing.Size(81, 16);
            this.lblPontuaçãoJogador1.TabIndex = 33;
            this.lblPontuaçãoJogador1.Text = "Pontuação";
            // 
            // lblPontuaçãoJogador2
            // 
            this.lblPontuaçãoJogador2.AutoSize = true;
            this.lblPontuaçãoJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuaçãoJogador2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPontuaçãoJogador2.Location = new System.Drawing.Point(1032, 309);
            this.lblPontuaçãoJogador2.Name = "lblPontuaçãoJogador2";
            this.lblPontuaçãoJogador2.Size = new System.Drawing.Size(81, 16);
            this.lblPontuaçãoJogador2.TabIndex = 34;
            this.lblPontuaçãoJogador2.Text = "Pontuação";
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJogador3.Location = new System.Drawing.Point(230, 30);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(0, 16);
            this.lblJogador3.TabIndex = 35;
            // 
            // lblValorCartaJogadaJ1
            // 
            this.lblValorCartaJogadaJ1.AutoSize = true;
            this.lblValorCartaJogadaJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaJogadaJ1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaJogadaJ1.Location = new System.Drawing.Point(415, 600);
            this.lblValorCartaJogadaJ1.Name = "lblValorCartaJogadaJ1";
            this.lblValorCartaJogadaJ1.Size = new System.Drawing.Size(15, 16);
            this.lblValorCartaJogadaJ1.TabIndex = 36;
            this.lblValorCartaJogadaJ1.Text = "0";
            // 
            // lblValorCartaJogadaJ2
            // 
            this.lblValorCartaJogadaJ2.AutoSize = true;
            this.lblValorCartaJogadaJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaJogadaJ2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaJogadaJ2.Location = new System.Drawing.Point(280, 440);
            this.lblValorCartaJogadaJ2.Name = "lblValorCartaJogadaJ2";
            this.lblValorCartaJogadaJ2.Size = new System.Drawing.Size(15, 16);
            this.lblValorCartaJogadaJ2.TabIndex = 37;
            this.lblValorCartaJogadaJ2.Text = "0";
            // 
            // lblValorCartaJogadaJ3
            // 
            this.lblValorCartaJogadaJ3.AutoSize = true;
            this.lblValorCartaJogadaJ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaJogadaJ3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaJogadaJ3.Location = new System.Drawing.Point(415, 280);
            this.lblValorCartaJogadaJ3.Name = "lblValorCartaJogadaJ3";
            this.lblValorCartaJogadaJ3.Size = new System.Drawing.Size(15, 16);
            this.lblValorCartaJogadaJ3.TabIndex = 38;
            this.lblValorCartaJogadaJ3.Text = "0";
            // 
            // lblValorCartaJogadaJ4
            // 
            this.lblValorCartaJogadaJ4.AutoSize = true;
            this.lblValorCartaJogadaJ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCartaJogadaJ4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorCartaJogadaJ4.Location = new System.Drawing.Point(580, 440);
            this.lblValorCartaJogadaJ4.Name = "lblValorCartaJogadaJ4";
            this.lblValorCartaJogadaJ4.Size = new System.Drawing.Size(15, 16);
            this.lblValorCartaJogadaJ4.TabIndex = 39;
            this.lblValorCartaJogadaJ4.Text = "0";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.lblValorCartaJogadaJ4);
            this.Controls.Add(this.lblValorCartaJogadaJ3);
            this.Controls.Add(this.lblValorCartaJogadaJ2);
            this.Controls.Add(this.lblValorCartaJogadaJ1);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.lblPontuaçãoJogador2);
            this.Controls.Add(this.lblPontuaçãoJogador1);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.statusDaRodadaTxt);
            this.Controls.Add(this.statusDaRodadaLabel);
            this.Controls.Add(this.statusPartidaText);
            this.Controls.Add(this.statusPartidaLabel);
            this.Controls.Add(this.vezDoJogadorText);
            this.Controls.Add(this.vezDoJogadorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSairPartida);
            this.MaximizeBox = false;
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alowwalow ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSairPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vezDoJogadorLabel;
        private System.Windows.Forms.Label vezDoJogadorText;
        private System.Windows.Forms.Label statusPartidaLabel;
        private System.Windows.Forms.Label statusPartidaText;
        private System.Windows.Forms.Label statusDaRodadaLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label statusDaRodadaTxt;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador4;
        private System.Windows.Forms.Label lblPontuaçãoJogador1;
        private System.Windows.Forms.Label lblPontuaçãoJogador2;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.Label lblValorCartaJogadaJ1;
        private System.Windows.Forms.Label lblValorCartaJogadaJ2;
        private System.Windows.Forms.Label lblValorCartaJogadaJ3;
        private System.Windows.Forms.Label lblValorCartaJogadaJ4;
    }
}