using Modelo;

namespace Controlador
{
    public class Direccion
    {
        private int id;
        private string calle;
        private string numero;
        private string cuidad;
        private string provincia;
        private int proveedores_id;

        //Contrucotr Completo
        public Direccion(int id, string calle, string numero, string cuidad, string provincia, int proveedores_id)
        {
            this.id = id;
            this.calle = calle;
            this.numero = numero;
            this.cuidad = cuidad;
            this.provincia = provincia;
            this.proveedores_id = proveedores_id;
        }

        //Constructor para carga a base de datos
        public Direccion(string calle, string numero, string cuidad, string provincia, int proveedores_id)
        {
            this.calle = calle;
            this.numero = numero;
            this.cuidad = cuidad;
            this.provincia = provincia;
            this.proveedores_id = proveedores_id;
        }

        //Construcotr para eliminacion de base de datos
        public Direccion(int id)
        {
            this.id = id;
        }

        public void crearDireccion()
        {
            DireccionDB.crearDireccion(this.calle, this.numero, this.cuidad, this.provincia, this.proveedores_id);
        }

        public void eliminarDireccion()
        {
            DireccionDB.eliminarDireccion(this.id);
        }

        public void updateDireccion()
        {
            DireccionDB.updateDireccion(this.calle, this.numero, this.cuidad, this.provincia, this.proveedores_id);
        }

    }
}
