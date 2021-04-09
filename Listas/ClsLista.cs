using System;
using System.Collections.Generic;
using System.Text;

namespace TareaReproductor.Listas
{
    class ClsLista
    {
        public ClsNodo primero;
        public ClsLista()
        {
            primero = null;
        }

        private string leerEntero()
        {
            Console.WriteLine("Ingrese valor, -1 para finalizar");
            return Console.ReadLine();
        }
        public ClsLista crearLista()
        {
            string x;
            primero = null;
            do
            {
                x = leerEntero();
                if (x.Equals( -1))
                {
                    primero = new ClsNodo(x, primero);
                }
            } while (x.Equals( -1));
            return this;
        }
        //nuevos metodos
        public string buscarPosicion(int posicion)
        {
            ClsNodo indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = primero;
            for (i = 1; (i < posicion) && (indice != null); i++)
            {
                indice = indice.enlace;
            }
            return indice.dato;
        }

       
        //insertar de úlitmo
        public ClsLista insertarUltimo(ClsNodo ultimo, string entrada)
        {
            ultimo.enlace = new ClsNodo(entrada);
            ultimo = ultimo.enlace;
            return this;
        }
        public ClsLista insertarCabeza(ClsNodo cabeza, string valor)
        {
            cabeza.enlace = new ClsNodo(valor);
            cabeza = cabeza.enlace;
            return this;
        }
        public ClsNodo buscarLIsta(string destino)
        {
            ClsNodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
            {
                if (destino.Equals(indice.dato))
                {
                    return indice;
                }
            }
            return null;
        }
        public void eliminar(string entrada)
        {
            ClsNodo actual, anterior;
            bool encontrado;
            //inicializan los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            //busqueda del nodo anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato.Equals( entrada));
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//end while

            //Enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial o cabeza, o si es cualquier otro nodeo de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }

        }
        public ClsLista insertarLista(string testigo, string entrada)
        {
            ClsNodo nuevo, anterior;
            anterior = buscarLIsta(testigo);

            if (anterior != null)
            {
                nuevo = new ClsNodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo;
            }
            return this;
        }
        public void visualizar()
        {
            ClsNodo n;
            int k = 0;
            n = primero;
            while (n != null)
            {
                Console.WriteLine(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine((k % 15 != 0 ? " " : "\n"));
            }
        }
        public string[] datosenString() {
            ClsNodo n;
            string datos= "";
            n = primero;
            string[] devuelta;
            int k = 0;
            while (n != null) {
                datos += n.dato +";";
                n = n.enlace;
            }
            datos = datos.TrimEnd(';');
            return devuelta = datos.Split(';');
        }
        //Nueva Inserción por la cabeza
        public ClsLista Add(string dato)
        {
            ClsNodo Aux = new ClsNodo(dato);
            if (primero == null)
            {
                primero = Aux; // Si está vacío será la cabeza
            }
            else
            {
                ClsNodo puntero;
                puntero = primero;
                primero = Aux;
                Aux.enlace = puntero;
            }
            return this;
        }
    }
}
