using ERP.Shared.Services;
using ERP.Web.Components;
using ERP.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add device-specific services used by the ERP.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddScoped<ManufacturingApiService>();

//builder.Services.AddHttpClient<ProductApiServices>(client =>
//    client.BaseAddress = new Uri("http://localhost:5163/api/controller/PList")
//);
//builder.Services.AddHttpClient<CatalogApiServices>(client =>
//    client.BaseAddress = new Uri("http://localhost:5163/api/controller/catalogLists")
//);
builder.Services.AddScoped<ProductsApiService>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/PList") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/ODList") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/WOList") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/createorderDetails") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/listResponses") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5163/api/controller/CreateProduction") });

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(ERP.Shared._Imports).Assembly);

app.Run();