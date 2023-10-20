using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public class Jugador
    {
        private string nombre;
        private Point posición;
        private int vida;
        private int fuerza;
        private Habilidad habilidad;

        public Jugador(string nombre, Point posición, int vida, int fuerza, Habilidad habilidad)
        {
            this.nombre = nombre;
            this.posición = posición;
            this.vida = vida;
            this.fuerza = fuerza;
            this.habilidad = habilidad;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Point Posición
        {
            get { return posición; }
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

        public Habilidad Habilidad
        {
            get { return habilidad; }
        }

        public void Mover(Direction dirección)
        {
            posición = posición + dirección;
        }

        public void UsarHabilidad()
        {
            habilidad.Ejecutar();
        }

    }
