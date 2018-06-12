using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.IProduto;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoServico : ServiceBase<Produto>, IProdutoRepository
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoServico(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
