using System.ComponentModel.DataAnnotations;

namespace niverTchelo.Models
{
    public class Convidados
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        public string Presenca { get; set; }
        public string Mensagem { get; set; }
    }
}
