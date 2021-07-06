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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_operaciones = new System.Windows.Forms.GroupBox();
            this.rb_actualizar = new System.Windows.Forms.RadioButton();
            this.rb_eliminar = new System.Windows.Forms.RadioButton();
            this.rb_guardar = new System.Windows.Forms.RadioButton();
            this.lbl_titulo_1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_limpiar_datos = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.id_marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_operaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_operaciones
            // 
            this.gb_operaciones.Controls.Add(this.rb_actualizar);
            this.gb_operaciones.Controls.Add(this.rb_eliminar);
            this.gb_operaciones.Controls.Add(this.rb_guardar);
            this.gb_operaciones.ForeColor = System.Drawing.Color.White;
            this.gb_operaciones.Location = new System.Drawing.Point(335, 511);
            this.gb_operaciones.Name = "gb_operaciones";
            this.gb_operaciones.Size = new System.Drawing.Size(135, 95);
            this.gb_operaciones.TabIndex = 55;
            this.gb_operaciones.TabStop = false;
            this.gb_operaciones.Text = "Operacion";
            // 
            // rb_actualizar
            // 
            this.rb_actualizar.AutoSize = true;
            this.rb_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_actualizar.ForeColor = System.Drawing.Color.White;
            this.rb_actualizar.Location = new System.Drawing.Point(24, 61);
            this.rb_actualizar.Name = "rb_actualizar";
            this.rb_actualizar.Size = new System.Drawing.Size(90, 22);
            this.rb_actualizar.TabIndex = 43;
            this.rb_actualizar.TabStop = true;
            this.rb_actualizar.Text = "Actualizar";
            this.rb_actualizar.UseVisualStyleBackColor = true;
            this.rb_actualizar.CheckedChanged += new System.EventHandler(this.rb_actualizar_CheckedChanged);
            // 
            // rb_eliminar
            // 
            this.rb_eliminar.AutoSize = true;
            this.rb_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_eliminar.ForeColor = System.Drawing.Color.White;
            this.rb_eliminar.Location = new System.Drawing.Point(24, 39);
            this.rb_eliminar.Name = "rb_eliminar";
            this.rb_eliminar.Size = new System.Drawing.Size(79, 22);
            this.rb_eliminar.TabIndex = 42;
            this.rb_eliminar.TabStop = true;
            this.rb_eliminar.Text = "Eliminar";
            this.rb_eliminar.UseVisualStyleBackColor = true;
            this.rb_eliminar.CheckedChanged += new System.EventHandler(this.rb_eliminar_CheckedChanged);
            // 
            // rb_guardar
            // 
            this.rb_guardar.AutoSize = true;
            this.rb_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_guardar.ForeColor = System.Drawing.Color.White;
            this.rb_guardar.Location = new System.Drawing.Point(24, 19);
            this.rb_guardar.Name = "rb_guardar";
            this.rb_guardar.Size = new System.Drawing.Size(80, 22);
            this.rb_guardar.TabIndex = 41;
            this.rb_guardar.TabStop = true;
            this.rb_guardar.Text = "Guardar";
            this.rb_guardar.UseVisualStyleBackColor = true;
            this.rb_guardar.CheckedChanged += new System.EventHandler(this.rb_guardar_CheckedChanged);
            // 
            // lbl_titulo_1
            // 
            this.lbl_titulo_1.AutoSize = true;
            this.lbl_titulo_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo_1.Location = new System.Drawing.Point(34, 26);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(158, 29);
            this.lbl_titulo_1.TabIndex = 66;
            this.lbl_titulo_1.Text = "Datos Marca";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Location = new System.Drawing.Point(684, 522);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(160, 38);
            this.btn_actualizar.TabIndex = 65;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(118, 101);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(168, 23);
            this.txt_nombre.TabIndex = 42;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 101);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 64;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_limpiar_datos
            // 
            this.btn_limpiar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_limpiar_datos.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar_datos.Location = new System.Drawing.Point(30, 568);
            this.btn_limpiar_datos.Name = "btn_limpiar_datos";
            this.btn_limpiar_datos.Size = new System.Drawing.Size(274, 38);
            this.btn_limpiar_datos.TabIndex = 63;
            this.btn_limpiar_datos.Text = "Limpiar Datos";
            this.btn_limpiar_datos.UseVisualStyleBackColor = true;
            this.btn_limpiar_datos.Click += new System.EventHandler(this.btn_limpiar_datos_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(1206, 572);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 38);
            this.btn_salir.TabIndex = 62;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(860, 522);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(160, 38);
            this.btn_eliminar.TabIndex = 61;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(684, 572);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(336, 38);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.AllowUserToAddRows = false;
            this.dgv_marcas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_marcas,
            this.nombre_marca,
            this.descripcion_marca});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_marcas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_marcas.Location = new System.Drawing.Point(335, 12);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_marcas.Size = new System.Drawing.Size(990, 493);
            this.dgv_marcas.TabIndex = 59;
            this.dgv_marcas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_marcas_RowHeaderMouseDoubleClick);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(27, 142);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_descripcion.TabIndex = 57;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(30, 173);
            this.txt_descripcion.MaxLength = 250;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(257, 139);
            this.txt_descripcion.TabIndex = 43;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(118, 72);
            this.txt_id.MaxLength = 45;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 23);
            this.txt_id.TabIndex = 41;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(36, 72);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 18);
            this.lbl_id.TabIndex = 49;
            this.lbl_id.Text = "ID";
            // 
            // id_marcas
            // 
            this.id_marcas.DataPropertyName = "id_marcas";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.id_marcas.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_marcas.HeaderText = "ID";
            this.id_marcas.Name = "id_marcas";
            this.id_marcas.ReadOnly = true;
            this.id_marcas.Width = 40;
            // 
            // nombre_marca
            // 
            this.nombre_marca.DataPropertyName = "nombre_marca";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.nombre_marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre_marca.HeaderText = "Nombre";
            this.nombre_marca.Name = "nombre_marca";
            this.nombre_marca.ReadOnly = true;
            // 
            // descripcion_marca
            // 
            this.descripcion_marca.DataPropertyName = "descripcion_marca";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.descripcion_marca.DefaultCellStyle = dataGridViewCellStyle4;
            this.descripcion_marca.HeaderText = "Descripcion";
            this.descripcion_marca.Name = "descripcion_marca";
            this.descripcion_marca.ReadOnly = true;
            this.descripcion_marca.Width = 800;
            // 
            // Frm_marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 622);
            this.Controls.Add(this.gb_operaciones);
            this.Controls.Add(this.lbl_titulo_1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_limpiar_datos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_marcas";
            this.Text = "Frm_marcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb_operaciones.ResumeLayout(false);
            this.gb_operaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_operaciones;
        private System.Windows.Forms.RadioButton rb_actualizar;
        private System.Windows.Forms.RadioButton rb_eliminar;
        private System.Windows.Forms.RadioButton rb_guardar;
        private System.Windows.Forms.Label lbl_titulo_1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_limpiar_datos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_marca;
    }
}