using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AireAcondicionadoDbContext _Context;

        public IAlmacenRepository Almacenes { get; private set; }
        public ICargoRepository Cargos { get; private set; }
        public ICliEmpresaRepository CliEmpresas { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public ICliNaturalRepository CliNaturales { get; private set; }
        public IComprobantePagoRepository ComprobantePagos { get; private set; }
        public IContactoRepository Contactos { get; private set; }
        public IContratoRepository Contratos { get; private set; }
        public ICotizacionRepository Cotizaciones { get; private set; }
        public IDepartamentoRepository Departamentos { get; private set; }
        public IDistritoRepository Distritos { get; private set; }
        public IDocumentoRepository Documentos { get; private set; }
        public IFormaPagoRepository FormaPagos { get; private set; }
        public IPedidoRepository Pedidos { get; private set; }
        public IPersonaRepository Personas { get; private set; }
        public IProductoRepository Productos { get; private set; }
        public IProveedorRepository Proveedores { get; private set; }
        public IProvinciaRepository Provincias { get; private set; }
        public IServicioRepository Servicios { get; private set; }
        public ITrabajadorRepository Trabajadores { get; private set; }
        public IUbigeoRepository Ubigeos { get; private set; }

        private UnityOfWork()
        {
            _Context = new AireAcondicionadoDbContext();

            Almacenes = new AlmacenRepository(_Context);
            Cargos = new CargoRepository(_Context);
            CliEmpresas = new CliEmpresaRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            CliNaturales = new CliNaturalRepository(_Context);
            ComprobantePagos = new ComprobantePagoRepository(_Context);
            Contactos=new ContactoRepository(_Context);
            Contratos=new ContratoRepository(_Context);
            Cotizaciones=new CotizacionRepository(_Context);
            Departamentos=new DepartamentoRepository(_Context);
            Distritos=new DistritoRepository(_Context);
            Documentos=new DocumentoRepository(_Context);
            FormaPagos=new FormaPagoRepository(_Context);
            Pedidos=new PedidoRepository(_Context);
            Personas=new PersonaRepository(_Context);
            Productos=new ProductoRepository(_Context);
            Proveedores=new ProveedorRepository(_Context);
            Provincias=new ProvinciaRepository(_Context);
            Servicios=new ServicioRepository(_Context);
            Trabajadores=new TrabajadorRepository(_Context);
            Ubigeos=new UbigeoRepository(_Context);

        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
