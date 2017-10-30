using SQLite;

namespace Projeto04.Models
{
    [Table( "Tarefas" )]
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength( 60 )]
        public string Nome { get; set; }
        public bool Finalizada { get; set; }
    }
}
