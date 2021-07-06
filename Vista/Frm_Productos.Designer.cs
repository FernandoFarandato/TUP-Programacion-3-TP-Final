namespace Vista
{
    partial class Frm_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
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
            this.id_marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id_productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_proveedores_id = new System.Windows.Forms.TextBox();
            this.txt_id_provedores = new System.Windows.Forms.Label();
            this.txt_marcas_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_operaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_operaciones
            // 
            this.gb_operaciones.Controls.Add(this.rb_actualizar);
            this.gb_operaciones.Controls.Add(this.rb_eliminar);
            this.gb_operaciones.Controls.Add(this.rb_guardar);
            this.gb_operaciones.ForeColor = System.Drawing.Color.White;
            this.gb_operaciones.Location = new System.Drawing.Point(334, 511);
            this.gb_operaciones.Name = "gb_operaciones";
            this.gb_operaciones.Size = new System.Drawing.Size(135, 95);
            this.gb_operaciones.TabIndex = 71;
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
            this.lbl_titulo_1.Location = new System.Drawing.Point(33, 26);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(192, 29);
            this.lbl_titulo_1.TabIndex = 80;
            this.lbl_titulo_1.Text = "Datos Producto";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Location = new System.Drawing.Point(683, 522);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(160, 38);
            this.btn_actualizar.TabIndex = 79;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(117, 101);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(168, 23);
            this.txt_nombre.TabIndex = 68;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(35, 101);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 78;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_limpiar_datos
            // 
            this.btn_limpiar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_limpiar_datos.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar_datos.Location = new System.Drawing.Point(29, 568);
            this.btn_limpiar_datos.Name = "btn_limpiar_datos";
            this.btn_limpiar_datos.Size = new System.Drawing.Size(274, 38);
            this.btn_limpiar_datos.TabIndex = 77;
            this.btn_limpiar_datos.Text = "Limpiar Datos";
            this.btn_limpiar_datos.UseVisualStyleBackColor = true;
            this.btn_limpiar_datos.Click += new System.EventHandler(this.btn_limpiar_datos_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(1205, 572);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 38);
            this.btn_salir.TabIndex = 76;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(859, 522);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(160, 38);
            this.btn_eliminar.TabIndex = 75;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(683, 572);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(336, 38);
            this.btn_guardar.TabIndex = 74;
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
            this.nombre_marca});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_marcas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_marcas.Location = new System.Drawing.Point(1142, 72);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_marcas.Size = new System.Drawing.Size(138, 433);
            this.dgv_marcas.TabIndex = 73;
            this.dgv_marcas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_marcas_RowHeaderMouseDoubleClick);
            // 
            // id_marcas
            // 
            this.id_marcas.DataPropertyName = "id_marcas";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.id_marcas.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_marcas.HeaderText = "ID";
            this.id_marcas.Name = "id_marcas";
            this.id_marcas.ReadOnly = true;
            this.id_marcas.Width = 25;
            // 
            // nombre_marca
            // 
            this.nombre_marca.DataPropertyName = "nombre_marca";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.nombre_marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre_marca.HeaderText = "Nombre";
            this.nombre_marca.Name = "nombre_marca";
            this.nombre_marca.ReadOnly = true;
            this.nombre_marca.Width = 70;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(26, 239);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_descripcion.TabIndex = 72;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(29, 269);
            this.txt_descripcion.MaxLength = 250;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(257, 139);
            this.txt_descripcion.TabIndex = 69;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(117, 72);
            this.txt_id.MaxLength = 45;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 23);
            this.txt_id.TabIndex = 67;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(35, 72);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 18);
            this.lbl_id.TabIndex = 70;
            this.lbl_id.Text = "ID";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_productos,
            this.nombre_productos,
            this.descripcion_productos,
            this.qqq,
            this.precio,
            this.nombre});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_productos.Location = new System.Drawing.Point(334, 72);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_productos.Size = new System.Drawing.Size(599, 433);
            this.dgv_productos.TabIndex = 81;
            this.dgv_productos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgb_productos_RowHeaderMouseDoubleClick);
            // 
            // id_productos
            // 
            this.id_productos.DataPropertyName = "id_productos";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.id_productos.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_productos.HeaderText = "ID";
            this.id_productos.Name = "id_productos";
            this.id_productos.ReadOnly = true;
            this.id_productos.Width = 25;
            // 
            // nombre_productos
            // 
            this.nombre_productos.DataPropertyName = "nombre_productos";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.nombre_productos.DefaultCellStyle = dataGridViewCellStyle8;
            this.nombre_productos.HeaderText = "Nombre";
            this.nombre_productos.Name = "nombre_productos";
            this.nombre_productos.ReadOnly = true;
            // 
            // descripcion_productos
            // 
            this.descripcion_productos.DataPropertyName = "descripcion_productos";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.descripcion_productos.DefaultCellStyle = dataGridViewCellStyle9;
            this.descripcion_productos.HeaderText = "Descripcion";
            this.descripcion_productos.Name = "descripcion_productos";
            this.descripcion_productos.ReadOnly = true;
            this.descripcion_productos.Width = 130;
            // 
            // qqq
            // 
            this.qqq.DataPropertyName = "nombre_marca";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.qqq.DefaultCellStyle = dataGridViewCellStyle10;
            this.qqq.HeaderText = "Marca";
            this.qqq.Name = "qqq";
            this.qqq.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.precio.DefaultCellStyle = dataGridViewCellStyle11;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle12;
            this.nombre.HeaderText = "Proveedor";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "Lista Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1137, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = "Lista Marcas";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(117, 130);
            this.txt_precio.MaxLength = 45;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(168, 23);
            this.txt_precio.TabIndex = 84;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_precio.ForeColor = System.Drawing.Color.White;
            this.lbl_precio.Location = new System.Drawing.Point(35, 130);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(51, 18);
            this.lbl_precio.TabIndex = 85;
            this.lbl_precio.Text = "Precio";
            // 
            // txt_proveedores_id
            // 
            this.txt_proveedores_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedores_id.Location = new System.Drawing.Point(117, 159);
            this.txt_proveedores_id.MaxLength = 45;
            this.txt_proveedores_id.Name = "txt_proveedores_id";
            this.txt_proveedores_id.Size = new System.Drawing.Size(168, 23);
            this.txt_proveedores_id.TabIndex = 86;
            this.txt_proveedores_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_id_provedores
            // 
            this.txt_id_provedores.AutoSize = true;
            this.txt_id_provedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_id_provedores.ForeColor = System.Drawing.Color.White;
            this.txt_id_provedores.Location = new System.Drawing.Point(35, 159);
            this.txt_id_provedores.Name = "txt_id_provedores";
            this.txt_id_provedores.Size = new System.Drawing.Size(61, 18);
            this.txt_id_provedores.TabIndex = 87;
            this.txt_id_provedores.Text = "Prov. ID";
            // 
            // txt_marcas_id
            // 
            this.txt_marcas_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marcas_id.Location = new System.Drawing.Point(117, 188);
            this.txt_marcas_id.MaxLength = 45;
            this.txt_marcas_id.Name = "txt_marcas_id";
            this.txt_marcas_id.Size = new System.Drawing.Size(168, 23);
            this.txt_marcas_id.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 89;
            this.label4.Text = "ID Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(965, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 91;
            this.label5.Text = "Lista Prov.";
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_proveedores.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_proveedores.Location = new System.Drawing.Point(970, 72);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_proveedores.Size = new System.Drawing.Size(138, 433);
            this.dgv_proveedores.TabIndex = 90;
            this.dgv_proveedores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_proveedores_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle16;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 622);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.txt_marcas_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_proveedores_id);
            this.Controls.Add(this.txt_id_provedores);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_productos);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            this.gb_operaciones.ResumeLayout(false);
            this.gb_operaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_proveedores_id;
        private System.Windows.Forms.Label txt_id_provedores;
        private System.Windows.Forms.TextBox txt_marcas_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqq;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}