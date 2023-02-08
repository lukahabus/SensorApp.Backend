using Microsoft.EntityFrameworkCore;
using SensorApp.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SensorAppDbContext>(configure => configure.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options =>
{
    options.MigrationsAssembly(typeof(SensorAppDbContext).Assembly.FullName);
}));

builder.Services.AddCors();
//builder.Services.AddMvc();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<SensorAppDbContext>();

    // Here is the migration executed
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Make sure you call this before calling app.UseMvc()
app.UseCors(
    options => options.WithOrigins("*").AllowAnyMethod()
);

//app.UseMvc();

app.Run();
