using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP02.Models
{
    public class BL
    {
        [Key]
        [Required]
        private int ID;

        [Required]
        [StringLength(50)]
        private string Numero;

        [Required]
        [StringLength(50)]
        private string Consignee;

        [Required]
        [StringLength(50)]
        private string Navio;



        public BL()
        {
            ID = 0;
            Numero = "0";
            Consignee = "0";    
            Navio = "0";
        }


        public BL(int id, string numero, string consignee, string navio)
        {
            ID = id;
            Numero = numero;
            Consignee = consignee;
            Navio = navio;
        }
    }
}
