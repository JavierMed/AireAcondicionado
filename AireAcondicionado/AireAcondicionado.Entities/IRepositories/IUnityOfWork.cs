using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.IRepositories
{
    public interface IUnityOfWork:IDisposable
    {
        IAlmacenRepository Almacenes { get; set; }
        ICargoRepository Cargos { get; set; }
        ICliEmpresaRepository CliEmpresas { get; set; }
        IClienteRepository Clientes { get; set; }
        ICliNaturalRepository CliNaturales { get; set; }
        IComprobantePagoRepository ComprobantePagos { get; set; }
        IContactoRepository Contactos { get; set; }
        IContratoRepository Contratos { get; set; }
        ICotizacionRepository Cotizaciones { get; set; }
        IDepartamentoRepository Departamentos { get; set; }
        IDistritoRepository Distritos { get; set; }
        IDocumentoRepository Documentos { get; set; }
        IFormaPagoRepository FormaPagos { get; set; }
        IPedidoRepository Pedidos { get; set; }
        IPersonaRepository Personas { get; set; }
        IProductoRepository Productos { get; set; }
        IProveedorRepository Proveedores { get; set; }
        IProvinciaRepository Provincias { get; set; }
        IServicioRepository Servicios { get; set; }
        ITrabajadorRepository Trabajadores { get; set; }
        IUbigeoRepository Ubigeos { get; set; }

        int SaveChange();

        void StateModified(object entity);
    }
}
