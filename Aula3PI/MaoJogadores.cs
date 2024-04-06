using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;

namespace Aula3PI
{
    internal class MaoJogadores
    {
        public string idJogadorUm;

        public static List<string[]> maoJogadores(string[] maoJogadores, string[] DebugJogadores)
        {

            List<string[]> listaMaoJogadores = new List<string[]>();

            List<string> maoJogadorUm = new List<string>();
            List<string> maoJogadorDois = new List<string>();
            List<string> maoJogadorTres = new List<string>();
            List<string> maoJogadorQuatro = new List<string>();

            Dictionary<string, string[]> jogadores = new Dictionary<string, string[]>();

            for (int i = 0; i < DebugJogadores.Length; i++)
            {
                string[] aux = DebugJogadores[i].Split(',');
                jogadores.Add("jogador" + (i + 1), aux);
            }


            string idJogadorUm = jogadores["jogador1"][0];
            string idJogadorDois = jogadores["jogador2"][0];
            string idJogadorTres = jogadores["jogador3"][0];
            string idJogadorQuatro = jogadores["jogador4"][0];

            for (int i = 0; i < maoJogadores.Length; i++)
            {
                if (maoJogadores[i].Contains(idJogadorUm))
                {
                    maoJogadorUm.Add(maoJogadores[i]);
                }
                else if (maoJogadores[i].Contains(idJogadorDois))
                {
                    maoJogadorDois.Add(maoJogadores[i]);
                }
                else if (maoJogadores[i].Contains(idJogadorTres))
                {
                    maoJogadorTres.Add(maoJogadores[i]);
                }
                else if (maoJogadores[i].Contains(idJogadorQuatro))
                {
                    maoJogadorQuatro.Add(maoJogadores[i]);
                }
            }

            listaMaoJogadores.Add(maoJogadorUm.ToArray());
            listaMaoJogadores.Add(maoJogadorDois.ToArray());
            listaMaoJogadores.Add(maoJogadorTres.ToArray());
            listaMaoJogadores.Add(maoJogadorQuatro.ToArray());

            return listaMaoJogadores;
        }
    }
}
