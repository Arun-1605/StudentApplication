using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.DataAccess;
using StudentAdminPortal.DataAccess.Data;
using StudentAdminPortal.DataAccess.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region RegionCorsTutor
//builder.Services.AddCors((options) =>
//{
//    options.AddPolicy("angularApplication", (builder) =>

//    {
//        builder.WithOrigins("http://localhost:4200/")
//    .AllowAnyHeader()
//    .WithMethods(HttpMethods.Get, HttpMethods.Post, HttpMethods.Put, HttpMethods.Delete)
//    .WithExposedHeaders("*");
//    });

//});
#endregion



builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")
    ));
builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region RegionCorsTutor
builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplication", (builder) =>

    {
        builder.WithOrigins("*")
    .AllowAnyHeader()
    .WithMethods(HttpMethods.Get, HttpMethods.Post, HttpMethods.Put, HttpMethods.Delete)
    .WithExposedHeaders("*");
    });

});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors("angularApplication");

app.UseAuthorization();

app.MapControllers();

app.Run();
