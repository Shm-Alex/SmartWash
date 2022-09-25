namespace SmartWash.DAL.Models
{
    /// <summary>
    /// строка в чеке
    /// </summary>
    public class SaleData {
        public int Id { get; set; }
        public Product Product { get; set; }    
        public int ProductSellQuantity { get; set; }
        public Decimal Sum { get; set; }


    }
}

