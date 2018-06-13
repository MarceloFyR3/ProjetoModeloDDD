using SimpleInjector;

namespace ProjetoModeloDDD.Infra.CrossCulting.IoC
{
    public class Class1
    {
        static readonly Container container;

        //static Class1()
        //{
        //    // 1. Create a new Simple Injector container
        //    container = new Container();

        //    // 2. Configure the container (register)
        //    container.Register<IOrderRepository, SqlOrderRepository>();
        //    container.Register<ILogger, FileLogger>(Lifestyle.Singleton);
        //    container.Register<CancelOrderHandler>();

        //    // 3. Verify your configuration
        //    container.Verify();
        //}

        //static void Main(string[] args)
        //{
        //    // 4. Use the container
        //    var handler = container.GetInstance<CancelOrderHandler>();

        //    var orderId = Guid.Parse(args[0]);
        //    var command = new CancelOrder { OrderId = orderId };

        //    handler.Handle(command);
        //}
    }
}
