using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Contextos;
using SggApp.BLL.Interfaces;
using SggApp.BLL.Servicios;
using SggApp.DAL.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Agregamos el DbContext al contenedor de dependencias usando la cadena de conexión
builder.Services.AddDbContext<SggAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2️⃣ Registramos los servicios de la capa BLL (Interfaces y sus implementaciones)
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IGastoService, GastoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IMonedaService, MonedaService>();
builder.Services.AddScoped<IPresupuestoService, PresupuestoService>();

// 3️⃣ Registramos los repositorios de la capa DAL
builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<GastoRepository>();
builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<MonedaRepository>();
builder.Services.AddScoped<PresupuestoRepository>();

// 4️⃣ Agregamos los controladores al contenedor
builder.Services.AddControllers();

// 5️⃣ Configuración de Swagger/OpenAPI para documentación de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🏗️ Construimos la aplicación con todas las configuraciones previas
var app = builder.Build();

// 6️⃣ Si estamos en modo desarrollo, activamos Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 7️⃣ Redirige automáticamente las solicitudes HTTP a HTTPS
app.UseHttpsRedirection();

// 8️⃣ Activamos la autorización (si tuvieras autenticación configurada)
app.UseAuthorization();

// 9️⃣ Mapeamos los controladores (rutas de la API)
app.MapControllers();

// 🔟 Ejecutamos la aplicación
app.Run();
