using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Data.Models
{
    public class Delevery
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumber_2 { get; set; }
        public string? PhoneNumber_3 { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; } // ده اللي هيساعدك توصل لاسم الشركة

    }
}
