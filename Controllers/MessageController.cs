using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Threading.Tasks;
using Messages.Models;
using System.Web;

namespace Messages.Controllers
{
    public class MessageController : Controller
    {
        // Método para redirigir al enlace de WhatsApp Web
        [HttpPost]
        public IActionResult SendWhatsAppMessage(string phoneNumber, string messageBody)
        {
            // Asegurarse de que el número esté en formato internacional correcto (sin +, sin espacios)
            string formattedNumber = phoneNumber.Replace("+", "").Replace(" ", "");

            // Codificar el mensaje en URL
            string encodedMessage = HttpUtility.UrlEncode(messageBody);

            // Construir la URL de WhatsApp Web
            string whatsappUrl = $"https://wa.me/{formattedNumber}?text={encodedMessage}";

            // Redirigir al usuario a WhatsApp Web con el mensaje
            return Redirect(whatsappUrl);
        }

        // Acción para mostrar el formulario de envío
        public IActionResult SendMessage()
        {
            return View();
        }
    }
}
