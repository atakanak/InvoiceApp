using InvoiceApp.API.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy(name: "InvoiceAppOrigins",
    policy => { policy.WithOrigins("http://localhost:63603").AllowAnyMethod().AllowAnyHeader(); }
));

builder.Services.AddDbContext<InvoiceAppDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("InvoiceAppOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();