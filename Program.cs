using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using GIT_KOREA_QA_API.Filters;
using Microsoft.OpenApi.Models;
using System.Text;
using GIT_KOREA_QA_API.Services.User;
using GIT_KOREA_QA_API.Repositories.User;
using GIT_KOREA_QA_API.Middleware;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// 환경설정
string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")!;
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers();

// 리포지토리 등록
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

// 서비스 등록
builder.Services.AddScoped<IAuthService, AuthService>();

// JWT 인증 설정
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]!)),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ClockSkew = TimeSpan.Zero
        };
    });

// Swagger 설정
builder.Services.AddEndpointsApiExplorer();

// Exception Filter 적용.
builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ApiExceptionFilterAttribute());
});
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "서연이화 초중품 관리 APP API 서비스",
        Description = "서연이화 초중품 관리 APP에서 사용하는 API 서비스"
    });

    // XML 주석 파일 경로 설정
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseJwtMiddleware();
app.UseAuthentication();
app.UseAuthorization();


// 개발환경에서만 Swagger사용
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    });
}

app.MapControllers();

app.Run();
