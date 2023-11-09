using System.ComponentModel.DataAnnotations;

namespace Teste.Core.Domain.Entity
{
    public class RegiaoDeInteresseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string? Estado { get; set; }
        public string? Sigla { get; set; }
        public string? Regiao { get; set; }
    }

}
