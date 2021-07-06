using Modelo;
using System.Data;

namespace Controlador
{
    public class Producto
    {
        private int id;
        private string nombre_producto;
        private string descripcion_producto;
        private int marcas_id;
        int id_proveedor;

        //Construcotr para eliminacio de base de datos
        public Producto(int id, int id_proveedor)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
        }

        //Contrucotr para carga a base de datos
        public Producto(string nombre_producto, string descripcion_producto, int marcas_id, int id_proveedor)
        {
            this.nombre_producto = nombre_producto;
            this.descripcion_producto = descripcion_producto;
            this.marcas_id = marcas_id;
            this.id_proveedor = id_proveedor;
        }

        //Constructor para actualizacion a base de datos
        public Producto(int id, string nombre_producto, string descripcion_producto, int marcas_id, int id_proveedor)
        {
            this.id = id;
            this.nombre_producto = nombre_producto;
            this.descripcion_producto = descripcion_producto;
            this.marcas_id = marcas_id;
            this.id_proveedor = id_proveedor;
        }

        public void crearProducto()
        {
           ProductoDB.crearProducto(this.nombre_producto, this.descripcion_producto, this.marcas_id, this.id_proveedor);
        }

        public void crearRelacionProductoProveedor()
        {
            ProductoDB.crearRelacionProductoProveedor(this.id_proveedor, this.id);
        }

        public void eliminarRelacionProductoProveedor()
        {
            ProductoDB.eliminarRelacionProductoProveedor(this.id, this.id_proveedor);
        }

        public void eliminarProducto()
        {
            ProductoDB.eliminarProducto(this.id);
        }

        public int traerID()
        {
            return ProductoDB.traerID(this.nombre_producto, this.descripcion_producto, this.marcas_id)
;        }
        public void updateProducto()
        {
            ProductoDB.updateProducto(this.id, this.nombre_producto, this.descripcion_producto, this.marcas_id, this.id_proveedor);
        }

        public static DataTable traerProductos_Precio_NombreMarca_NombrePorveedor()
        {
            return ProductoDB.traerProductos_Precio_NombreMarca_NombrePorveedor();
        }
    }
}
