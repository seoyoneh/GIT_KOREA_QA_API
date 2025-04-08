using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "������ȭ ����ǰ ���� APP API ����",
        Description = "������ȭ ����ǰ ���� APP���� ����ϴ� API ����"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();


// ����ȯ�濡���� Swagger���
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
