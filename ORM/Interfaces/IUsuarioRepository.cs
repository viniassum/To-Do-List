using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace ORM.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        //Usuario Get(string email, string senha);
    }
}
