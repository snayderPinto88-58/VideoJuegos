using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace usuarioVideojuego.Models
{
    public class Email
    {
        [Key]
        public int Id_email { get; set; }
        public string email { get; set; }

        [ForeignKey("Usuario")]
        public int Id_usuario { get; set; }
        public Usuario Usuario { get; set; }
    }

}
