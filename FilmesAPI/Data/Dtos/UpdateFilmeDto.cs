using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo título é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passsar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 200, ErrorMessage = "A duração deve ter no mínimo 1 e no maximo 200 min")]
        public int Duracao { get; set; }
    }
}
