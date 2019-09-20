using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasMany<Author>(s => s.Authors)
                .WithMany(c => c.Books)
                .Map(cs =>
                        {
                            cs.MapLeftKey("BookRefId");
                            cs.MapRightKey("AuthorRefId");
                            cs.ToTable("BookAuthor");
                        });
        }
    }
}
