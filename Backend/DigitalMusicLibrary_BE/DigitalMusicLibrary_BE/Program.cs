using DigitalMusicLibrary.Business.Profiles;
using DigitalMusicLibrary.Business.Services;
using DigitalMusicLibrary.DataAccess.DbContexts;
using DigitalMusicLibrary.DataAccess.Repositories;
using DigitalMusicLibraryAPI.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DigitalMusicLibraryDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
	builder.Configuration["ConnectionStrings:DigitalMusicLibraryDB"]));

builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IArtistService, ArtistService>();

builder.Services.AddAutoMapper(typeof(ArtistProfile), typeof(AlbumProfile), typeof(SongProfile));

builder.Services.AddControllers(options =>
{
	options.ReturnHttpNotAcceptable = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;

	try
	{
		var context = services.GetRequiredService<DigitalMusicLibraryDBContext>();
		SeedData.Initialize(context);
	}
	catch (Exception ex)
	{
		var logger = services.GetRequiredService<ILogger<Program>>();
		logger.LogError(ex, "An error occurred creating the DB.");
	}
}

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseCors(builder =>
builder.WithOrigins("http://localhost:4200")
	  .AllowAnyHeader()
	  .AllowAnyMethod()
	  .AllowCredentials());

app.UseAuthorization();

app.ConfigureExceptionMiddleware();

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();
