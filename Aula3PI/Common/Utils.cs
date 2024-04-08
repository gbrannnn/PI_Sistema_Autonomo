using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public class Utils
    {
        public static string[] tratarRetornoDoBanco(string valorRetornado)
        {
            valorRetornado = valorRetornado.Replace("\r", "");
            valorRetornado = valorRetornado.Substring(0, valorRetornado.Length - 1);
            string[] valorTratado = valorRetornado.Split('\n');

            return valorTratado;
        }
    }
}
