using ProjetoModeloDDD.Application.Interface.IProdutoApp;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services.IProduto;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.AppProduto
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoService.BuscaPorNome(nome);
        }
    }
}
