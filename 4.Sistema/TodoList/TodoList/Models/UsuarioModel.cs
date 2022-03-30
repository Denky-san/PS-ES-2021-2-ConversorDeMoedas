using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Enums;

namespace TodoList.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do Usuário")]
        [EmailAddress(ErrorMessage ="Formato de e-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o login do Usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do Usuário")]
        public string Senha { get; set; }

        public PerfilEnum Perfil { get; set; }
    }
}
