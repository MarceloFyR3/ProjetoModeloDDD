﻿using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services.IProduto
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
