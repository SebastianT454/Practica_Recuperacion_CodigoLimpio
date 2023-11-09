using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public class Mapa
    {
        private string[][] matriz;
        private Point tamano_matriz;
        private List<Objeto> objetos;
        private List<Jugador> jugadores;

        public Mapa(int m, int n)
        {
            this.matriz = Mapa.Crear_Matriz(m,n);
            this.tamano_matriz = new Point(m,n);
            this.objetos = new List<Objeto>();
            this.jugadores = new List<Jugador>();
        }
        public string[][] Matriz
        {
            get { return matriz; }
        }
        public Point TamanoMatriz
        {
            get { return tamano_matriz; }
        }
        public List<Objeto> Objetos
        {
            get { return objetos; }
        }
        public List<Jugador> Jugadores
        {
            get { return jugadores; }
        }
        public static string[][] Crear_Matriz(int m, int n)
        {
            string[][] matrix = new string[m][];

            for (int i = 0; i < m; i++)
            {
                matrix[i] = new string[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = "-";
                }
            }

            return matrix;
        }

        public void Mostrar()
        {
            string[][] matrix = this.matriz;

            // Recorremos las filas de la matriz
            for (int i = 0; i < matrix.Length; i++)
            {
                // Imprimimos la fila i
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(" " + matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        
        public void AsignarJugadores() 
        {
            string[][] matrix = matriz;
            int m = tamano_matriz.X;
            int n = tamano_matriz.Y;

            IHabilidad habilidad_Alien = new HabilidadAlien();
            IHabilidad habilidad_Depredador = new HabilidadDepredador();

            // Generamos un objeto de jugador X.
            Jugador jugadorX = new Jugador("X", new Point(0, 0), habilidad_Alien);

            // Generamos un objeto de jugador Y.
            Jugador jugadorY = new Jugador("Y", new Point(m - 1, n - 1), habilidad_Depredador);

            // Asignamos los jugadores.
            matrix[0][0] = jugadorX.Nombre;
            matrix[m - 1][n - 1] = jugadorY.Nombre;
        }
        
        public void ColocarObjetos()
        {

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
