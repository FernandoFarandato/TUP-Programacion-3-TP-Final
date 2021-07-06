using Modelo;


namespace Controlador
{
    public class Telefono
    {

        private int id;
        private string numero_contacto;
        private int proveedores_id;

        public Telefono(int id, string numero_contacto, int proveedores_id) : this(id)
        {
            this.numero_contacto = numero_contacto;
            this.proveedores_id = proveedores_id;
        }

        //Constructor para carga a base de datos
        public Telefono(string numero_contacto, int proveedores_id)
        {
            this.numero_contacto = numero_contacto;
            this.proveedores_id = proveedores_id;
        }

        //Constructor para la busqueda o eliminacion de la base de datos.
        public Telefono(int proveedores_id)
        {
            this.proveedores_id = proveedores_id;
        }

        public void crearTelefono()
        {
            TelefonoDB.crearTelefono(this.numero_contacto, this.proveedores_id);
        }

        public void eliminarTelefono()
        {
            TelefonoDB.eliminarTelefono(this.proveedores_id);
        }

        public void updateTelefono()
        {
            TelefonoDB.updateTelefono(this.numero_contacto, this.proveedores_id);
        }
    }
}
