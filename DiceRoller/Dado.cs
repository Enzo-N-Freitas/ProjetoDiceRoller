using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dado
    {
        private int quantidadeDeLados;
        private int modificador;

        public Dado(int QuantidadeDeLados, int Modificador)
        {
            quantidadeDeLados = QuantidadeDeLados;
            modificador = Modificador;
        }

        public int RolarDado() 
        {
             int Result = new Random().Next(1, quantidadeDeLados + 1) + modificador;
             return Result;
        }
    }
}
