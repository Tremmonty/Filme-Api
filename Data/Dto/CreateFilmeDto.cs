using System.ComponentModel.DataAnnotations;

namespace Filme_Api.Data.Dto
{
    public class CreateFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo Titulo é Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor é Obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Genero até 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duração ter no mínimo 1 e no máximo 600")]
        public string Duracao { get; set; }
    }
}
