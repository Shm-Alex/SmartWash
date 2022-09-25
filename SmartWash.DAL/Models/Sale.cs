namespace SmartWash.DAL.Models
{
    /// <summary>
    /// чек
    /// </summary>
    public class Sale {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public SalesPoint SalesPoint { get; set; }
        public Buyer Buyer { get; set; }
        public ICollection<SaleData> SaleDatas { get; set; }
        /// <summary>
        /// всего упллачено/выставлено по чеку 
        /// </summary>
        public Decimal TotalAmount { get; set; }
    }
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

