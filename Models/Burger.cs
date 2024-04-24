using System.ComponentModel.DataAnnotations;

namespace PrePrueba.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public bool ConQueso { get; set; }

        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }

}

