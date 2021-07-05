
namespace Vista
{
    partial class Frm_proveedores
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.rb_minorsita = new System.Windows.Forms.RadioButton();
            this.rb_mayorsita = new System.Windows.Forms.RadioButton();
            this.datosMinorista = new System.Windows.Forms.GroupBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.datosMayorista = new System.Windows.Forms.GroupBox();
            this.lbl_ibb = new System.Windows.Forms.Label();
            this.txt_ibb = new System.Windows.Forms.TextBox();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.txt_cuidad = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_cuidad = new System.Windows.Forms.Label();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btoGuardar = new System.Windows.Forms.Button();
            this.btoEliminar = new System.Windows.Forms.Button();
            this.btoSalir = new System.Windows.Forms.Button();
            this.btn_limpiar_datos = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_titulo_1 = new System.Windows.Forms.Label();
            this.txt_porcentage_ganancia = new System.Windows.Forms.TextBox();
            this.lbl_porcentage_ganancia = new System.Windows.Forms.Label();
            this.gb_operaciones = new System.Windows.Forms.GroupBox();
            this.rb_guardar = new System.Windows.Forms.RadioButton();
            this.rb_eliminar = new System.Windows.Forms.RadioButton();
            this.rb_actualizar = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentage_ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosMinorista.SuspendLayout();
            this.datosMayorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(114, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 23);
            this.txt_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(32, 72);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 18);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "ID";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_calle.ForeColor = System.Drawing.Color.White;
            this.lbl_calle.Location = new System.Drawing.Point(32, 190);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(41, 18);
            this.lbl_calle.TabIndex = 15;
            this.lbl_calle.Text = "Calle";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_telefono.Location = new System.Drawing.Point(32, 248);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_telefono.TabIndex = 16;
            this.lbl_telefono.Text = "Telefono";
            // 
            // rb_minorsita
            // 
            this.rb_minorsita.AutoSize = true;
            this.rb_minorsita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_minorsita.ForeColor = System.Drawing.Color.White;
            this.rb_minorsita.Location = new System.Drawing.Point(35, 283);
            this.rb_minorsita.Name = "rb_minorsita";
            this.rb_minorsita.Size = new System.Drawing.Size(87, 22);
            this.rb_minorsita.TabIndex = 7;
            this.rb_minorsita.TabStop = true;
            this.rb_minorsita.Text = "Minorista";
            this.rb_minorsita.UseVisualStyleBackColor = true;
            // 
            // rb_mayorsita
            // 
            this.rb_mayorsita.AutoSize = true;
            this.rb_mayorsita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_mayorsita.ForeColor = System.Drawing.Color.White;
            this.rb_mayorsita.Location = new System.Drawing.Point(35, 396);
            this.rb_mayorsita.Name = "rb_mayorsita";
            this.rb_mayorsita.Size = new System.Drawing.Size(91, 22);
            this.rb_mayorsita.TabIndex = 20;
            this.rb_mayorsita.TabStop = true;
            this.rb_mayorsita.Text = "Mayorista";
            this.rb_mayorsita.UseVisualStyleBackColor = true;
            // 
            // datosMinorista
            // 
            this.datosMinorista.Controls.Add(this.lbl_dni);
            this.datosMinorista.Controls.Add(this.txt_dni);
            this.datosMinorista.Enabled = false;
            this.datosMinorista.ForeColor = System.Drawing.Color.White;
            this.datosMinorista.Location = new System.Drawing.Point(21, 310);
            this.datosMinorista.Name = "datosMinorista";
            this.datosMinorista.Size = new System.Drawing.Size(279, 61);
            this.datosMinorista.TabIndex = 21;
            this.datosMinorista.TabStop = false;
            this.datosMinorista.Text = "Datos Minorista";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_dni.ForeColor = System.Drawing.Color.White;
            this.lbl_dni.Location = new System.Drawing.Point(11, 19);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(33, 18);
            this.lbl_dni.TabIndex = 23;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(88, 19);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(173, 23);
            this.txt_dni.TabIndex = 8;
            // 
            // datosMayorista
            // 
            this.datosMayorista.Controls.Add(this.lbl_porcentage_ganancia);
            this.datosMayorista.Controls.Add(this.txt_porcentage_ganancia);
            this.datosMayorista.Controls.Add(this.lbl_ibb);
            this.datosMayorista.Controls.Add(this.txt_ibb);
            this.datosMayorista.Controls.Add(this.lbl_cuit);
            this.datosMayorista.Controls.Add(this.txt_cuit);
            this.datosMayorista.Enabled = false;
            this.datosMayorista.ForeColor = System.Drawing.Color.White;
            this.datosMayorista.Location = new System.Drawing.Point(21, 431);
            this.datosMayorista.Name = "datosMayorista";
            this.datosMayorista.Size = new System.Drawing.Size(279, 112);
            this.datosMayorista.TabIndex = 22;
            this.datosMayorista.TabStop = false;
            this.datosMayorista.Text = "Datos Mayorista";
            // 
            // lbl_ibb
            // 
            this.lbl_ibb.AutoSize = true;
            this.lbl_ibb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_ibb.ForeColor = System.Drawing.Color.White;
            this.lbl_ibb.Location = new System.Drawing.Point(11, 51);
            this.lbl_ibb.Name = "lbl_ibb";
            this.lbl_ibb.Size = new System.Drawing.Size(34, 18);
            this.lbl_ibb.TabIndex = 25;
            this.lbl_ibb.Text = "IIBB";
            // 
            // txt_ibb
            // 
            this.txt_ibb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ibb.Location = new System.Drawing.Point(88, 51);
            this.txt_ibb.Name = "txt_ibb";
            this.txt_ibb.Size = new System.Drawing.Size(174, 23);
            this.txt_ibb.TabIndex = 26;
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_cuit.ForeColor = System.Drawing.Color.White;
            this.lbl_cuit.Location = new System.Drawing.Point(11, 21);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(42, 18);
            this.lbl_cuit.TabIndex = 24;
            this.lbl_cuit.Text = "CUIT";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.Location = new System.Drawing.Point(88, 20);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(174, 23);
            this.txt_cuit.TabIndex = 24;
            // 
            // txt_cuidad
            // 
            this.txt_cuidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuidad.Location = new System.Drawing.Point(114, 132);
            this.txt_cuidad.Name = "txt_cuidad";
            this.txt_cuidad.Size = new System.Drawing.Size(168, 23);
            this.txt_cuidad.TabIndex = 2;
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.Location = new System.Drawing.Point(114, 190);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(168, 23);
            this.txt_calle.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(114, 248);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(168, 23);
            this.txt_telefono.TabIndex = 6;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_numero.ForeColor = System.Drawing.Color.White;
            this.lbl_numero.Location = new System.Drawing.Point(32, 219);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(62, 18);
            this.lbl_numero.TabIndex = 26;
            this.lbl_numero.Text = "Numero";
            // 
            // lbl_cuidad
            // 
            this.lbl_cuidad.AutoSize = true;
            this.lbl_cuidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_cuidad.ForeColor = System.Drawing.Color.White;
            this.lbl_cuidad.Location = new System.Drawing.Point(32, 133);
            this.lbl_cuidad.Name = "lbl_cuidad";
            this.lbl_cuidad.Size = new System.Drawing.Size(54, 18);
            this.lbl_cuidad.TabIndex = 27;
            this.lbl_cuidad.Text = "Cuidad";
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_provincia.ForeColor = System.Drawing.Color.White;
            this.lbl_provincia.Location = new System.Drawing.Point(32, 161);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(69, 18);
            this.lbl_provincia.TabIndex = 28;
            this.lbl_provincia.Text = "Provincia";
            // 
            // txt_provincia
            // 
            this.txt_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_provincia.Location = new System.Drawing.Point(114, 161);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(168, 23);
            this.txt_provincia.TabIndex = 3;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(114, 219);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(168, 23);
            this.txt_numero.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.porcentage_ganancia,
            this.dni,
            this.cuit,
            this.ibb,
            this.cuidad,
            this.provincia,
            this.calle,
            this.numero,
            this.telefono});
            this.dataGridView1.Location = new System.Drawing.Point(331, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(990, 493);
            this.dataGridView1.TabIndex = 32;
            // 
            // btoGuardar
            // 
            this.btoGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btoGuardar.Location = new System.Drawing.Point(680, 572);
            this.btoGuardar.Name = "btoGuardar";
            this.btoGuardar.Size = new System.Drawing.Size(336, 38);
            this.btoGuardar.TabIndex = 33;
            this.btoGuardar.Text = "Guardar";
            this.btoGuardar.UseVisualStyleBackColor = true;
            // 
            // btoEliminar
            // 
            this.btoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btoEliminar.Location = new System.Drawing.Point(856, 522);
            this.btoEliminar.Name = "btoEliminar";
            this.btoEliminar.Size = new System.Drawing.Size(160, 38);
            this.btoEliminar.TabIndex = 34;
            this.btoEliminar.Text = "Eliminar";
            this.btoEliminar.UseVisualStyleBackColor = true;
            // 
            // btoSalir
            // 
            this.btoSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btoSalir.Location = new System.Drawing.Point(1219, 572);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(102, 38);
            this.btoSalir.TabIndex = 35;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar_datos
            // 
            this.btn_limpiar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_limpiar_datos.Location = new System.Drawing.Point(26, 568);
            this.btn_limpiar_datos.Name = "btn_limpiar_datos";
            this.btn_limpiar_datos.Size = new System.Drawing.Size(274, 38);
            this.btn_limpiar_datos.TabIndex = 36;
            this.btn_limpiar_datos.Text = "Limpiar Datos";
            this.btn_limpiar_datos.UseVisualStyleBackColor = true;
            this.btn_limpiar_datos.Click += new System.EventHandler(this.btoLimpiar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(32, 101);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 37;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(114, 101);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(168, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(680, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo_1
            // 
            this.lbl_titulo_1.AutoSize = true;
            this.lbl_titulo_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo_1.Location = new System.Drawing.Point(30, 26);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(209, 29);
            this.lbl_titulo_1.TabIndex = 40;
            this.lbl_titulo_1.Text = "Datos Proveedor";
            // 
            // txt_porcentage_ganancia
            // 
            this.txt_porcentage_ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_porcentage_ganancia.Location = new System.Drawing.Point(88, 80);
            this.txt_porcentage_ganancia.Name = "txt_porcentage_ganancia";
            this.txt_porcentage_ganancia.Size = new System.Drawing.Size(173, 23);
            this.txt_porcentage_ganancia.TabIndex = 27;
            // 
            // lbl_porcentage_ganancia
            // 
            this.lbl_porcentage_ganancia.AutoSize = true;
            this.lbl_porcentage_ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_porcentage_ganancia.ForeColor = System.Drawing.Color.White;
            this.lbl_porcentage_ganancia.Location = new System.Drawing.Point(11, 80);
            this.lbl_porcentage_ganancia.Name = "lbl_porcentage_ganancia";
            this.lbl_porcentage_ganancia.Size = new System.Drawing.Size(53, 18);
            this.lbl_porcentage_ganancia.TabIndex = 28;
            this.lbl_porcentage_ganancia.Text = "Gan %";
            // 
            // gb_operaciones
            // 
            this.gb_operaciones.Controls.Add(this.rb_actualizar);
            this.gb_operaciones.Controls.Add(this.rb_eliminar);
            this.gb_operaciones.Controls.Add(this.rb_guardar);
            this.gb_operaciones.ForeColor = System.Drawing.Color.White;
            this.gb_operaciones.Location = new System.Drawing.Point(331, 511);
            this.gb_operaciones.Name = "gb_operaciones";
            this.gb_operaciones.Size = new System.Drawing.Size(135, 95);
            this.gb_operaciones.TabIndex = 24;
            this.gb_operaciones.TabStop = false;
            this.gb_operaciones.Text = "Operacion";
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
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // porcentage_ganancia
            // 
            this.porcentage_ganancia.DataPropertyName = "porcentage_ganancia";
            this.porcentage_ganancia.HeaderText = "Gan %";
            this.porcentage_ganancia.Name = "porcentage_ganancia";
            this.porcentage_ganancia.ReadOnly = true;
            this.porcentage_ganancia.Width = 50;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 80;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Width = 80;
            // 
            // ibb
            // 
            this.ibb.DataPropertyName = "ibb";
            this.ibb.HeaderText = "IIBB";
            this.ibb.Name = "ibb";
            this.ibb.ReadOnly = true;
            this.ibb.Width = 80;
            // 
            // cuidad
            // 
            this.cuidad.DataPropertyName = "cuidad";
            this.cuidad.HeaderText = "Cuidad";
            this.cuidad.Name = "cuidad";
            this.cuidad.ReadOnly = true;
            this.cuidad.Width = 90;
            // 
            // provincia
            // 
            this.provincia.DataPropertyName = "provincia";
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 90;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 80;
            // 
            // Frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 622);
            this.Controls.Add(this.gb_operaciones);
            this.Controls.Add(this.lbl_titulo_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_limpiar_datos);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.btoEliminar);
            this.Controls.Add(this.btoGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_provincia);
            this.Controls.Add(this.lbl_provincia);
            this.Controls.Add(this.lbl_cuidad);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_cuidad);
            this.Controls.Add(this.datosMayorista);
            this.Controls.Add(this.datosMinorista);
            this.Controls.Add(this.rb_mayorsita);
            this.Controls.Add(this.rb_minorsita);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_calle);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM-Proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProveedores_FormClosed);
            this.Load += new System.EventHandler(this.Frm_proveedores_Load);
            this.datosMinorista.ResumeLayout(false);
            this.datosMinorista.PerformLayout();
            this.datosMayorista.ResumeLayout(false);
            this.datosMayorista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_operaciones.ResumeLayout(false);
            this.gb_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.RadioButton rb_minorsita;
        private System.Windows.Forms.RadioButton rb_mayorsita;
        private System.Windows.Forms.GroupBox datosMinorista;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.GroupBox datosMayorista;
        private System.Windows.Forms.Label lbl_ibb;
        private System.Windows.Forms.TextBox txt_ibb;
        private System.Windows.Forms.Label lbl_cuit;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.TextBox txt_cuidad;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_cuidad;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btoGuardar;
        private System.Windows.Forms.Button btoEliminar;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.Button btn_limpiar_datos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_titulo_1;
        private System.Windows.Forms.Label lbl_porcentage_ganancia;
        private System.Windows.Forms.TextBox txt_porcentage_ganancia;
        private System.Windows.Forms.GroupBox gb_operaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentage_ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.RadioButton rb_actualizar;
        private System.Windows.Forms.RadioButton rb_eliminar;
        private System.Windows.Forms.RadioButton rb_guardar;
    }
}