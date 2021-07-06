using Modelo;


namespace Controlador
{
    public class Precio
    {
        private int id;
        private string precio;
        private int productos_id;

        //Constructor Completo
        public Precio(int id, string precio, int productos_id)
        {
            this.id = id;
            this.precio = precio;
            this.productos_id = productos_id;
        }

        public Precio(string precio, int producots_id)
        {
            this.precio = precio;
            this.productos_id = producots_id;
        }

        public override string ToString()
        {
            return $"ID: {this.id}, Precio: {this.precio}, ID Producto: {this.productos_id}";
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
