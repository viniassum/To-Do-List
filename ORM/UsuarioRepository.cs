using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace ORM
{
    public class UsuarioRepository : RepositoryConnector, Interfaces.IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration config) : base(config) { }

        public void Add(Usuario obj)
        {
            DynamicParameters pam = new DynamicParameters();
            pam.Add("@email", obj.Email);
            pam.Add("@senha", obj.Senha);

            string sql = "INSERT INTO Usuario (email, senha) Values (@email, @senha)";

            using (var con = new SqlConnection(base.GetConnection()))
            {
                con.Execute(sql, pam);
            }
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(string email, string senha)
        {
            string sql = $"SELECT * FROM Usuario WHERE email = {email} AND senha = {senha}";
            IEnumerable<Usuario> usuarios;
            using (var con = new SqlConnection(base.GetConnection()))
            {
                return con.Query<Usuario>(sql).FirstOrDefault();
            }            
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
