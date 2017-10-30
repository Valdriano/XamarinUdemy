using SQLite;

namespace Sinteg.Mobile.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [PrimaryKey,AutoIncrement]
        public int IDUsuario { get; set; }
        public int IDEmpresa { get; set; }
        [MaxLength( 30 )]
        public string Nome { get; set; }
        public int TipoArea { get; set; }
        [MaxLength( 20 )]
        public string NomeLogin { get; set; }
        [MaxLength( 10 )]
        public string SenhaLogin { get; set; }
        [MaxLength( 2 )]
        public string Situacao { get; set; }
    }
}
