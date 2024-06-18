using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEncontro.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código de observação")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição")]
        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local")]
        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data")]
        public string ObservacoesData { get; set; } = string.Empty;

        [ForeignKey("AnimaisId")]
        [Display(Name = "Animal")]
        public int AnimaisId { get; set; }
        public Animais? Animais { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}