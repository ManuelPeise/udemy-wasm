using CarRentalApp.Shared.Domain;

namespace CarRentalApp.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        Task Save(HttpContext context);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
    }
}
