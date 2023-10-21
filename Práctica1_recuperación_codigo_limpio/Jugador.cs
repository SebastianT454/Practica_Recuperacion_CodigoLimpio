using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Jugador
    {
        private string nombre;
        private Point posicion;
        private int vida;
        private int fuerza;
        private Habilidad habilidad;

        public Jugador(string nombre, Point posición, int vida, int fuerza, Habilidad habilidad)
        {
            this.nombre = nombre;
            this.posicion = posición;
            this.vida = vida;
            this.fuerza = fuerza;
            this.habilidad = habilidad;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Point Posicion
        {
            get { return posicion; }
        }

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        public int Fuerza
        {
            get { return fuerza; }
            set { fuerza = value; }
        }

        private Habilidad Habilidad
        {
            get { return habilidad; }
        }

        public void Mover(Mapa mapa, Direction direccion, Point posicion)
        {
            // Verifica si la nueva posición está ocupada
            Point nuevaPosición = new Point(posicion.X + direccion.X, posicion.Y + direccion.Y);
            if (mapa.jugadores.Contains(nuevaPosición))
            {
                // No se mueve
                return;
            }

            posicion = nuevaPosición;
        }

        public void UsarHabilidad(Jugador jugador)
        {
            jugador.habilidad.Ejecutar();
        }

        public void UsarObjeto(Objeto objeto)
        {

        }
    }
}
