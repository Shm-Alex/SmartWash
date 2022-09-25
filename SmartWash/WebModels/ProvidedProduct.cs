namespace SmartWash.WebModels
{
    public class ProvidedProduct
    {
        int Id { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }

    }
}
