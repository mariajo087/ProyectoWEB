using Microsoft.AspNetCore.Mvc;
using ProyectoWEB.Models;

public class TransaccionesController : Controller
{
    public IActionResult Deposito()
    {
        return View();
    }

    public IActionResult Transferencia()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RealizarDeposito(decimal monto)
    {
        if (monto <= 0) return BadRequest("El monto debe ser mayor a cero.");
        return RedirectToAction("Deposito");
    }

    [HttpPost]
    public IActionResult RealizarTransferencia(string para, decimal monto)
    {
        if (monto <= 0 || string.IsNullOrEmpty(para)) return BadRequest("Datos inválidos.");
        return RedirectToAction("Transferencia");
    }
}