using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartWash.WebModels
{
    public class Product
    {
        public int Id { get; set; } /*Артикул товара  может быть его следует сделать строкой*/
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNotActive { get; set; }
        public  EUnit Unit { get; set; }

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
