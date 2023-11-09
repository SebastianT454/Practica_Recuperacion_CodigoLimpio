using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1_recuperación_codigo_limpio
{
    public interface IHabilidad
    {
        internal string Tipo { get; set; }
        internal string Representacion { get; set; }

    }

    public class HabilidadAlien : IHabilidad
    {
        public string Tipo { get; set; } = "Alien";
        public string Representacion { get; set; } = "#";

        public void Ejecutar(Mapa mapa, int fila, int columna)
        {
            string[][] matrix = mapa.Matriz;
            int m = mapa.TamanoMatriz.X;
            int n = mapa.TamanoMatriz.Y;

            if (fila >= 0 && fila < m && columna >= 0 && columna < n)
            {
                matrix[fila][columna] = Representacion;
            }
        }
    }

    public class HabilidadDepredador : IHabilidad
    {
        public string Tipo { get; set; } = "Depredador";
        public string Representacion { get; set; } = "!";

        public void Ejecutar(Mapa mapa, Jugador jugador)
        {
            string[][] matrix = mapa.Matriz;
            int fila = jugador.Posicion.X;

            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[fila][i] = Representacion;
            }
        }
    }

}
