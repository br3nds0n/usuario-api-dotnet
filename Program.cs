using Microsoft.EntityFrameworkCore;
using usuario_net.Data.Context;
using usuario_net.Data.Repository;
using usuario_net.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UsuarioContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
