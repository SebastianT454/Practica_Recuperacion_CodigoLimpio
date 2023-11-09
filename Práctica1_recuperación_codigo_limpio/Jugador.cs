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
        private IHabilidad habilidad;

        public Jugador(string nombre, Point posicion, IHabilidad habilidad)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.vida = 0;
            this.fuerza = 0;
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

        public void Mover(Mapa mapa, Point posicion)
        {
            // Verifica si la nueva posición está ocupada

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
