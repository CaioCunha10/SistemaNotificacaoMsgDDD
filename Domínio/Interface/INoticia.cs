﻿using Domínio.Interface.Genericos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Interface
{  
    //Implementando um método para definir uma expression 
    public interface INoticia : IGenericos<Noticia>
    {
        Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia, bool>> exNoticia);
    }
}
