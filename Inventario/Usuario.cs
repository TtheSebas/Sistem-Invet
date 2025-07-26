using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        private string _nombre = "";
        private string _apellido = "";
        private string _email = "";
        private string _pass = "";
        private string _rol = "";

        public Usuario(string nombre, string apellido, string email, string pass,
            string rol)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pass = pass;
            Rol = rol;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
    }
}
