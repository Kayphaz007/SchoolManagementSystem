using Microsoft.EntityFrameworkCore;

namespace Backend;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Subject> Subjects { get; set; }
}
