using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public enum TipoObjeto
    {
        Ventaja,
        Desventaja
    }

    public enum EfectoObjeto
    {
        Fuerza,
        Vida
    }

    public class Objeto
    {
        private string nombre;
        private Point posicion;
        private TipoObjeto tipo;
        private EfectoObjeto efecto;

        public Objeto(string nombre, Point posicion, TipoObjeto tipo, EfectoObjeto efecto)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.tipo = tipo;
            this.efecto = efecto;
        }

        public TipoObjeto Tipo
        {
            get { return tipo; }
        }

        public EfectoObjeto Efecto
        {
            get { return efecto; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public Point Posicion
        {
            get { return posicion; }
        }
    }

}
