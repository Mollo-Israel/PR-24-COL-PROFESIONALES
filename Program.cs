using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de servicios
builder.Services.AddRazorPages(); // A�ade soporte para Razor Pages

var app = builder.Build();

// Configuraci�n del middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Muestra detalles de errores en desarrollo
}
else
{
    app.UseExceptionHandler("/Error"); // Maneja errores en producci�n
    app.UseHsts(); // Fuerza el uso de HTTPS
}

app.UseHttpsRedirection(); // Redirige HTTP a HTTPS
app.UseStaticFiles(); // Permite el uso de archivos est�ticos

app.UseRouting(); // Configura el enrutamiento

app.UseAuthorization(); // Permite la autorizaci�n

app.MapRazorPages(); // Mapea las p�ginas Razor

app.Run(); // Inicia la aplicaci�n
