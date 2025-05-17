using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakuban
{
    internal class Mapa
    {
        public int alto;
        public int ancho;
        public Casilla[,] casillas;

        public Mapa(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
            casillas = new Casilla[ancho, alto];
            Inicializar();
        }

        // MAPA
        private void Inicializar()
        {
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (EsBorde(i, j))
                    {
                        casillas[j, i] = new Casilla('#', ConsoleColor.DarkGray)
                        {
                            Caminable = false
                        };
                    }
                    else
                    {
                        casillas[j, i] = new Casilla('╬', ConsoleColor.DarkYellow);
                    }
                }
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < alto; i++) // fila
            {
                for (int j = 0; j < ancho; j++) // columna
                {
                    var casilla = casillas[j, i]; // columna (x), fila (y)

                    Console.ForegroundColor = casilla.Color;
                    Console.Write(casilla.Simbolo);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        // FUNCIONES AUXILIARES
        public bool EsBorde(int fila, int columna)
        {
            return fila == 0 || fila == alto - 1 || columna == 0 || columna == ancho - 1;
        }
    }
}
