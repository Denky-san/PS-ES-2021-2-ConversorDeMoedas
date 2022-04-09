using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TarefasModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Status { get; set; }

        //public UsuarioModel Usuario { get; set; }

        /*
        [ForeignKey("UsuarioModel")]
        public int UsuarioID;
        */
    }
}
