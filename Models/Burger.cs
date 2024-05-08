using System.ComponentModel.DataAnnotations;

namespace PrePrueba.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public bool ConQueso { get; set; }

        [VerificarRango]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor > 20)
            {
                return false;

            }
            else
            {
                return true;//cambio hecho
            }

            

        }
    }

}

