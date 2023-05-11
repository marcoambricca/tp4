using Microsoft.AspNetCore.Mvc;

namespace TP4.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.equipos = Equipos.ListaEquipos;
        ViewBag.medias = Equipos.ListaMedias;
        ViewBag.pantalones = Equipos.ListaPantalones;
        ViewBag.camisetas = Equipos.ListaRemeras;
        ViewBag.Colores = Equipos.ListaColores;
        return View();
    }

    public IActionResult GuardarIndumentaria(string Equipo, int Remera, int Pantalon, int Media)
    {
            Indumentaria nuevo = new Indumentaria(Equipos.ListaRemeras[Remera-1], Equipos.ListaPantalones[Pantalon-1], Equipos.ListaMedias[Media-1]);
            Equipos.IngresarIndumentaria(Equipo, nuevo);
            ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
            ViewBag.Colores = Equipos.ListaColores;
            return View("Index");
    }
}
