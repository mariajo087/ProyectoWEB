using Microsoft.AspNetCore.Mvc;

namespace ProyectoWEB.Controllers
{
    public class RetiroTController : Controller
    {   public ActionResult Index()
        {
            // Aquí se puede obtener el saldo de un modelo o servicio
            ViewBag.SaldoActual = 12349999.85;

            return View();
        }
    }
}
