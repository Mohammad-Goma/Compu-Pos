namespace Compu_Pos.Data.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string? Parcode { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price_3 { get; set; }
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
