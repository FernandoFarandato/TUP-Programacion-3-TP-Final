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
            return UsuarioBD.validarUsuarioPassword(this.password);         
        }
        //Cambiar
        public String cargarUsuario()
        {
            return UsuarioBD.cargarUsuario();
        }
        //Cambiar
        public string passwordActual()
        {
            return UsuarioBD.cargarPassword();
        }
        //Cambiar
        public void modificarUsuario()
        {
            UsuarioBD.modificarUsuario(this.usuario, this.password);
        }
    }
}

