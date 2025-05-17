using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakuban
{
    internal class Casilla
    {
        public char Simbolo { get; set; }
        public ConsoleColor Color { get; set; }
        public bool Caminable { get; set; }

        public Casilla(char simbolo, ConsoleColor color, bool caminable = true)
        {
            Simbolo = simbolo;
            Color = color;
            Caminable = caminable;
        }
    }
}

