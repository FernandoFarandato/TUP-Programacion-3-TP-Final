
namespace Vista
{
    partial class Frm_marcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_guardar = new System.Windows.Forms.RadioButton();
            this.rb_eliminar = new System.Windows.Forms.RadioButton();
            this.rb_actualizar = new System.Windows.Forms.RadioButton();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_limpiar_datos = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.txt_cuidad = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_guardar);
            this.groupBox1.Controls.Add(this.rb_eliminar);
            this.groupBox1.Controls.Add(this.rb_actualizar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(340, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 98);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacion";
            // 
            // rb_guardar
            // 
            this.rb_guardar.AutoSize = true;
            this.rb_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_guardar.ForeColor = System.Drawing.Color.White;
            this.rb_guardar.Location = new System.Drawing.Point(6, 19);
            this.rb_guardar.Name = "rb_guardar";
            this.rb_guardar.Size = new System.Drawing.Size(84, 22);
            this.rb_guardar.TabIndex = 13;
            this.rb_guardar.TabStop = true;
            this.rb_guardar.Text = "Guardar ";
            this.rb_guardar.UseVisualStyleBackColor = true;
            // 
            // rb_eliminar
            // 
            this.rb_eliminar.AutoSize = true;
            this.rb_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_eliminar.ForeColor = System.Drawing.Color.White;
            this.rb_eliminar.Location = new System.Drawing.Point(6, 40);
            this.rb_eliminar.Name = "rb_eliminar";
            this.rb_eliminar.Size = new System.Drawing.Size(83, 22);
            this.rb_eliminar.TabIndex = 14;
            this.rb_eliminar.TabStop = true;
            this.rb_eliminar.Text = "Eliminar ";
            this.rb_eliminar.UseVisualStyleBackColor = true;
            // 
            // rb_actualizar
            // 
            this.rb_actualizar.AutoSize = true;
            this.rb_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_actualizar.ForeColor = System.Drawing.Color.White;
            this.rb_actualizar.Location = new System.Drawing.Point(6, 60);
            this.rb_actualizar.Name = "rb_actualizar";
            this.rb_actualizar.Size = new System.Drawing.Size(94, 22);
            this.rb_actualizar.TabIndex = 15;
            this.rb_actualizar.TabStop = true;
            this.rb_actualizar.Text = "Actualizar ";
            this.rb_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(674, 552);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(162, 38);
            this.btn_actualizar.TabIndex = 124;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(33, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 24);
            this.label12.TabIndex = 129;
            this.label12.Text = "Datos Marca";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(116, 103);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(168, 23);
            this.txt_nombre.TabIndex = 114;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(40, 103);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 133;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_limpiar_datos
            // 
            this.btn_limpiar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_limpiar_datos.Location = new System.Drawing.Point(28, 180);
            this.btn_limpiar_datos.Name = "btn_limpiar_datos";
            this.btn_limpiar_datos.Size = new System.Drawing.Size(256, 38);
            this.btn_limpiar_datos.TabIndex = 128;
            this.btn_limpiar_datos.Text = "Limpiar Datos";
            this.btn_limpiar_datos.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(1154, 592);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(162, 38);
            this.btn_salir.TabIndex = 126;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(842, 552);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(162, 38);
            this.btn_eliminar.TabIndex = 125;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(674, 596);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(330, 38);
            this.btn_guardar.TabIndex = 123;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.AllowUserToOrderColumns = true;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.telefono});
            this.dgv_proveedores.Location = new System.Drawing.Point(323, 21);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.Size = new System.Drawing.Size(993, 513);
            this.dgv_proveedores.TabIndex = 127;
            // 
            // txt_cuidad
            // 
            this.txt_cuidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuidad.Location = new System.Drawing.Point(116, 132);
            this.txt_cuidad.Name = "txt_cuidad";
            this.txt_cuidad.Size = new System.Drawing.Size(168, 23);
            this.txt_cuidad.TabIndex = 115;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(40, 132);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(54, 18);
            this.lbl_descripcion.TabIndex = 130;
            this.lbl_descripcion.Text = "Cuidad";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(116, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(168, 23);
            this.txt_id.TabIndex = 113;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(43, 74);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 18);
            this.lbl_id.TabIndex = 122;
            this.lbl_id.Text = "ID";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "descripcion";
            this.telefono.HeaderText = "Descripcion";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 700;
            // 
            // Frm_marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1339, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_limpiar_datos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.txt_cuidad);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_marcas";
            this.Text = "Frm_marcas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_guardar;
        private System.Windows.Forms.RadioButton rb_eliminar;
        private System.Windows.Forms.RadioButton rb_actualizar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_limpiar_datos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.TextBox txt_cuidad;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}