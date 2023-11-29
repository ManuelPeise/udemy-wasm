namespace CarRentalApp.Shared.Domain
{
    public class Booking: DomainBase
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehcle { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
