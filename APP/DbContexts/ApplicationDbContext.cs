using APP.Entities;
using Microsoft.EntityFrameworkCore;

namespace APP.DbContexts
{
    public class ApplicationDbContext : DbContext
    {

        public virtual DbSet<PersonalData> PersonalDatas { get; set; }
        public virtual DbSet<PersonalIdentity> PersonalIdentities { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
