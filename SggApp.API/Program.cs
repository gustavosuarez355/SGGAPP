using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Contextos; // Asegúrate de que esta referencia esté correcta y apunta a tu DbContext

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Agregamos el DbContext al contenedor de dependencias usando la cadena de conexión
builder.Services.AddDbContext<SggAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2️⃣ Agregamos los controladores al contenedor
builder.Services.AddControllers();

// 3️⃣ Configuración de Swagger/OpenAPI para documentación de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🏗️ Construimos la aplicación con todas las configuraciones previas
var app = builder.Build();

// 4️⃣ Si estamos en modo desarrollo, activamos Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 5️⃣ Redirige automáticamente las solicitudes HTTP a HTTPS
app.UseHttpsRedirection();

// 6️⃣ Activamos la autorización (si tuvieras autenticación configurada)
app.UseAuthorization();

// 7️⃣ Mapeamos los controladores (rutas de la API)
app.MapControllers();

// 8️⃣ Ejecutamos la aplicación
app.Run();
