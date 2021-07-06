using Modelo;


namespace Controlador
{
    public class Precio
    {
        private int id;
        private string precio;
        private int productos_id;

        public Precio(string precio, int producots_id)
        {
            this.precio = precio;
            this.productos_id = producots_id;
        }

        public Precio(int id, string precio, int producots_id)
        {
            this.id = id;
            this.precio = precio;
            this.productos_id = producots_id;
        }

        public void crearPrecio()
        {
            PrecioDB.crearPrecio(this.precio, this.productos_id);
        }

        public static void eliminarPrecio(int productos_id)
        {
            PrecioDB.eliminarPrecio(productos_id);
        }

    }
}
