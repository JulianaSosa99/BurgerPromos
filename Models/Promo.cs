namespace PrePrueba.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? Descripcion { get; set; }

        public DateTime FechaPromo { get; set; }
        public int BurgerID { get; set; }// defino la clave foranea
        public Burger? Burger { get; set; } //debemos definir las propiedades de navegacion, en ese caso de uno a muchos




    }

}
