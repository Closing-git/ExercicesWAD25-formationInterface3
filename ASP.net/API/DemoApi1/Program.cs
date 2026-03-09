
using DemoApi1.Fake;
using DemoApi1.Fake.Services;
using DemoApi1.Handlers.RouteConstraints;

namespace DemoApi1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IContext, FakeContext>();
            //POUR CONFIGUERE UNE ROUTE CONSTRAINT
            builder.Services.Configure<RouteOptions>(routeOptions =>
            {
                routeOptions.ConstraintMap.Add("postNow", typeof(PostCurrentDateConstraint));

            });

            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
