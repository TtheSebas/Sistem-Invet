using Inventario;
using System;
using System.Security.Cryptography;
namespace Datos
{
    public class GestionDatos
    {
        //CARACTERES PARA GENERAR CODIGOS
        private const string Alfabeto = "ABCDEFGHJKLMNOPQRSTUVWXYZ01234567890";
        //Metodo para verificar si un archivo existe, sino lo crea
        public void VerificarArchivo(string archivo, string entrada)
        {
            if (!File.Exists(archivo))
            {
                File.WriteAllText(archivo, entrada + Environment.NewLine);
            }
        }

        public string GenerarCodigo(string prefijo, int longitud = 6, string alfabeto = Alfabeto)
        {
            var bytes = new byte[longitud];
            var chars = new char[longitud];

            // Se crea un generador de números aleatorios criptográficamente seguros
            using var rango = RandomNumberGenerator.Create();
            rango.GetBytes(bytes);

            // Por cada posición, convertimos el byte a un índice válido del alfabeto
            // usando el operador módulo (%) para evitar desbordamiento
            for (int i = 0; i < longitud; i++)
            {
                chars[i] = alfabeto[bytes[i] % alfabeto.Length];
            }

            string codigo = new string(chars);
            return $"{prefijo}-{codigo}";
        }
    }
}
