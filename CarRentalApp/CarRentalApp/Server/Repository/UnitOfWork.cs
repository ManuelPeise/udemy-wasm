using CarRentalApp.Server.Data;
using CarRentalApp.Server.IRepository;
using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make>? _makes;
        private IGenericRepository<Booking>? _bookings;
        private IGenericRepository<Color>? _colors;
        private IGenericRepository<Customer>? _customers;
        private IGenericRepository<Model>? _models;
        private IGenericRepository<Vehicle>? _vehicles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Color> Colors => _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public void Dispose()
        {
            //_context.Dispose();
            //GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext context)
        {
            var user = context?.User?.Identity?.Name ?? "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified ||
                x.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((DomainBase)entry.Entity).UpdatedAt = DateTime.Now;
                ((DomainBase)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((DomainBase)entry.Entity).CreatedAt = DateTime.Now;
                    ((DomainBase)entry.Entity).CreatedBy = user;
                }


            }

            _context?.SaveChangesAsync();
        }
    }
}
