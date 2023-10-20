using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public class Mapa
    {
        private int[,] matriz;
        private int tamaño;
        private List<Objeto> objetos;
        private List<Jugador> jugadores;

        public Mapa(int[,] matriz, int tamaño)
        {
            this.matriz = matriz;
            this.tamaño = tamaño;
            this.objetos = new List<Objeto>();
            this.jugadores = new List<Jugador>();
        }

        public void Mostrar()
        {
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    if (jugadores.Contains((i, j)))
                    {
                        Console.Write(jugadores[(i, j)].Nombre);
                    }
                    else if (objetos.Contains((i, j)))
                    {
                        Console.Write(objetos[(i, j)].Tipo);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void ColocarObjetos()
        {
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    if (!jugadores.Contains((i, j)))
                    {
                        objetos.Add(new Objeto(Enum.GetValues(typeof(TipoObjeto)).GetValue(Random.Range(0, Enum.GetValues(typeof(TipoObjeto)).Length)), Enum.GetValues(typeof(EfectoObjeto)).GetValue(Random.Range(0, Enum.GetValues(typeof(EfectoObjeto)).Length))));
                    }
                }
            }
        }

        public void VerificarColisiones()
        {
            foreach (Jugador jugador in jugadores)
            {
                foreach (Objeto objeto in objetos)
                {
                    if (jugador.Posicion == objeto.Posicion)
                    {
                        jugador.UsarObjeto(objeto);
                    }
                }
            }
        }
    }

}
