using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace AppCalculadora
{
    public class Calcular()
    {

        public static List<string> historico { get; set; } = new List<string>();

        private int i = 0;

        public int Somar(int val1, int val2)
        {
            int result = val1 + val2;

            historico.Insert(i++, val1 + "+" + val2 + "=" + result);
            return result;
        }

        public int Subtrair(int val1, int val2)
        {
            int result = val1 - val2;

            historico.Insert(i++, val1 + "-" + val2 + "=" + result);
            return result;
        }


        public int Multiplicar(int val1, int val2)
        {
            int result = val1 * val2;

            historico.Insert(i++, val1 + "*" + val2 + "=" + result);
            return result;
        }

        public int Dividir(int val1, int val2)
        {
            int result = val1 / val2;

            historico.Insert(i++, $"{val1} / {val2} = {result}");
            return result;
        }

    public List<string> Listar()
        {
            List<string> ultimosTres = historico
                                        .Skip(historico.Count -3)
                                        .Take(3)
                                        .OrderByDescending(n =>n)
                                        .ToList();
            return ultimosTres;
        }

    }
}