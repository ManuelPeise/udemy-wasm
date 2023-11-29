namespace CarRentalApp.Shared.Domain
{
    public class Vehicle : DomainBase
    {
        public int Year { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; } = new Model();
        public int MakeId { get; set; }
        public virtual Make Make { get; set; } = new Make();
        public int ColorId { get; set; }
        public Color Color { get; set; } = new Color();
        public string Vin { get; set; } = string.Empty;
        public string LicencePlateNumber { get; set; } = string.Empty;
        public double RentalRate { get; set; }
        public virtual List<Booking> RentalRecords { get; set; } = new List<Booking>();

    }
}
