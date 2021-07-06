using Modelo;
using System.Data;

namespace Controlador
{
    public class Marca
    {
        private int id;
        private string nombre_marca;
        private string descripcion_marca;

        //Construcotr Completo. Contructor para actualizacion a base de datos
        public Marca(int id, string nombre_marca, string descripcion_marca)
        {
            this.id = id;
            this.nombre_marca = nombre_marca;
            this.descripcion_marca = descripcion_marca;
        }

        //Constructor para carga a base de datos
        public Marca(string nombre_marca, string descripcion_marca)
        {
            this.nombre_marca = nombre_marca;
            this.descripcion_marca = descripcion_marca;
        }

        //Contructor para eliminacion de base de datos
        public Marca(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"ID: {this.id}, Nombre: {this.nombre_marca}, Descripcion: {this.descripcion_marca}";
        }

        public void crearMarca()
        {
            MarcaDB.crearMarca(this.nombre_marca, this.descripcion_marca);
        }

        public void eliminarMarca()
        {
            MarcaDB.eliminarMarca(this.id);
        }

        public void updateMarca()
        {
            MarcaDB.updateMarca(this.id, this.nombre_marca, this.descripcion_marca);
        }

        public static DataTable traerMarcas()
        {
            return MarcaDB.traerMarcas();
        }
    }
}
