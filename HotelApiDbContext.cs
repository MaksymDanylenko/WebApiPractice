using Microsoft.EntityFrameworkCore;
using WebApiPractice.Models;

namespace WebApiPractice
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options): base(options)
        {}

        public DbSet<RoomEntity> Rooms { get; set; }
    }
}