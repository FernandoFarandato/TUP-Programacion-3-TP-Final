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

        public bool validarUsuarioPassword()
        {
            return UsuarioDB.validarUsuarioPassword(this.password);         
        }
    }
}

