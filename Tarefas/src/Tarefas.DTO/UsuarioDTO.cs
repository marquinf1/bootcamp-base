using System;
using System.Collections.Generic;

namespace Tarefas.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string? Email { get; set; }        

        public string? Senha { get; set; }  

        public string Nome { get; set; }

        public string Ativo { get; set; }
    }
}
