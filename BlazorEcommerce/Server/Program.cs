global using BlazorEcommerce.Shared;
global using Microsoft.EntityFrameworkCore;
global using  BlazorEcommerce.Server.Data;
global using BlazorEcommerce.Server.Services.ProductService;
using Microsoft.AspNetCore.ResponseCompression;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//GZZR
builder.Services.AddDbContext<DataContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//GZZR

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//GZZR
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
//GZZR


var app = builder.Build();

//GZZR
app.UseSwaggerUI();
//GZZR


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

//GZZR
app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
