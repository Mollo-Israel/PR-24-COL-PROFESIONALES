using System.ComponentModel.DataAnnotations;

namespace Messages.Models
{
    public class Message
    {
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El mensaje no puede estar vacío")]
        public string MessageText { get; set; }

        [Required]
        public MessageServiceType ServiceType { get; set; }
    }

    public enum MessageServiceType
    {
        SMS,
        WhatsApp
    }
}
