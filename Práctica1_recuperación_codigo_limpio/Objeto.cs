using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public class Objeto
    {
        private TipoObjeto tipo;
        private EfectoObjeto efecto;
        private Point posicion;

        public Objeto(TipoObjeto tipo, EfectoObjeto efecto, Point posicion)
        {
            this.tipo = tipo;
            this.efecto = efecto;
            this.posicion = posicion;
        }

        public TipoObjeto Tipo
        {
            get { return tipo; }
        }

        public EfectoObjeto Efecto
        {
            get { return efecto; }
        }

        public Point Posicion
        {
            get { return posicion; }
        }
    }

}
