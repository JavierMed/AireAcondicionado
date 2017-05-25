namespace AireAcondicionado.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Almacens",
                c => new
                    {
                        AlmacenId = c.Int(nullable: false, identity: true),
                        modelo = c.String(),
                        capacidad = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precioCompra = c.Double(nullable: false),
                        precioVenta = c.Double(nullable: false),
                        descuento = c.Double(nullable: false),
                        Producto_ProductoId = c.Int(),
                    })
                .PrimaryKey(t => t.AlmacenId)
                .ForeignKey("dbo.Productoes", t => t.Producto_ProductoId)
                .Index(t => t.Producto_ProductoId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        fechaInicio = c.DateTime(nullable: false),
                        fechaCulminacion = c.DateTime(nullable: false),
                        fechaGarantia = c.DateTime(nullable: false),
                        Almacen_AlmacenId = c.Int(),
                        Cotizacion_CotizacionId = c.Int(),
                        FormaPago_FormaPagoId = c.Int(),
                    })
                .PrimaryKey(t => t.ContratoId)
                .ForeignKey("dbo.Almacens", t => t.Almacen_AlmacenId)
                .ForeignKey("dbo.Cotizacions", t => t.Cotizacion_CotizacionId)
                .ForeignKey("dbo.FormaPagoes", t => t.FormaPago_FormaPagoId)
                .Index(t => t.Almacen_AlmacenId)
                .Index(t => t.Cotizacion_CotizacionId)
                .Index(t => t.FormaPago_FormaPagoId);
            
            CreateTable(
                "dbo.Cotizacions",
                c => new
                    {
                        CotizacionId = c.Int(nullable: false, identity: true),
                        fechaVisita = c.DateTime(nullable: false),
                        tipoServicio = c.String(),
                        componente = c.String(),
                        caracteristica = c.String(),
                        costo = c.Double(nullable: false),
                        ComprobantePagoId = c.Int(nullable: false),
                        TrabajadorId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        Trabajador_PersonaId = c.Int(),
                        Cliente_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.CotizacionId)
                .ForeignKey("dbo.ComprobantePagoes", t => t.ComprobantePagoId, cascadeDelete: true)
                .ForeignKey("dbo.Personas", t => t.Trabajador_PersonaId)
                .ForeignKey("dbo.Personas", t => t.Cliente_PersonaId)
                .Index(t => t.ComprobantePagoId)
                .Index(t => t.Trabajador_PersonaId)
                .Index(t => t.Cliente_PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        direccion = c.String(),
                        numDocumento = c.String(),
                        DocumentoId = c.Int(nullable: false),
                        UbigeoId = c.Int(nullable: false),
                        ClienteId = c.Int(),
                        ComprobantePagoId = c.Int(),
                        sueldo = c.Double(),
                        bono = c.Double(),
                        CliEmpresaId = c.Int(),
                        razonSocial = c.String(),
                        personaContacto = c.String(),
                        CliNaturalId = c.Int(),
                        fechaNacimiento = c.DateTime(),
                        edad = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Cargo_CargoId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("dbo.Documentoes", t => t.DocumentoId, cascadeDelete: true)
                .ForeignKey("dbo.Ubigeos", t => t.UbigeoId, cascadeDelete: true)
                .ForeignKey("dbo.Cargoes", t => t.Cargo_CargoId)
                .Index(t => t.DocumentoId)
                .Index(t => t.UbigeoId)
                .Index(t => t.Cargo_CargoId);
            
            CreateTable(
                "dbo.ComprobantePagoes",
                c => new
                    {
                        ComprobantePagoId = c.Int(nullable: false, identity: true),
                        tipoComprobante = c.String(),
                        cantidad = c.Int(nullable: false),
                        descripcion = c.String(),
                        total = c.Double(nullable: false),
                        fechaPago = c.DateTime(nullable: false),
                        CotizacionId = c.Int(nullable: false),
                        Cliente_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.ComprobantePagoId)
                .ForeignKey("dbo.Personas", t => t.Cliente_PersonaId)
                .Index(t => t.Cliente_PersonaId);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ContactoId = c.Int(nullable: false, identity: true),
                        contacto = c.String(),
                    })
                .PrimaryKey(t => t.ContactoId);
            
            CreateTable(
                "dbo.Documentoes",
                c => new
                    {
                        DocumentoId = c.Int(nullable: false, identity: true),
                        tipoDocumento = c.String(),
                    })
                .PrimaryKey(t => t.DocumentoId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        DistritoId = c.Int(nullable: false),
                        DepartamentoId = c.Int(nullable: false),
                        ProvinciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId)
                .ForeignKey("dbo.Departamentoes", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Distritoes", t => t.DistritoId, cascadeDelete: true)
                .ForeignKey("dbo.Provincias", t => t.ProvinciaId, cascadeDelete: true)
                .Index(t => t.DistritoId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        nomDepartamento = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                        nomDistrito = c.String(),
                    })
                .PrimaryKey(t => t.DistritoId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        nomProvincia = c.String(),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        CargoId = c.Int(nullable: false, identity: true),
                        nomCargo = c.String(),
                    })
                .PrimaryKey(t => t.CargoId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        fechaInicioSer = c.DateTime(nullable: false),
                        fechaFinSer = c.DateTime(nullable: false),
                        CotizacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Cotizacions", t => t.CotizacionId, cascadeDelete: true)
                .Index(t => t.CotizacionId);
            
            CreateTable(
                "dbo.FormaPagoes",
                c => new
                    {
                        FormaPagoId = c.Int(nullable: false, identity: true),
                        tipoPago = c.String(),
                    })
                .PrimaryKey(t => t.FormaPagoId);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        CompraId = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precioCompra = c.Double(nullable: false),
                        descuento = c.Double(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        ProveedorId = c.Int(nullable: false),
                        FormaPagoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.FormaPagoes", t => t.FormaPagoId, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Proveedors", t => t.ProveedorId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.ProveedorId)
                .Index(t => t.FormaPagoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        nomProducto = c.String(),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        ProveedorId = c.Int(nullable: false, identity: true),
                        nomProveedor = c.String(),
                        direccion = c.String(),
                        telefono = c.String(),
                    })
                .PrimaryKey(t => t.ProveedorId);
            
            CreateTable(
                "dbo.PersonaContactoes",
                c => new
                    {
                        Persona_PersonaId = c.Int(nullable: false),
                        Contacto_ContactoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Persona_PersonaId, t.Contacto_ContactoId })
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId, cascadeDelete: true)
                .ForeignKey("dbo.Contactoes", t => t.Contacto_ContactoId, cascadeDelete: true)
                .Index(t => t.Persona_PersonaId)
                .Index(t => t.Contacto_ContactoId);
            
            CreateTable(
                "dbo.ServicioTrabajadors",
                c => new
                    {
                        Servicio_ServicioId = c.Int(nullable: false),
                        Trabajador_PersonaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Servicio_ServicioId, t.Trabajador_PersonaId })
                .ForeignKey("dbo.Servicios", t => t.Servicio_ServicioId, cascadeDelete: true)
                .ForeignKey("dbo.Personas", t => t.Trabajador_PersonaId, cascadeDelete: true)
                .Index(t => t.Servicio_ServicioId)
                .Index(t => t.Trabajador_PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "ProveedorId", "dbo.Proveedors");
            DropForeignKey("dbo.Pedidoes", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Almacens", "Producto_ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Pedidoes", "FormaPagoId", "dbo.FormaPagoes");
            DropForeignKey("dbo.Contratoes", "FormaPago_FormaPagoId", "dbo.FormaPagoes");
            DropForeignKey("dbo.Contratoes", "Cotizacion_CotizacionId", "dbo.Cotizacions");
            DropForeignKey("dbo.Cotizacions", "Cliente_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.ServicioTrabajadors", "Trabajador_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.ServicioTrabajadors", "Servicio_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "CotizacionId", "dbo.Cotizacions");
            DropForeignKey("dbo.Cotizacions", "Trabajador_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Personas", "Cargo_CargoId", "dbo.Cargoes");
            DropForeignKey("dbo.Ubigeos", "ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Personas", "UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Ubigeos", "DistritoId", "dbo.Distritoes");
            DropForeignKey("dbo.Ubigeos", "DepartamentoId", "dbo.Departamentoes");
            DropForeignKey("dbo.Personas", "DocumentoId", "dbo.Documentoes");
            DropForeignKey("dbo.PersonaContactoes", "Contacto_ContactoId", "dbo.Contactoes");
            DropForeignKey("dbo.PersonaContactoes", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Cotizacions", "ComprobantePagoId", "dbo.ComprobantePagoes");
            DropForeignKey("dbo.ComprobantePagoes", "Cliente_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Contratoes", "Almacen_AlmacenId", "dbo.Almacens");
            DropIndex("dbo.ServicioTrabajadors", new[] { "Trabajador_PersonaId" });
            DropIndex("dbo.ServicioTrabajadors", new[] { "Servicio_ServicioId" });
            DropIndex("dbo.PersonaContactoes", new[] { "Contacto_ContactoId" });
            DropIndex("dbo.PersonaContactoes", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Pedidoes", new[] { "FormaPagoId" });
            DropIndex("dbo.Pedidoes", new[] { "ProveedorId" });
            DropIndex("dbo.Pedidoes", new[] { "ProductoId" });
            DropIndex("dbo.Servicios", new[] { "CotizacionId" });
            DropIndex("dbo.Ubigeos", new[] { "ProvinciaId" });
            DropIndex("dbo.Ubigeos", new[] { "DepartamentoId" });
            DropIndex("dbo.Ubigeos", new[] { "DistritoId" });
            DropIndex("dbo.ComprobantePagoes", new[] { "Cliente_PersonaId" });
            DropIndex("dbo.Personas", new[] { "Cargo_CargoId" });
            DropIndex("dbo.Personas", new[] { "UbigeoId" });
            DropIndex("dbo.Personas", new[] { "DocumentoId" });
            DropIndex("dbo.Cotizacions", new[] { "Cliente_PersonaId" });
            DropIndex("dbo.Cotizacions", new[] { "Trabajador_PersonaId" });
            DropIndex("dbo.Cotizacions", new[] { "ComprobantePagoId" });
            DropIndex("dbo.Contratoes", new[] { "FormaPago_FormaPagoId" });
            DropIndex("dbo.Contratoes", new[] { "Cotizacion_CotizacionId" });
            DropIndex("dbo.Contratoes", new[] { "Almacen_AlmacenId" });
            DropIndex("dbo.Almacens", new[] { "Producto_ProductoId" });
            DropTable("dbo.ServicioTrabajadors");
            DropTable("dbo.PersonaContactoes");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Productoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.FormaPagoes");
            DropTable("dbo.Servicios");
            DropTable("dbo.Cargoes");
            DropTable("dbo.Provincias");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.Documentoes");
            DropTable("dbo.Contactoes");
            DropTable("dbo.ComprobantePagoes");
            DropTable("dbo.Personas");
            DropTable("dbo.Cotizacions");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Almacens");
        }
    }
}
