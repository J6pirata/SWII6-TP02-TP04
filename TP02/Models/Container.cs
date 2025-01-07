using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP02.Models
{
    public class Container
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int ID { set; get; }

        [Required]
        private char[] Numero { get; set; } new char[11];

        [Required]
        private string Tipo { set; get; }

        [Required]
         
        private int Tamanho { set; get; }  


        public Container()
        {
            ID = 0;
            Numero = "00000000000" . ToCharArray();
            Tipo = " ";
            Tamanho = 20;
        }

        public Container(int id, string numero, string tipo, int tamanho)
        {
            ID = id;
            Numero = numero.ToCharArray();
            Tipo = tipo;
            Tamanho = tamanho; 
        
        }
    }
}
