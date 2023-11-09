using Práctica1_recuperación_codigo_limpio;
using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Mapa obj_mapa = new Mapa(3,3);
        obj_mapa.AsignarJugadores();
        obj_mapa.Mostrar();
        //bool puede_moverse = obj_mapa.JugadorAlien.Mover("izquierda", obj_mapa);
        //Console.WriteLine(puede_moverse);

        obj_mapa.Mostrar();
    }
}

