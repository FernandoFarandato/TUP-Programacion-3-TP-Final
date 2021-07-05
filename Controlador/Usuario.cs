using System;
using Modelo;

namespace Controlador
{
    public class Usuario
    {
        private string usuario;
        private string password;


        //Contructor completo.
        public Usuario(String usuario, String password)
        {
            this.usuario = usuario;
            this.password = password;
        }
        
        // Validacion de Usuario y Password.
        public bool validarUsuarioPassword()
        {
            return UsuarioDB.validarUsuarioPassword(this.password);         
        }
        //Cambiar
        public String cargarUsuario()
        {
            return "Hola";// UsuarioBD.cargarUsuario();
        }
        //Cambiar
        public string passwordActual()
        {
            return "hola"; //UsuarioBD.cargarPassword();
        }
        //Cambiar
        public void modificarUsuario()
        {
            //UsuarioBD.modificarUsuario(this.usuario, this.password);
        }
    }
}

