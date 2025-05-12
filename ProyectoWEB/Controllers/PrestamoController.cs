using Microsoft.AspNetCore.Mvc;
using ProyectoWEB.Models;
using System.Collections.Generic;

public class PrestamoController : Controller
{
    private static List<Prestamo> prestamos = new List<Prestamo>();

    public IActionResult Index()
    {
        return View(prestamos);
    }

    [HttpPost]
    public IActionResult SolicitarPrestamo(decimal monto)
    {
        if (monto <= 0) return BadRequest("El monto debe ser mayor a cero.");

        var nuevoPrestamo = new Prestamo { Monto = monto, Referencia = "Nuevo préstamo" };
        prestamos.Add(nuevoPrestamo);

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult PagarPrestamo(decimal monto, string referencia)
    {
        if (monto <= 0 || string.IsNullOrEmpty(referencia)) return BadRequest("Datos inválidos.");

        return RedirectToAction("Index");
    }
}