﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02_02_exception_debug.model
{
    /// <summary>
    /// Négyzet osztály
    /// </summary>
    class Square
    {
        /// <summary>
        /// A négyzet oldala.
        /// </summary>
        private double side;

        /// <summary>
        /// Négyzetet oldalával létrehozó konstruktor.
        /// </summary>
        /// <param name="side">A négyzet oldala</param>
        public Square(double side)
        {
              this.side = side;
        }

        /// <summary>
        /// Side tulajdonság get és set metódussal..
        /// </summary>
        public double Side
        {
            get 
            { 
                return side; 
            }
            set
            {
                  side = value;
            }
        }

        /// <summary>
        /// A négyzet kerület tulajdonsága. Csak olvasható.
        /// </summary>
        public double District
        {
            get
            {
                double district = 4 * side;
                return district;
            }
        }

        /// <summary>
        /// A négyzet terület tulajdonsága. Csak olvasható.
        /// </summary>
        public double Area
        {
            get
            {
                double area = side * side;
                return area;
            }
        }

        /// <summary>
        /// A négyzet adatait ilyen alakban jelenítjük meg.
        /// </summary>
        /// <returns>A négyzet odlala és a hozzá tartozó szöveg.</returns>
        public override string ToString()
        {
            return side + " méter a négyzet oldala.";
        }
    }
}
