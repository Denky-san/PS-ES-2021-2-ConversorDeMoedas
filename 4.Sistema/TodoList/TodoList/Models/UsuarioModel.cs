using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
