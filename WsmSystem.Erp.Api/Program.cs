using WsmSystem.Erp.Api.Configurations;
using WsmSystem.Erp.Persistence;
using WsmSystem.Erp.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();
builder.Services.AddDbService(builder.Configuration);
builder.Services.AddRepositoryService();
builder.Services.AddUnitOfWorkService();
builder.Services.AddApplicationService();
builder.Services.AddUserService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
