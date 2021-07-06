
namespace Vista
{
    partial class Frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_password.Location = new System.Drawing.Point(16, 61);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 18);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_user.Location = new System.Drawing.Point(16, 21);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(40, 18);
            this.lbl_user.TabIndex = 12;
            this.lbl_user.Text = "User";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_password.Location = new System.Drawing.Point(123, 61);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(272, 24);
            this.txt_password.TabIndex = 9;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress_1);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_user.Location = new System.Drawing.Point(123, 21);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(272, 24);
            this.txt_user.TabIndex = 8;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress_1);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_login.Location = new System.Drawing.Point(259, 106);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(136, 36);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(424, 169);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_login;
    }
}

