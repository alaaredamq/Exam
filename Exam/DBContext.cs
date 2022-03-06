using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam {

    public class DBContext: DbContext {
        public DBContext(DbContextOptions<DBContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Branch> Branches { get; set; }

    }
}
