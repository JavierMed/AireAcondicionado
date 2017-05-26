using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.IRepositories
{
    public interface IUnityOfWork:IDisposable
    {
        IAlmacenRepository Almacenes { get; }
        ICargoRepository Cargos { get; }
        ICliEmpresaRepository CliEmpresas { get; }
        IClienteRepository Clientes { get; }
        ICliNaturalRepository CliNaturales { get; }
        IComprobantePagoRepository ComprobantePagos { get; }
        IContactoRepository Contactos { get; }
        IContratoRepository Contratos { get; }
        ICotizacionRepository Cotizaciones { get; }
        IDepartamentoRepository Departamentos { get; }
        IDistritoRepository Distritos { get; }
        IDocumentoRepository Documentos { get; }
        IFormaPagoRepository FormaPagos { get; }
        IPedidoRepository Pedidos { get; }
        IPersonaRepository Personas { get; }
        IProductoRepository Productos { get; }
        IProveedorRepository Proveedores { get; }
        IProvinciaRepository Provincias { get; }
        IServicioRepository Servicios { get; }
        ITrabajadorRepository Trabajadores { get; }
        IUbigeoRepository Ubigeos { get; }

        int SaveChange();

        void StateModified(object entity);
    }
}
