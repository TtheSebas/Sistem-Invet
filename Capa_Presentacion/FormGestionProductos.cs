using Inventario;
using Datos;

namespace Capa_Presentacion
{
    public partial class FormGestionProductos : Form
    {
        private FormMenuPrincipal formAnterior;
        private List<Producto> productos = new List<Producto>();

        private List<string> categorias = new List<string>();

        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";
        GestionProducto archivo = new GestionProducto();


        // Constructor que recibe el formulario anterior
        public FormGestionProductos(FormMenuPrincipal anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
            archivo.CargarProductos(productosCSV, encabezado, productos);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
            FormGestionProductos_Load(this, EventArgs.Empty);
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombreProducto.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
            formAnterior.Show(); // Muestra el menú principal nuevamente
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormGestionProductos_Load(object sender, EventArgs e)
        {
            // Cargar productos desde archivo si es necesario
            archivo.CargarProductos(productosCSV, encabezado, productos);
            categorias = archivo.CargarCategorias();
            // Llenar ComboBox de editar
            cmbEditar.DataSource = null;
            cmbEditar.DataSource = productos;
            cmbEditar.DisplayMember = "NombreProducto";
            cmbEditar.ValueMember = "CodigoProducto";

            // Llenar ComboBox de eliminar
            cmbEliminar.DataSource = null;
            cmbEliminar.DataSource = productos;
            cmbEliminar.DisplayMember = "NombreProducto";
            cmbEliminar.ValueMember = "CodigoProducto";

            // Mostrar productos en el DataGrid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            // Lita de Categorias
            CargarCategoriasEnUI(categorias);
            /*
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = categorias;
            cmbCategorias2.DataSource = categorias;*/
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigoP = txtCodigo.Text.Trim();
            string nombreP = txtNombreProducto.Text.Trim();
            string categoriaP = cmbCategorias.SelectedValue?.ToString().Trim();
            string cantidadText = txtCantidad.Text.Trim();
            string precioText = txtPrecio.Text.Trim();

            List<string> errores = new List<string>();
            bool hayCampoVacio = false;

            // Validar código
            if (string.IsNullOrWhiteSpace(codigoP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (codigoP.Length != 6)
                    errores.Add("El código del producto debe tener exactamente 6 caracteres.");

                if (productos.Any(p => p.CodigoProducto.Equals(codigoP, StringComparison.OrdinalIgnoreCase)))
                    errores.Add("Ya existe un producto con ese código.");
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombreP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!nombreP.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    errores.Add("El nombre del producto solo debe contener letras.");
            }

            // Validar categoría
            if (string.IsNullOrWhiteSpace(categoriaP))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!categoriaP.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    errores.Add("La categoría solo debe contener letras.");
            }

            // Validar cantidad
            int cantidadP = 0;
            if (string.IsNullOrWhiteSpace(cantidadText))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!int.TryParse(cantidadText, out cantidadP))
                    errores.Add("La cantidad debe ser un número entero válido.");
            }

            // Validar precio
            double precioP = 0;
            if (string.IsNullOrWhiteSpace(precioText))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!double.TryParse(precioText, out precioP))
                    errores.Add("El precio debe ser un número válido.");
            }

            // Mostrar errores en orden
            foreach (string error in errores)
            {
                MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si hubo errores, no continuar
            if (errores.Count > 0)
                return;

            // Si no hay errores pero sí campos vacíos
            if (hayCampoVacio)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Si todo está bien, registrar producto
            archivo.AgregarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP, precioP);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            LimpiarCampos();

            cmbEditar.DataSource = null;
            cmbEditar.DataSource = productos;
            cmbEditar.DisplayMember = "NombreProducto";
            cmbEditar.ValueMember = "CodigoProducto";

            cmbEliminar.DataSource = null;
            cmbEliminar.DataSource = productos;
            cmbEliminar.DisplayMember = "NombreProducto";
            cmbEliminar.ValueMember = "CodigoProducto";
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Verifica que haya un producto seleccionado
            if (cmbEditar.SelectedIndex == -1 || cmbEditar.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto válido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoP = cmbEditar.SelectedValue?.ToString().Trim();
            string nombreP = txtNombreEditar.Text.Trim();
            string categoriaP = cmbCategorias2.SelectedValue?.ToString().Trim();
            if (string.IsNullOrWhiteSpace(codigoP) || string.IsNullOrWhiteSpace(nombreP) || string.IsNullOrWhiteSpace(categoriaP))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtCantidadEditar.Text.Trim(), out int cantidadP))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            if (!double.TryParse(txtPrecioEditar.Text.Trim(), out double precioP))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Estás seguro de realizar los cambios?", "Editar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            archivo.ActualizarProducto(productosCSV, encabezado, productos, codigoP, nombreP, categoriaP, cantidadP, precioP);
            if (resultado == DialogResult.Yes)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productos;
                txtNombreEditar.Text = "";
                
                txtCantidadEditar.Text = "";
                txtPrecioEditar.Text = "";

                MessageBox.Show("Producto actualizado correctamente.");
            }
            else
            {
                // Opcional: acción si presiona "No"
                MessageBox.Show("Acción cancelada.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar el producto.", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string codigoP = cmbEliminar.SelectedValue?.ToString().Trim();

                if (cmbEliminar.SelectedIndex == -1 || cmbEliminar.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un producto válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                archivo.EliminarProducto(productosCSV, encabezado, productos, codigoP);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productos;

                //Refresca ComboBox de editar
                cmbEditar.DataSource = null;
                cmbEditar.DataSource = productos;
                cmbEditar.DisplayMember = "NombreProducto";
                cmbEditar.ValueMember = "CodigoProducto";

                //Refresca ComboBox de eliminar
                cmbEliminar.DataSource = null;
                cmbEliminar.DataSource = productos;
                cmbEliminar.DisplayMember = "NombreProducto";
                cmbEliminar.ValueMember = "CodigoProducto";

                MessageBox.Show("Producto eliminado correctamente.");
            }
            else
            {
                // Opcional: acción si presiona "No"
                MessageBox.Show("Acción cancelada.");
            }


        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEditar.SelectedItem is Producto productoSeleccionado)
            {
                txtNombreEditar.Text = productoSeleccionado.NombreProducto;
                // txtCategoriaEditar.Text = productoSeleccionado.CategoriaProducto;
                txtCantidadEditar.Text = productoSeleccionado.CantidadProducto.ToString();
                txtPrecioEditar.Text = productoSeleccionado.PrecioProducto.ToString("F2"); // Formato con 2 decimales, opcional
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            FormNewCategoria ventanaCategoria = new FormNewCategoria(this);
            ventanaCategoria.CategoriasActualizadas += cats =>
            {
                categorias = cats;
                CargarCategoriasEnUI(categorias);
            };
            ventanaCategoria.Show(this);
        }
        private void CargarCategoriasEnUI(List<string> categorias)
        {
            cmbCategorias.DataSource = null;              // Limpia la lista actual
            cmbCategorias.DataSource = categorias;        // Asigna la nueva
            cmbCategorias2.DataSource = categorias;
        }
    }

}
