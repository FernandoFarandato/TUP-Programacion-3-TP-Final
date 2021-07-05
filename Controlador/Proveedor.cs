using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
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
        public Proveedor(int id, string nombre, int es_minorista, string dni, string cuit, string ibb, string porcentage_ganancia)
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
        public Proveedor(string nombre, int es_minorista, string dni, string cuit, string ibb, string porcentage_ganancia)
        {
            this.nombre = nombre;
            this.es_minorista = es_minorista;
            this.dni = dni;
            this.cuit = cuit;
            this.ibb = ibb;
            this.porcentage_ganancia = porcentage_ganancia;
        }


        public void crearProveedor()
        {
            ProveedorDB.crearProveedor(this.nombre, this.es_minorista, this.dni, this.porcentage_ganancia, this.cuit, this.ibb);
        }

    }
}
