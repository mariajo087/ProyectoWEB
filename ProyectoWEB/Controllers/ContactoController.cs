using ProyectoWEB.Models;

using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace ProyectoWEB.Controllers
{
    [ApiController]

    public class ContactoController : Controller
    {
  

        [HttpPost]
        [Route("api/correo/enviar")]
        public IActionResult EnviarCorreo([FromBody] Contacto contacto)
        {
            if (!ModelState.IsValid)
            {
                return View("Contactame", contacto);
            }

            try
            {
                var from = "proyectoiue510@gmail.com";
                var to = contacto.Email;
                var subject = contacto.Asunto;
                var body = $"Nombre: {contacto.Nombre}\nEmail: {contacto.Email}\nMensaje: {contacto.Mensaje}";

                var smtp = new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(from, "jlqa pnjd knux wkdz"),
                    Port = 587
                };

                var mail = new MailMessage(from, to, subject, body);
                smtp.Send(mail);

                ViewBag.Mensaje = "Correo enviado exitosamente.";
                return Ok();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al enviar el correo: " + ex.Message + ex.Source;
                return StatusCode(500, new { exito = false, mensaje = ex.Message + ex.Source });

            }

            return View("Contactame");
        }



    }

}
