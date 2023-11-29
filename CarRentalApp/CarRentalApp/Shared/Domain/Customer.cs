namespace CarRentalApp.Shared.Domain
{
    public class Customer: DomainBase
    {
        public string TaxId { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string EmailAdress { get; set; } = string.Empty;
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}