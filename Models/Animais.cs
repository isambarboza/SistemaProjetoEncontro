using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEncontro.Models
{
    [Table("Animais")]
    public class Animais
    {
        [Column("AnimaisId")]
        [Display(Name = "Código dos animais")]
        public int AnimaisId { get; set; }

        [Column("AnimalNome")]
        [Display(Name = "Nome do animal")]
        public string AnimalNome { get; set; } = string.Empty;

        [Column("AnimalRaca")]
        [Display(Name = "Raça")]
        public string AnimalRaca { get; set; } = string.Empty;


        [Column("AnimalTipo")]
        [Display(Name = "Tipo")]
        public string AnimalTipo { get; set; } = string.Empty;

        [Column("AnimalCor")]
        [Display(Name = "Cor")]
        public string AnimalCor { get; set; } = string.Empty;

        [Column("AnimalSexo")]
        [Display(Name = "Sexo")]
        public string AnimalSexo { get; set; } = string.Empty;

        [Column("AnimalObservacao")]
        [Display(Name = "Observação")]
        public string AnimalObservacao { get; set; } = string.Empty;

        [Column("AnimalFoto")]
        [Display(Name = "Foto")]
        public string AnimalFoto { get; set; } = string.Empty;

        [Column("AnimalDtDesaparecimento")]
        [Display(Name = "Data do desaparecimento")]
        public DateTime AnimalDtDesaparecimento { get; set; }

        [Column("AnimalDtEncontro")]
        [Display(Name = "Data do encontro")]
        public DateTime? AnimalDtEncontro { get; set; }

        [Column("AnimalStatus")]
        [Display(Name = "Status")]
        public byte AnimalStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }


    }
}
