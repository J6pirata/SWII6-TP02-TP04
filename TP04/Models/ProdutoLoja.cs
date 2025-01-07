using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace TP04.Models
{
    [BindProperties]
    public class ProdutoLoja : PageModel
    {
        [Required]
        private int? Id { set; get; }
        [Required]
        [StringLength(100)]
        private string? produto { set; get; }
        [Required]
        [StringLength(100)]
        private string?  descricaoProduto { set; get; }
        [Required]
        private double? valorproduto { set; get; }   

        public ProdutoLoja() 
        { 
            
        }

    }
}
