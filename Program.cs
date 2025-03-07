using EjemploMVC_MAT.Services;


var builder = WebApplication.CreateBuilder(args);

// Registra CardService para usar HttpClient correctamente.
builder.Services.AddHttpClient<CardService>();

// Agrega los servicios para usar controladores y vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura el pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapeo de rutas para controladores.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
