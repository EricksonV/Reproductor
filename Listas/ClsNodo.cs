using System;
using System.Collections.Generic;
using System.Text;

namespace TareaReproductor.Listas
{
    class ClsNodo
    {
        public string dato;
        public ClsNodo enlace;

        public ClsNodo(string x)
        {
            dato = x;
            enlace = null;
        }
        public ClsNodo(string x, ClsNodo n)
        {
            dato = x;
            enlace = n;
        }

        public string getDato()
        {
            return dato;
        }
        public ClsNodo getEnlace()
        {
            return enlace;
        }
        public void setEnlace(ClsNodo enlace)
        {
            this.enlace = enlace;
        }
    }
}
