using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace web_api.Models
{
    public class MangaContext : DbContext
    {
        public MangaContext(DbContextOptions<MangaContext> options)
            : base(options)
        {
        }

        public DbSet<Manga> Manga { get; set; } = null!;
    }
}