using System.Collections.Generic;

namespace SmartWash.WebModels
{
    public class SalesPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProvidedProduct> ProvidedProducts { get; set; }
   
}
