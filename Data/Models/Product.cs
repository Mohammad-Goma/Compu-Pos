using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Parcode { get; set; }
        public decimal Price_1 { get; set; }
        public decimal Price_2 { get; set; }
        public decimal Price_3 { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public int CatId { get; set; }  
        public int StoreId { get; set; }
        public int BranchId { get; set; }


    }
}
