using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ContactsDbContext:DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {

        }
        public  DbSet<Contact> Contacts{ get; set; }
        
    }
}
