﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    abstract class ElementStrukt
    {
        /* --- Pola klasy --- */
        
        protected int[,] strukturaElementu;

        protected string nazwaElementu;
        protected int wielkoscElementu;  // Długość boku lub promienia
        protected int nachylenieOdcinka; // Tylko dla odcinka! (ew. poprawić)
        protected int wielkoscElementuCalkowita;


        /* --- Konstruktor --- */
        
        public ElementStrukt() {}

       
        /* --- Właściwości --- */

        public string NazwaElementu
        {
            get { return nazwaElementu; }
        }

        public int WielkoscElementu
        {
            get { return wielkoscElementu; }
        }

        public int WielkoscElementuCalkowita
        {
            get { return wielkoscElementuCalkowita; }
        }

        public int Nachylenie       // Tylko dla odcinka!
        {
            get { return nachylenieOdcinka; }
        }

        public int[,] StrukturaElementu
        {
            get { return strukturaElementu; }
        }
    }
}
