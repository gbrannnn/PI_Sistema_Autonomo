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
            this.btnSairPartida = new System.Windows.Forms.Button();
            this.lblCartaJogada = new System.Windows.Forms.Label();
            this.bntListarCartas = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblCartaAposta = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.txtIdAposta = new System.Windows.Forms.TextBox();
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
            this.btnSairPartida.Location = new System.Drawing.Point(1073, 606);
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
            this.lblCartaJogada.Location = new System.Drawing.Point(47, 547);
            this.lblCartaJogada.Name = "lblCartaJogada";
            this.lblCartaJogada.Size = new System.Drawing.Size(101, 16);
            this.lblCartaJogada.TabIndex = 5;
            this.lblCartaJogada.Text = "Carta Jogada";
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
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1191, 650);
            this.Controls.Add(this.txtIdAposta);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.lblCartaAposta);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.bntListarCartas);
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
        private System.Windows.Forms.Button bntListarCartas;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblCartaAposta;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.TextBox txtIdAposta;
    }
}