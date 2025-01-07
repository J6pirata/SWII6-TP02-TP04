using System.ComponentModel.DataAnnotations;

namespace TP04.Models
{
    public class Vendendor
    {
        [Required]
        private int _id { set; get; }
        [Required]
        [StringLength(50)]
        private string? _name   { set; get; }
        [Required]
        private string? _comissao { set; get; }


        public Vendendor() { }
    }
}
