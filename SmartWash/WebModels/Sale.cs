using System;
using System.Collections.Generic;

namespace SmartWash.WebModels
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
}

