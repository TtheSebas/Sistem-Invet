namespace Capa_Presentacion
{
    partial class FormGestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionProductos));
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrar = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbEditar = new ComboBox();
            txtNombreEditar = new TextBox();
            txtCantidadEditar = new TextBox();
            txtPrecioEditar = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnGuardarCambios = new Button();
            label14 = new Label();
            label15 = new Label();
            cmbEliminar = new ComboBox();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            cmbCategorias = new ComboBox();
            cmbCategorias2 = new ComboBox();
            txtCategoriaEditar = new TextBox();
            txtCategoria = new TextBox();
            btnAddCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(892, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 30);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 1;
            label1.Text = "Registrar Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 159);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "Categoría: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 154);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "Cantidad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 197);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 2;
            label6.Text = "Precio: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(90, 113);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 4;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(292, 114);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(292, 151);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(90, 194);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(265, 193);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 280);
            label7.Name = "label7";
            label7.Size = new Size(131, 17);
            label7.TabIndex = 10;
            label7.Text = "Editar Producto: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 310);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 11;
            label8.Text = "Seleccionar Producto:";
            // 
            // cmbEditar
            // 
            cmbEditar.FormattingEnabled = true;
            cmbEditar.Location = new Point(39, 328);
            cmbEditar.Name = "cmbEditar";
            cmbEditar.Size = new Size(121, 23);
            cmbEditar.TabIndex = 12;
            cmbEditar.SelectedIndexChanged += cmbEditar_SelectedIndexChanged;
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Location = new Point(106, 364);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(100, 23);
            txtNombreEditar.TabIndex = 13;
            // 
            // txtCantidadEditar
            // 
            txtCantidadEditar.Location = new Point(106, 422);
            txtCantidadEditar.Name = "txtCantidadEditar";
            txtCantidadEditar.Size = new Size(100, 23);
            txtCantidadEditar.TabIndex = 15;
            // 
            // txtPrecioEditar
            // 
            txtPrecioEditar.Location = new Point(106, 451);
            txtPrecioEditar.Name = "txtPrecioEditar";
            txtPrecioEditar.Size = new Size(100, 23);
            txtPrecioEditar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 367);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 18;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 396);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 19;
            label11.Text = "Categoria: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 425);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 20;
            label12.Text = "Cantidad: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 454);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 21;
            label13.Text = "Precio: ";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(44, 497);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(146, 30);
            btnGuardarCambios.TabIndex = 22;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(248, 280);
            label14.Name = "label14";
            label14.Size = new Size(147, 17);
            label14.TabIndex = 23;
            label14.Text = "Eliminar Producto: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(273, 307);
            label15.Name = "label15";
            label15.Size = new Size(122, 15);
            label15.TabIndex = 24;
            label15.Text = "Seleccionar Producto:";
            // 
            // cmbEliminar
            // 
            cmbEliminar.FormattingEnabled = true;
            cmbEliminar.Location = new Point(274, 328);
            cmbEliminar.Name = "cmbEliminar";
            cmbEliminar.Size = new Size(121, 23);
            cmbEliminar.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(271, 497);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 30);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 447);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1051, 73);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gray;
            label9.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(13, 23);
            label9.Name = "label9";
            label9.Size = new Size(196, 27);
            label9.TabIndex = 29;
            label9.Text = "Gestion Producto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(227, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1051, 73);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(224, 245);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(247, 300);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(172, 245);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 98);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(409, 153);
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(90, 156);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(100, 23);
            cmbCategorias.TabIndex = 31;
            // 
            // cmbCategorias2
            // 
            cmbCategorias2.FormattingEnabled = true;
            cmbCategorias2.Location = new Point(106, 393);
            cmbCategorias2.Name = "cmbCategorias2";
            cmbCategorias2.Size = new Size(100, 23);
            cmbCategorias2.TabIndex = 32;
            // 
            // txtCategoriaEditar
            // 
            txtCategoriaEditar.BackColor = SystemColors.Control;
            txtCategoriaEditar.BorderStyle = BorderStyle.None;
            txtCategoriaEditar.Location = new Point(493, 570);
            txtCategoriaEditar.Name = "txtCategoriaEditar";
            txtCategoriaEditar.Size = new Size(100, 16);
            txtCategoriaEditar.TabIndex = 14;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.Control;
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Location = new Point(615, 570);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 16);
            txtCategoria.TabIndex = 6;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.Location = new Point(196, 157);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(25, 22);
            btnAddCategoria.TabIndex = 33;
            btnAddCategoria.Text = "+";
            btnAddCategoria.UseVisualStyleBackColor = true;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 598);
            Controls.Add(btnAddCategoria);
            Controls.Add(cmbCategorias2);
            Controls.Add(cmbCategorias);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(cmbEliminar);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtPrecioEditar);
            Controls.Add(txtCantidadEditar);
            Controls.Add(txtCategoriaEditar);
            Controls.Add(txtNombreEditar);
            Controls.Add(cmbEditar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreProducto);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Name = "FormGestionProductos";
            Text = "FormGestionProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreProducto;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnRegistrar;
        private Label label7;
        private Label label8;
        private ComboBox cmbEditar;
        private TextBox txtNombreEditar;
        private TextBox txtCantidadEditar;
        private TextBox txtPrecioEditar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnGuardarCambios;
        private Label label14;
        private Label label15;
        private ComboBox cmbEliminar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ComboBox cmbCategorias;
        private ComboBox cmbCategorias2;
        private TextBox txtCategoriaEditar;
        private TextBox txtCategoria;
        private Button btnAddCategoria;
    }
}