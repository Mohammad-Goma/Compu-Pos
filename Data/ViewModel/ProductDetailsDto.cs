using Compu_Pos.Data.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.ViewModel
{
    namespace Compu_Pos.Data.ViewModel
    {
        public class ProductDetailsDto
        {
            public string? ProductName { get; set; }
            public string? Parcode { get; set; }
            public decimal Price_1 { get; set; }
            public decimal Price_2 { get; set; }
            public decimal Price_3 { get; set; }
            public string? UnitName { get; set; }
            public string? CategoryName { get; set; }
            public string? StoreName { get; set; }
            public string? BranchName { get; set; }
        }

    }
}
