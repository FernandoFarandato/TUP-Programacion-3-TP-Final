using System;
using System.Windows.Forms;
using Controlador;
using View;

namespace Vista
{
    public partial class Frm_login : Form
    {
        
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text.Trim();
            string password = txt_password.Text.Trim();

            Usuario usuario = new Usuario(user, password);

            if (usuario.validarUsuarioPassword())
            {
                this.Hide();
                Frm_main frm_main = new Frm_main(user);
                frm_main.Show();
            }
            else
            {
                Utils.messageWarning(this, "Credenciales Incorrectas");
                txt_user.Text = "";
                txt_password.Text = "";
                txt_user.Focus();
            }            
        }

        private void txt_user_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // KeyChar = 13 : Enter
            if (e.KeyChar == 13)
            {
                if (txt_user.Text.Trim().Length > 0)
                {
                    txt_password.Focus();
                }
                else
                {
                    Utils.messageWarning(this, "Write a valid User name");
                }
            }
        }

        private void txt_password_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //KeyChar = 13 : Enter
            if (e.KeyChar == 13)
            {
                if (txt_password.Text.Trim().Length > 0)
                {
                    btn_login.Focus();
                }
                else
                {
                    Utils.messageWarning(this, "Write a valid password");
                }
            }
        }

    }
}
