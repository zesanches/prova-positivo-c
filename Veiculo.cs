using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Veiculo
    {
        [Key]
        [Required]
        public int IdVeiculo { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        public int ano { get; set; }

        [Required]
        public string placa { get; set; }

        [Required]
        public string modelo { get; set; }

        [Required]
        public string marca { get; set; }

        [Required]
        public string cor { get; set; }
    }
}
