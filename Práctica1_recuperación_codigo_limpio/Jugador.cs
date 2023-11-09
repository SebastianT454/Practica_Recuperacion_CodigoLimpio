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
            set { posicion = value; }
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

        private IHabilidad Habilidad
        {
            get { return habilidad; }
        }

        public bool Mover(string Direccion, Mapa mapa)
        {
            Jugador jugador = this;
            Point posicion_original = jugador.Posicion;

            if (Direccion == "arriba")
            {
                jugador.posicion.X -= 1;
            }
            else if (Direccion == "abajo")
            {
                jugador.posicion.X += 1;
            }

            else if (Direccion == "izquierda")
            {
                jugador.posicion.Y -= 1;
            }

            else if (Direccion == "derecha")
            {
                jugador.posicion.Y += 1;
            }
            else
            {
                Console.WriteLine("La dirección no es válida.");
                return false;
            }

            int filas = mapa.TamanoMatriz.X;
            int columnas = mapa.TamanoMatriz.Y;

            if (jugador.posicion.X >= 0 && jugador.posicion.X < columnas && jugador.posicion.Y >= 0 && jugador.posicion.Y < filas)
            {
                mapa.Matriz[jugador.posicion.X][jugador.posicion.Y] = jugador.Nombre;
                mapa.Matriz[posicion_original.X][posicion_original.Y] = "-";
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UsarHabilidad(Mapa mapa, int fila, int columna)
        {
            if (Nombre == "X")
            {
                IHabilidad habilidad = Habilidad;

                HabilidadAlien? habilidadAlien = habilidad as HabilidadAlien;

                if (habilidadAlien != null)
                {
                    habilidadAlien.Ejecutar(mapa, fila, columna);
                }
            }
            else if(Nombre == "Y") 
            {
                IHabilidad habilidad = Habilidad;

                HabilidadDepredador? habilidadDepredador = habilidad as HabilidadDepredador;

                if (habilidadDepredador != null)
                {
                    habilidadDepredador.Ejecutar(mapa, this);
                }
            }
            else
            {
                Console.WriteLine("Jugador no se encontro.. Grave!");
            }
        }

        public void UsarObjeto(Objeto objeto)
        {
            // Comprobar el tipo de objeto
            switch (objeto.Tipo)
            {
                case TipoObjeto.Ventaja:
                    switch (objeto.Efecto)
                    {
                        case EfectoObjeto.Fuerza:
                            this.Fuerza += 5;
                            break;
                        case EfectoObjeto.Vida:
                            this.Vida += 5;
                            break;
                    }
                    break;
                case TipoObjeto.Desventaja:
                    switch (objeto.Efecto)
                    {
                        case EfectoObjeto.Fuerza:
                            this.Fuerza -= 5;
                            break;
                        case EfectoObjeto.Vida:
                            this.Vida -= 5;
                            break;
                    }
                    break;
            }

            // Mostrar el estado del personaje después de usar el objeto
            Console.WriteLine("Usaste un objeto de tipo {0} y efecto {1}. Tu estado actual es:", objeto.Tipo, objeto.Efecto);
            Console.WriteLine("Vida: {0}, Fuerza: {1}", this.Vida, this.Fuerza);
        }
    }
}
