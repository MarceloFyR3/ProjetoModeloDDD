using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.AppCliente;
using ProjetoModeloDDD.Application.AppProduto;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Application.Interface.IClienteApp;
using ProjetoModeloDDD.Application.Interface.IProdutoApp;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.ICliente;
using ProjetoModeloDDD.Domain.Interfaces.IProduto;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Interfaces.Services.ICliente;
using ProjetoModeloDDD.Domain.Interfaces.Services.IProduto;
using ProjetoModeloDDD.Domain.Services;
using ProjetoModeloDDD.Infra.Repositories;
using SimpleInjector;

namespace ProjetoModeloDDD.Infra.CrossCulting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //code
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped );
            container.Register<IClienteAppService, ClienteAppService>();
            container.Register<IProdutoAppService, ProdutoAppService>();

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register<IClienteService, ClienteService>();
            container.Register<IProdutoService, ProdutoService>();

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>();
            container.Register<IProdutoRepository, ProdutoRepository>();

        }
    }
}
