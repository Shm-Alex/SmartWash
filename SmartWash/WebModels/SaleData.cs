namespace SmartWash.WebModels
{
    /// <summary>
    /// строка в чеке
    /// </summary>
    public class SaleData {
        public int Id { get; set; }
        public Product Product { get; set; }    
        public int ProductSellQuantity { get; set; }
        public decimal Sum { get; set; }


    }
}

