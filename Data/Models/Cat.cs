using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StoreId { get; set; }
        public int BranchId { get; set; }
    }
}
