using PortalCampanasMVC.Models;

namespace PortalCampanasMVC.Services;

public class CampanaService
{
    private readonly List<Campana> _campanas =
    [
        new() { Id = 1, Nombre = "CyberWow Electro", Categoria = "Electro", Estado = "Vigente", FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 3, 15), DescuentoPct = 30, Canal = "Web", Descripcion = "Campaña especial de electrodomésticos y tecnología para compras web." },
        new() { Id = 2, Nombre = "Renueva tu Hogar", Categoria = "Hogar", Estado = "Vigente", FechaInicio = new DateTime(2026, 3, 1), FechaFin = new DateTime(2026, 4, 1), DescuentoPct = 25, Canal = "Tienda", Descripcion = "Campaña especial para renovar tu hogar con muebles y decoración a precios increíbles en nuestras tiendas." },
        new() { Id = 3, Nombre = "Fashion Week Lima", Categoria = "Moda", Estado = "Próxima", FechaInicio = new DateTime(2026, 4, 10), FechaFin = new DateTime(2026, 4, 25), DescuentoPct = 40, Canal = "App", Descripcion = "Promociones exclusivas en moda y accesorios durante la Fashion Week." },
        new() { Id = 4, Nombre = "Tech Days", Categoria = "Tecnología", Estado = "Próxima", FechaInicio = new DateTime(2026, 5, 1), FechaFin = new DateTime(2026, 5, 10), DescuentoPct = 35, Canal = "Web", Descripcion = "Descuentos especiales en dispositivos tecnológicos seleccionados." },
        new() { Id = 5, Nombre = "Liquidación Verano", Categoria = "Moda", Estado = "Finalizada", FechaInicio = new DateTime(2026, 1, 1), FechaFin = new DateTime(2026, 1, 10), DescuentoPct = 50, Canal = "Tienda", Descripcion = "Liquidación de temporada de verano en ropa y complementos." },
        new() { Id = 6, Nombre = "Electro Fiestas Patrias", Categoria = "Electro", Estado = "Finalizada", FechaInicio = new DateTime(2026, 1, 5), FechaFin = new DateTime(2026, 1, 15), DescuentoPct = 20, Canal = "Web", Descripcion = "Campaña de descuentos por fiestas patrias en línea electro." },
        new() { Id = 7, Nombre = "Smart Home Fest", Categoria = "Tecnología", Estado = "Vigente", FechaInicio = new DateTime(2026, 3, 20), FechaFin = new DateTime(2026, 4, 5), DescuentoPct = 15, Canal = "App", Descripcion = "Promociones para hogares inteligentes y gadgets conectados." },
        new() { Id = 8, Nombre = "Deco Primavera", Categoria = "Hogar", Estado = "Próxima", FechaInicio = new DateTime(2026, 9, 1), FechaFin = new DateTime(2026, 9, 15), DescuentoPct = 20, Canal = "Tienda", Descripcion = "Campaña de decoración de primavera para el hogar." }
    ];

    public List<Campana> ObtenerTodas() => _campanas;

    public Campana? ObtenerPorId(int id) => _campanas.FirstOrDefault(c => c.Id == id);
}
