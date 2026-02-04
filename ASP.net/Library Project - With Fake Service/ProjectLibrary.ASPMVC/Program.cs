using Microsoft.Data.SqlClient;
using ProjectLibrary.Common.Repositories;

namespace ProjectLibrary.ASPMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();



            //Ajouts de nos services
            builder.Services.AddScoped<SqlConnection>(ServiceProvider => new SqlConnection(builder.Configuration.GetConnectionString("ProjectLibrary.Database")));
            //=> Sert à ajouter la connection string dans la SQlConnection qui est ensuite utilisée dans les services de la DAL
            //builder -> C'est l'app, .Configuration -> Va voir dans tes settings, GetConnectionString(nom_de_de_la_DB) -> Cherche la connection string qui porte le nom "nom_de_la_DB"

            // /!\
            //PENSER A AJOUTER L'INTERFACE IBookRepository à mon BLL Service et mon DAL Service
            // /!\

            builder.Services.AddScoped<IBookRepository<BLL.Entities.Book>, BLL.Services.BookService>();
            //=> A la place d'un IBookRepo<BLL.Entities.Book>, on met un BLL Services
            builder.Services.AddScoped<IBookRepository<DAL.Entities.Book>, DAL.Services.FakeBookService>();

            builder.Services.AddScoped<IUserProfileRepository<BLL.Entities.UserProfile>, BLL.Services.UserProfileService>();
            builder.Services.AddScoped<IUserProfileRepository<DAL.Entities.UserProfile>, DAL.Services.UserProfileService>();

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
