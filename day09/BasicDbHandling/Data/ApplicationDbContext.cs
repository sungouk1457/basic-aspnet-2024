using BasicDbHandling.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicDbHandling.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //내용무
        }
        //CodeFirst로 만들어둔 엔티티클래스를 작성
        public DbSet<Category> Categories { get; set; }
    }
}
