namespace SmartWash.DAL.Models
{
    public class ProvidedProduct
    {
        int Id { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        public override string ToString() =>
@$"
{this.GetType().FullName}  
    
        {nameof(Id)}: {Id} 
        {nameof(Product)}:{Product}    
        {nameof(ProductQuantity)}:{ProductQuantity}
";


    }
}
