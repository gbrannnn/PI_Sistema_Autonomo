using Aula3PI;
using Aula3PI.JogadorEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace utils
{
    public class Utils
    {
        public static string[] tratarRetornoDoBanco(string valorRetornado)
        {
            if(valorRetornado == null || valorRetornado == "")
            {
                return null;
            }
            valorRetornado = valorRetornado.Replace("\r", "");
            valorRetornado = valorRetornado.Substring(0, valorRetornado.Length - 1);
            string[] valorTratado = valorRetornado.Split('\n');

            return valorTratado;
        }

        public static Panel VirarCarta(List<Jogador> jogadores, int idJogador, string cartaJogadaNaipe, int cartaJogadaValor)
        {
            Bitmap background = null;
            int pointX = 0, pointY = 0;
            int indexJogador = jogadores.FindIndex(x => x.idJogador == idJogador);

            switch (indexJogador)
            {
                case 0:
                    pointX = 400;
                    pointY = 500;
                    break;
                case 1:
                    pointX = 300;
                    pointY = 400;
                    break;
                case 2:
                    pointX = 400;
                    pointY = 300;
                    break;
                case 3:
                    pointX = 500;
                    pointY = 400;
                    break;
                default: break;
            }

            switch (cartaJogadaNaipe)
            {
                case "C": background = Aula3PI.Properties.Resources.Copas2; break;
                case "E": background = Aula3PI.Properties.Resources.Espadas2; break;
                case "L": background = Aula3PI.Properties.Resources.Lua2; break;
                case "O": background = Aula3PI.Properties.Resources.Ouros2; break;
                case "P": background = Aula3PI.Properties.Resources.Paus2; break;
                case "S": background = Aula3PI.Properties.Resources.Estrela2; break;
                case "T": background = Aula3PI.Properties.Resources.Triângulo2; break;
                default: break;
            }

            Point point = new Point(pointX, pointY);
            Size size = new Size(60, 80);
            Panel painelCarta = new Panel();
            painelCarta.Location = point;
            painelCarta.Size = size;
            painelCarta.BackgroundImageLayout = ImageLayout.Stretch;
            painelCarta.BackgroundImage = background;
            painelCarta.Tag = idJogador;
            return painelCarta;
        }

        public static int QuantidadeJogadores(List<Jogador> jogadores)
        {
            int resultado = 0;

            switch (jogadores.Count)
            {
                case 2:
                    resultado = 2;
                    break;
                case 3:
                    resultado = 3;
                    break;
                case 4:
                    resultado = 4;
                    break;
                default:
                    break;
            }

            return resultado;
        }
    }
}
