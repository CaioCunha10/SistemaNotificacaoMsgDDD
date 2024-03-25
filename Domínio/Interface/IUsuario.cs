using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Interface
{
    public interface IUsuario
    {
        Task <bool> AdicionarUsuario(string email, string password, int idade,string celular);
    }
}
