[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AireAcondicionado.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AireAcondicionado.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace AireAcondicionado.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using AireAcondicionado.Entities.IRepositories;
    using AireAcondicionado.Persistence;
    using AireAcondicionado.Persistence.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<AireAcondicionadoDbContext>().To<AireAcondicionadoDbContext>();

            kernel.Bind<IAlmacenRepository>().To<AlmacenRepository>();
            kernel.Bind<ICargoRepository>().To<CargoRepository>();
            kernel.Bind<ICliEmpresaRepository>().To<CliEmpresaRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<ICliNaturalRepository>().To<CliNaturalRepository>();
            kernel.Bind<IComprobantePagoRepository>().To<ComprobantePagoRepository>();
            kernel.Bind<IContactoRepository>().To<ContactoRepository>();
            kernel.Bind<IContratoRepository>().To<ContratoRepository>();
            kernel.Bind<ICotizacionRepository>().To<CotizacionRepository>();
            kernel.Bind<IDepartamentoRepository>().To<DepartamentoRepository>();
            kernel.Bind<IDistritoRepository>().To<DistritoRepository>();
            kernel.Bind<IDocumentoRepository>().To<DocumentoRepository>();
            kernel.Bind<IFormaPagoRepository>().To<FormaPagoRepository>();
            kernel.Bind<IPedidoRepository>().To<PedidoRepository>();
            kernel.Bind<IPersonaRepository>().To<PersonaRepository>();
            kernel.Bind<IProductoRepository>().To<ProductoRepository>();
            kernel.Bind<IProveedorRepository>().To<ProveedorRepository>();
            kernel.Bind<IProvinciaRepository>().To<ProvinciaRepository>();
            kernel.Bind<IServicioRepository>().To<ServicioRepository>();
            kernel.Bind<ITrabajadorRepository>().To<TrabajadorRepository>();
            kernel.Bind<IUbigeoRepository>().To<UbigeoRepository>();

        }        
    }
}
