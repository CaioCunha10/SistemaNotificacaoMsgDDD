﻿using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Interface.InterfaceServicos
{
    public interface IServicoNoticias
    {
        Task AdicionaNoticia(Noticia noticia);

        Task AtualizaNoticia(Noticia noticia);

        Task<List<Noticia>> ListarNoticiasAtivas();

    }
}
