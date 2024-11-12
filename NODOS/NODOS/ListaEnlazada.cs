using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODOS
{
    using System;

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void Agregar(string dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine($"Nodo con dato {dato} agregado.");
        }


        public void Eliminar(string dato)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine($"Nodo con dato {dato} eliminado.");
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                Console.WriteLine($"Nodo con dato {dato} no encontrado.");
            }
            else
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                Console.WriteLine($"Nodo con dato {dato} eliminado.");
            }
        }

        public void Buscar(string dato)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    Console.WriteLine($"Nodo con dato {dato} encontrado.");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine($"Nodo con dato {dato} no encontrado.");
        }

        public void Modificar(string datoActual, string nuevoDato)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == datoActual)
                {
                    actual.Dato = nuevoDato;
                    Console.WriteLine($"Nodo con dato {datoActual} modificado a {nuevoDato}.");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine($"Nodo con dato {datoActual} no encontrado.");
        }

        public void Imprimir()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = cabeza;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write($"{actual.Dato} -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

}
