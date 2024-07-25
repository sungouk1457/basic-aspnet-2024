using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using Westwind.AspNetCore.Markdown; // ��ũ�ٿ� ��Ű�� �߰�

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // DbContext ���Ӽ� ����
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(
                builder.Configuration.GetConnectionString("MyConnection")
                ));

            // �α��� ���� ����
            builder.Services.AddSession(options => {
                options.Cookie.Name = "ASPNETPortfolioSession"; // ���� ���� ��Ű�̸�, ���!! ����X ASPNET Portfolio 
                options.IdleTimeout = TimeSpan.FromMinutes(20); // ���� ���ӽð� 20~30���� ����
            }).AddControllersWithViews(); // ������ ������ cshtml���� �����Ѵ�

            // MarkDown ���� ����
            builder.Services.AddMarkdown();
            builder.Services.AddMvc().AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseMarkdown(); // ��ũ�ٿ� ��뼳��
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession(); // ���ǻ��!
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                // URL���� : https://localhost:port/controller�̸�/action�̸�/[id](�ɼ�)

            app.Run();
        }
    }
}
