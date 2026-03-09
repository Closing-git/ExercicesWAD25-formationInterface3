using Microsoft.Data.SqlClient;
using ProjectProduct.Common.Repositories;

namespace Product.ASPMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("ProjectProduct.Database")!;

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<SqlConnection>(ServiceProvider => new SqlConnection(builder.Configuration.GetConnectionString("ProjectProduct.Database")));


            //Injection de dépendance des services
            builder.Services.AddScoped<IProductRepository<ProjectProduct.BLL.Entities.Product>, ProjectProduct.BLL.Services.ProductService>();
            builder.Services.AddScoped<IProductRepository<ProjectProduct.DAL.Entities.Product>, ProjectProduct.DAL.Services.ProductService>();
            builder.Services.AddScoped<IStockEntryRepository<ProjectProduct.BLL.Entities.StockEntry>, ProjectProduct.BLL.Services.StockEntryService>();
            builder.Services.AddScoped<IStockEntryRepository<ProjectProduct.DAL.Entities.StockEntry>, ProjectProduct.DAL.Services.StockEntryService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
