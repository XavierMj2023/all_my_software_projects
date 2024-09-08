using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WebAPI.Data;
using WebAPI.Repository;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen(c =>
		{
			 c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); // Use ConflictingActionsResolver to resolve conflicts
		});

		builder.Services.AddDbContext<APIDbContext>(options =>
		{
			options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeAngularCrud"));
		});
		builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
		builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


		//Enable CORS
		builder.Services.AddCors(options =>
		{
			options.AddPolicy("AllowOrigin", builder =>
			{
				builder.WithOrigins("http://localhost:4200") // Replace with your Angular app URL
					.AllowAnyMethod()
					.AllowAnyHeader();
			});
		});


		//builder.Services.AddControllersWithViews()
		//.AddJsonOptions(options =>
		//{
		//	options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
		//	// Additional settings if needed can be configured using options.SerializerOptions
		//});


		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI");
			});
		}
		app.UseStaticFiles(new StaticFileOptions
		{
			FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Photos")),
			RequestPath = "/Photos"
		});
		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.MapControllers();

		app.Run();
	}
}