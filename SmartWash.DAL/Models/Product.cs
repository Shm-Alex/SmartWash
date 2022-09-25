using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartWash.DAL.Models
{
    //public  class Debugable {
    //    public override string ToString() => $"{this.GetType().FullName} ";
    //}

    /// <summary>
    /// модель товара
    /// </summary>
    public class Product
    {
        public int Id { get; set; } /*Артикул товара  может быть его следует сделать строкой*/
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        /// <summary>
        ///  Дата время  обновленяи информации отоваре ( Цены например)
        /// </summary>
        public DateTime Updated { get; set; }
        /// <summary>
        /// при удалении товара вся информация по выставленным счетам не должна наверное исчезать из бд.
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Продукт может быть на складе но может не продаваться, или его может не быть  на складе , но информация 
        /// </summary>
        public bool IsNotActive { get; set; }
        /// <summary>
        /// Единица измерения (килограмы/литры/штуки)
        /// </summary>
        public  EUnit Unit { get; set; }
        public override string ToString() =>
@$"
{this.GetType().FullName}  
    {nameof(Id)}: {Id} 
    {nameof(Name)}:{Name}
    {nameof(Price)}:{Price}   
    {nameof(IsDeleted)}:{IsDeleted}   
";

    }
    /// <summary>
    /// Есдиница измерения товара, за которую выстврена цена
    /// </summary>
    public enum EUnit
    {
        EUndefined = 0,
        //Килограмм
        EKilogram =1,
        //Литр
        ELitre = 2,
        //Штука
        EPiece=3,
        //Упаковка
        EBLock=4
    }
}
