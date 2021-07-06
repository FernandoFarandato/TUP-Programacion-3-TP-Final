using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controlador
{
    public class Producto
    {
        private int id;
        private string nombre_producto;
        private string descripcion_producto;
        private int marcas_id;

        //Construcotr para eliminacio de base de datos
        public Producto(int id)
        {
            this.id = id;
        }

        //Contrucotr para carga a base de datos
        public Producto(string nombre_producto, string descripcion_producto, int marcas_id)
        {
            this.nombre_producto = nombre_producto;
            this.descripcion_producto = descripcion_producto;
            this.marcas_id = marcas_id;
        }

        //Constructor para actualizacion a base de datos
        public Producto(int id, string nombre_producto, string descripcion_producto, int marcas_id)
        {
            this.id = id;
            this.nombre_producto = nombre_producto;
            this.descripcion_producto = descripcion_producto;
            this.marcas_id = marcas_id;
        }

        public void crearProducto()
        {
           ProductoDB.crearProducto(this.nombre_producto, this.descripcion_producto, this.marcas_id);
        }

        public void eliminarProducto()
        {
            ProductoDB.eliminarProducto(this.id);
        }

        public void updateProducto()
        {
            ProductoDB.updateProducto(this.id, this.nombre_producto, this.descripcion_producto, this.marcas_id);
        }

        public static DataTable traerProductos_Precio_NombreMarca_NombrePorveedor()
        {
            return ProductoDB.traerProductos_Precio_NombreMarca_NombrePorveedor();
        }
    }
}
