using Microsoft.AspNetCore.Mvc;
using PortalCampanasMVC.Models;
using PortalCampanasMVC.Services;

namespace PortalCampanasMVC.Controllers;

public class CampanasController : Controller
{
    private readonly CampanaService _campanaService;

    public CampanasController(CampanaService campanaService)
    {
        _campanaService = campanaService;
    }

    public IActionResult Index(string? categoria, string? estado)
    {
        var campanas = _campanaService.ObtenerTodas().AsQueryable();

        if (!string.IsNullOrWhiteSpace(categoria))
        {
            campanas = campanas.Where(c => c.Categoria == categoria);
        }

        if (!string.IsNullOrWhiteSpace(estado))
        {
            campanas = campanas.Where(c => c.Estado == estado);
        }

        ViewBag.CategoriaSeleccionada = categoria;
        ViewBag.EstadoSeleccionado = estado;
        ViewBag.Categorias = new List<string> { "Electro", "Hogar", "Moda", "Tecnología" };
        ViewBag.Estados = new List<string> { "Vigente", "Próxima", "Finalizada" };

        return View(campanas.ToList());
    }

    public IActionResult Detalle(int id)
    {
        var campana = _campanaService.ObtenerPorId(id);
        if (campana == null)
        {
            return NotFound();
        }

        return View(campana);
    }

    public IActionResult Resumen()
    {
        var campanas = _campanaService.ObtenerTodas();
        var resumen = new ResumenCampanasViewModel
        {
            TotalCampanas = campanas.Count,
            CampanasVigentes = campanas.Count(c => c.Estado == "Vigente"),
            CampanasProximas = campanas.Count(c => c.Estado == "Próxima"),
            PromedioDescuento = campanas.Count != 0 ? campanas.Average(c => c.DescuentoPct) : 0,
            CantidadWeb = campanas.Count(c => c.Canal == "Web"),
            CantidadApp = campanas.Count(c => c.Canal == "App"),
            CantidadTienda = campanas.Count(c => c.Canal == "Tienda")
        };

        return View(resumen);
    }
}
