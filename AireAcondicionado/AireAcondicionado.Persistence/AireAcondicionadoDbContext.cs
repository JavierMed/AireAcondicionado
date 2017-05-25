using AireAcondicionado.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence
{
    public class AireAcondicionadoDbContext : DbContext
    {
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CliEmpresa> CliEmpresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CliNatural> CliNaturales { get; set; }
        public DbSet<ComprobantePago> ComprobantePagos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<FormaPago> FormaPagos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }
    }
}
