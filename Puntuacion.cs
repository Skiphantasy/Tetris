/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ....: 2º Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Puntuacion: IComparable
    {
        string nombre;
        int puntuacion;

        public Puntuacion(string nombre, int puntuacion)
        {
            this.nombre = nombre;
            this.puntuacion = puntuacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntuacion; set => puntuacion = value; }

        public int CompareTo(object obj)
        {
            Puntuacion p = (Puntuacion)obj;

            if (p != null)
            {
                return this.puntuacion.CompareTo(p.puntuacion);
            }
            else
            {
                throw new ArgumentException("Not a Student");
            }
        }
    }
}
