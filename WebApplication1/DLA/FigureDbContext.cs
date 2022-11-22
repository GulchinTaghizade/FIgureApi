using Microsoft.EntityFrameworkCore;
using WebApplication1.Figures;
using Point = WebApplication1.Figures.Point;
using Rectangle = WebApplication1.Figures.Rectangle;

namespace WebApplication1.Database
{
    public class FigureDbContext : DbContext
    {
        public FigureDbContext(DbContextOptions<FigureDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-DRJMU61;initial catalog=FigureDbContext;integrated security=true; Encrypt=False");
        //}

        public DbSet<Circle> Circles { get; set; }
        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<Square> Squares { get; set; }
        public DbSet<Triangle> Triangles { get; set; }
        public DbSet<Point> Points { get; set; }


    }
}
