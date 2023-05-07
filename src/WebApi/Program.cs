using FluentValidation;
using Infrastructure.Persistence;
using Logic.Products.Behaviours;
using Logic.Products.Handlers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("devexpress_demo_db"), b => b.MigrationsAssembly("Infrastructure"));
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllProductOrdersHandler).Assembly))
		.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));

builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();