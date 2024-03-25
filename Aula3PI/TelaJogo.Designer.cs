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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSairPartida = new System.Windows.Forms.Button();
            this.lstCartasBoxListJogador1 = new System.Windows.Forms.ListBox();
            this.lstCartasBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.variavelPraDebug = new System.Windows.Forms.Label();
            this.lstCartasBoxListJogador2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jogar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.apostar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnSairPartida
            // 
            this.btnSairPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairPartida.Location = new System.Drawing.Point(847, 576);
            this.btnSairPartida.Name = "btnSairPartida";
            this.btnSairPartida.Size = new System.Drawing.Size(75, 23);
            this.btnSairPartida.TabIndex = 1;
            this.btnSairPartida.Text = "button1";
            this.btnSairPartida.UseVisualStyleBackColor = true;
            this.btnSairPartida.Click += new System.EventHandler(this.btnSairPartida_Click);
            // 
            // lstCartasBoxListJogador1
            // 
            this.lstCartasBoxListJogador1.FormattingEnabled = true;
            this.lstCartasBoxListJogador1.Location = new System.Drawing.Point(53, 152);
            this.lstCartasBoxListJogador1.Name = "lstCartasBoxListJogador1";
            this.lstCartasBoxListJogador1.Size = new System.Drawing.Size(172, 173);
            this.lstCartasBoxListJogador1.TabIndex = 2;
            // 
            // lstCartasBtn
            // 
            this.lstCartasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCartasBtn.Location = new System.Drawing.Point(53, 341);
            this.lstCartasBtn.Name = "lstCartasBtn";
            this.lstCartasBtn.Size = new System.Drawing.Size(75, 23);
            this.lstCartasBtn.TabIndex = 3;
            this.lstCartasBtn.Text = "Listar mao jogador";
            this.lstCartasBtn.UseVisualStyleBackColor = true;
            this.lstCartasBtn.Click += new System.EventHandler(this.lstCartasBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mao Jogador 1";
            // 
            // variavelPraDebug
            // 
            this.variavelPraDebug.AutoSize = true;
            this.variavelPraDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variavelPraDebug.ForeColor = System.Drawing.SystemColors.Control;
            this.variavelPraDebug.Location = new System.Drawing.Point(50, 422);
            this.variavelPraDebug.Name = "variavelPraDebug";
            this.variavelPraDebug.Size = new System.Drawing.Size(217, 16);
            this.variavelPraDebug.TabIndex = 5;
            this.variavelPraDebug.Text = "Retorno da jogada do jogador";
            // 
            // lstCartasBoxListJogador2
            // 
            this.lstCartasBoxListJogador2.FormattingEnabled = true;
            this.lstCartasBoxListJogador2.Location = new System.Drawing.Point(352, 152);
            this.lstCartasBoxListJogador2.Name = "lstCartasBoxListJogador2";
            this.lstCartasBoxListJogador2.Size = new System.Drawing.Size(172, 173);
            this.lstCartasBoxListJogador2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(349, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mao Jogador 2";
            // 
            // jogar
            // 
            this.jogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.jogar.Location = new System.Drawing.Point(53, 454);
            this.jogar.Name = "jogar";
            this.jogar.Size = new System.Drawing.Size(75, 23);
            this.jogar.TabIndex = 8;
            this.jogar.Text = "jogar";
            this.jogar.UseVisualStyleBackColor = true;
            this.jogar.Click += new System.EventHandler(this.jogar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(50, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Retorno da jogada do jogador";
            // 
            // apostar
            // 
            this.apostar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apostar.Location = new System.Drawing.Point(53, 546);
            this.apostar.Name = "apostar";
            this.apostar.Size = new System.Drawing.Size(75, 23);
            this.apostar.TabIndex = 10;
            this.apostar.Text = "apostar";
            this.apostar.UseVisualStyleBackColor = true;
            this.apostar.Click += new System.EventHandler(this.apostar_Click);
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.apostar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jogar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCartasBoxListJogador2);
            this.Controls.Add(this.variavelPraDebug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCartasBtn);
            this.Controls.Add(this.lstCartasBoxListJogador1);
            this.Controls.Add(this.btnSairPartida);
            this.Controls.Add(this.label1);
            this.Name = "TelaJogo";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSairPartida;
        private System.Windows.Forms.ListBox lstCartasBoxListJogador1;
        private System.Windows.Forms.Button lstCartasBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label variavelPraDebug;
        private System.Windows.Forms.ListBox lstCartasBoxListJogador2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button jogar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apostar;
    }
}