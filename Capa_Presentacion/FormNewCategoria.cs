using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormNewCategoria : Form
    {
        private FormGestionProductos anterior;
        public event Action<List<string>> CategoriasActualizadas;
        private List<string> categorias = new List<string>();
        GestionProducto gestor = new GestionProducto();
        public FormNewCategoria(FormGestionProductos anterior)
        {
            InitializeComponent();
            this.anterior = anterior;
            categorias = gestor.CargarCategorias();
        }

        private void btnNewCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtNewCategoria.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoria)) return;

            if (!categorias.Contains(categoria, StringComparer.OrdinalIgnoreCase))
            {
                categorias.Add(categoria);
                gestor.RegistrarCategorias(categorias, categoria);
                CategoriasActualizadas?.Invoke(categorias); // notifica al form anterior
                txtNewCategoria.Clear();
            }
        }
    }
}
