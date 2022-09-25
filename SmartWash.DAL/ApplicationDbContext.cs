using Microsoft.EntityFrameworkCore;

namespace SmartWash.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() 
        { 
            Database.EnsureCreated();
        }
    }
}