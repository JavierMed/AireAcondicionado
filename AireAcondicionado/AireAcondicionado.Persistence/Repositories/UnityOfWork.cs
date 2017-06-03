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
        private static UnityOfWork _Instance;
        private static readonly object _Lock=new object();


        public IAlmacenRepository Almacenes { get;  set; }
        public ICargoRepository Cargos { get;  set; }
        public ICliEmpresaRepository CliEmpresas { get;  set; }
        public IClienteRepository Clientes { get;  set; }
        public ICliNaturalRepository CliNaturales { get;  set; }
        public IComprobantePagoRepository ComprobantePagos { get;  set; }
        public IContactoRepository Contactos { get;  set; }
        public IContratoRepository Contratos { get;  set; }
        public ICotizacionRepository Cotizaciones { get;  set; }
        public IDepartamentoRepository Departamentos { get;  set; }
        public IDistritoRepository Distritos { get;  set; }
        public IDocumentoRepository Documentos { get;  set; }
        public IFormaPagoRepository FormaPagos { get;  set; }
        public IPedidoRepository Pedidos { get;  set; }
        public IPersonaRepository Personas { get;  set; }
        public IProductoRepository Productos { get;  set; }
        public IProveedorRepository Proveedores { get;  set; }
        public IProvinciaRepository Provincias { get;  set; }
        public IServicioRepository Servicios { get;  set; }
        public ITrabajadorRepository Trabajadores { get;  set; }
        public IUbigeoRepository Ubigeos { get;  set; }

        private UnityOfWork()
        {
            //Se crea un unico contexto para la base de datos
            //para apuntar todos los repositorios a la misma base de datos.
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

        //Implementa la clase singleton para instanciar la clase UnityOfWork
        //con este patron se asegura que en cualquier parte del codigo que se quiera
        //instancia la base de datos, sedevelva una unica referencia.
        public static UnityOfWork Instance
        {
            get
            {
                //Variable de control para manejar el acceso concurrente
                //al instanciamiento de la clase UnitytOfWork
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChange()
        {
            return _Context.SaveChanges();
        }

        /*int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }*/

        public void StateModified(object entity)
        {
            //throw new NotImplementedException();
            _Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
