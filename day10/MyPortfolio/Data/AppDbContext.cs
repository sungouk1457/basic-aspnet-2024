using Microsoft.EntityFrameworkCore;
using myPortfolio.Models;

namespace myPortfolio.Data
{
    public class AppDbContext : DbContext
    {
        // 생성자
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        // CodeFirst로 테이블로 만들 엔티티 클래스 정의
        public DbSet<Board> Boards { get; set; }
        // DbContext 종속성 주입
       
    }
}
