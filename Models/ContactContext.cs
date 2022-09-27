using Microsoft.EntityFrameworkCore;

namespace MultiPageContactsMeis.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Mom",
                    PhoneNum = "515-897-8596",
                    Address = "6411 Northwest Dr",
                    Note = "Mom (Margaret Meis) cell"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Dad",
                    PhoneNum = "515-202-5665",
                    Address = "1655 SE Waters Edge Dr",
                    Note = "Dad (Jamie Meis) cell"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Alexis",
                    PhoneNum = "515-802-0409",
                    Address = "6411 Northwest Dr",
                    Note = "Alexis cell"
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:multipagewebmeis.database.windows.net,1433;Initial Catalog=MultiWebMeis;Persist Security Info=False;User ID=aameis;Password=multiwebMeis!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
