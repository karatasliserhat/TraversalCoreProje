using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TraversalCoreProje.WebAPI.Hubs;
using TraversalCoreProje.WebAPI.ServiceRegistiration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader()
         .AllowAnyMethod()
         .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();

builder.Services.AddService(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<VisitorHub>("/VisitorHub");
app.Run();
