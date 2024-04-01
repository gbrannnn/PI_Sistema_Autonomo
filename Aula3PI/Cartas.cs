using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;

namespace Aula3PI
{
    internal class Cartas
    {
        public static List<Panel> criacaoCarta(string[] maoJogadores)
        {
            List<Panel> listaCartas = new List<Panel>();

            Point point = new Point();
            point.X = 100;
            point.Y = 30;

            Size size = new Size();
            size.Width = 60;
            size.Height = 100;
            
            for (int i = 0; i < maoJogadores.Length/2; i++) {

                Panel carta = new Panel();
                point.X = point.X + (size.Width + 10);
                carta.Location = point;
                carta.Size = size;
                carta.BackgroundImageLayout = ImageLayout.Stretch;

                string naipe = maoJogadores[i].Substring(maoJogadores[i].Length - 1);

                switch (naipe)
                {
                    case "C":
                        carta.BackgroundImage = Properties.Resources.Copas1;
                        break;
                    case "E":
                        carta.BackgroundImage = Properties.Resources.Espadas1;
                        break;
                    case "L":
                        carta.BackgroundImage = Properties.Resources.Lua1;
                        break;
                    case "O":
                        carta.BackgroundImage = Properties.Resources.Ouros1;
                        break;
                    case "P":
                        carta.BackgroundImage = Properties.Resources.Paus1;
                        break;
                    case "S":
                        carta.BackgroundImage = Properties.Resources.Estrela1;
                        break;
                    case "T":
                        carta.BackgroundImage = Properties.Resources.Triângulo1;
                        break;
                    default:
                        break;
                }
                listaCartas.Add(carta);
            }

            return listaCartas;
        }
    }
}
