namespace SmartWash.DAL.Models
{
    public class Buyer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() =>
@$"
{this.GetType().FullName}  
    {nameof(Id)}: {Id} 
    {nameof(Name)}:{Name}
";

    }
}
