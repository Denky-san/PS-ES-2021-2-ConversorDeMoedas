using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Usuario
    {
        public string Nome { get; set; }

        public List<Usuario> Usuarios(string nome)
        {
            var usuarios = new List<Usuario>();
            usuarios.Add(new Usuario() { Nome = "Pietro" });
            return usuarios;
        }
    }
}
 