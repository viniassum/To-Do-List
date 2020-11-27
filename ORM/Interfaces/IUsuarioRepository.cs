using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace ORM.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        int GetLogin(string email, string senha);
    }
}
