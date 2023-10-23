using System.ComponentModel.DataAnnotations;

namespace usuarioVideojuego.Models
{
    public class Usuario
    {
        [Key]
        public int Id_usuario { get; set; }
        public string nombreUsuario { get; set; }
        public string genero { get; set;}
        public int edad { get; set;}
    }
}
