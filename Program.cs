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
        Title = "서연이화 초중품 관리 APP API 서비스",
        Description = "서연이화 초중품 관리 APP에서 사용하는 API 서비스"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();


// 개발환경에서만 Swagger사용
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
