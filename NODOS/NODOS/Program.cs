namespace NODOS
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            lista.Agregar("Ismael");
            lista.Agregar("Alejandro");
            lista.Agregar("Liquez");

            lista.Imprimir();

            lista.Buscar("Ismael");

            lista.Modificar("Ismael", "Muñoz");

            lista.Imprimir();

            lista.Eliminar("Liquez");

            lista.Imprimir();
        }
    }


}


