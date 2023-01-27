using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using Tarefas.DTO;
using System.Collections.Generic;


namespace Tarefas.DAO
{
    public class UsuarioDAO : BaseDAO, IUsuarioDAO
    {
        public UsuarioDAO()
        {
            
        }
    
        public void Criar(UsuarioDAO usuario)
        {
            using (var con = Connection)
            {
                con.Open();
                con.Execute(
                    @"INSERT INTO Usuario
                    (Email, Senha, Nome, Ativo) VALUES
                    (@Email, @Senha, @Nome, @Ativo);", usuario
                );
            }
        }

        public void Criar(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

    }
}

        