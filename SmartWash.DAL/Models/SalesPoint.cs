namespace SmartWash.DAL.Models
{
    public class SalesPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProvidedProduct> ProvidedProducts { get; set; }
        public override string ToString() =>
@$"
{this.GetType().FullName}  
{nameof(Id)}: {Id}   
    {nameof(Name)}:{Name}    
    {nameof(ProvidedProducts)}:{ProvidedProducts.Count}[{string.Join(',', ProvidedProducts.Select(p => p.ToString()).ToArray())}]   
        ";
    }

}
