using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public class Objeto
    {
        private TipoObjeto tipo;
        private EfectoObjeto efecto;

        public Objeto(TipoObjeto tipo, EfectoObjeto efecto)
        {
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
    }

}
