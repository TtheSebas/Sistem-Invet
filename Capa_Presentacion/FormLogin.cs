using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using CapaDatos;

namespace Capa_Presentacion
{
    public partial class FormLogin : Form
    {
        //Inicializacion de variables
        private FormInicio formAnterior;
        private static string rutaUsuarios = "usuarios.csv";
        private static string encabezadoUsuarios = "Nombre;Apellido;Email;Password;Rol";
        private List<Usuario> usuarios = new List<Usuario>();
        GestionUsuario gestor = new GestionUsuario();
        public FormLogin(FormInicio anterior)
        {
            InitializeComponent();
            this.formAnterior = anterior;
            usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);
            string usuario = txtNombre.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();



            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Busca al usuario de la "Base de datos"
            Usuario user = usuarios.FirstOrDefault(u =>u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase) && u.Pass == contraseña);

            if (user != null)
            {
                FormMenuPrincipal menu = new FormMenuPrincipal(this);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtNombre.Focus();

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();               // Cierra FormLogin
            formAnterior.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) // 13 es Enter
            {
                btnIngresar.PerformClick(); // Ejecuta el botón Ingresar
                e.Handled = true;           // Evita que el enter haga un beep o efecto no deseado
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario(this);
            formCrearUsuario.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
