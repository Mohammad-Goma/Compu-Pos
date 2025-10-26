namespace Compu_Pos.Data.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? CustomerName { get; set; }
        public string? Emp_Name { get; set; }
        public ICollection<InvoiceItem>? Items { get; set; }

    }
}
   

