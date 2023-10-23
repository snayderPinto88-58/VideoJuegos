using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace usuarioVideojuego.Models
{
    public class VideoJuegos
    {
        [Key]
        public int Id_videojuego { get; set; }
        public string nombreVideojuego { get; set; }
        public string tipoDePago { get; set; }
        public bool EsGrupal { get; set; }
        public string Tipo { get; set; }

        [ForeignKey("Usuario")]
        public int Id_usuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
