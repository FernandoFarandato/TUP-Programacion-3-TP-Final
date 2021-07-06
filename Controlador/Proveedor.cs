using Modelo;
using System.Data;

namespace Controlador
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private int es_minorista;
        private string dni;
        private string cuit;
        private string ibb;
        private string porcentage_ganancia;

        //Constructor completo
        public Proveedor(int id, string nombre, int es_minorista, string porcentage_ganancia, string dni, string cuit, string ibb )
        {
            this.id = id;
            this.nombre = nombre;
            this.es_minorista = es_minorista;
            this.dni = dni;
            this.cuit = cuit;
            this.ibb = ibb;
            this.porcentage_ganancia = porcentage_ganancia;
        }
        //Constructor para carga a base de datos
        public Proveedor(string nombre, int es_minorista, string porcentage_ganancia, string dni, string cuit, string ibb)
        {
            this.nombre = nombre;
            this.es_minorista = es_minorista;
            this.dni = dni;
            this.cuit = cuit;
            this.ibb = ibb;
            this.porcentage_ganancia = porcentage_ganancia;
        }

        //Constructor para eliminacion de base de datos
        public Proveedor(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"ID: {this.id}, Nombre: {this.nombre}, Es Minorista: {this.es_minorista}, Porcentage Ganancia: {this.porcentage_ganancia}, DNI: {this.dni}, CUIT: {this.cuit}, IBB: {this.ibb}";
        }

        public void crearProveedor()
        {
            ProveedorDB.crearProveedor(this.nombre, this.es_minorista, this.porcentage_ganancia, this.dni, this.cuit, this.ibb);
        }

        public void eliminarProveedor()
        {
            ProveedorDB.eliminarProveedor(this.id);
        }

        public int traerID()
        {
            return ProveedorDB.traerID(this.nombre, this.es_minorista, this.dni, this.cuit);
        }

        public static DataTable traerProveedores_Direccion_Telefono() {

            return ProveedorDB.traerProveedores_Direccion_Telefono();
        }

        public static DataTable traerProveedores_Nombre()
        {
            return ProveedorDB.traerProveedores_Nombre();
        }

        public void updateProveedor()
        {
            ProveedorDB.updateProveedor(this.id, this.nombre, this.es_minorista, this.porcentage_ganancia, this.dni, this.cuit, this.ibb);
        }

        public static int traerIDviaProducto(string nombre, int id_producto)
        {
            return ProveedorDB.traerIDviaProducto(nombre, id_producto);
        }
    }
}
