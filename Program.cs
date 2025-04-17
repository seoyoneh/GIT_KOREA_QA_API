using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using GIT_KOREA_QA_API.Filters;
using Microsoft.OpenApi.Models;
using System.Text;
using GIT_KOREA_QA_API.Services.User;
using GIT_KOREA_QA_API.Repositories.User;
using GIT_KOREA_QA_API.Middleware;
using System.Reflection;
using GIT_KOREA_QA_API.Services.Common;
using GIT_KOREA_QA_API.Services.Inspection;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using GIT_KOREA_QA_API.Repositories.Inspection;

var builder = WebApplication.CreateBuilder(args);

// Kestrel 서버 설정
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Configure(builder.Configuration.GetSection("Kestrel"));
});

// appsettings에서 글로벌화 설정 가져오기
var globalizationSection = builder.Configuration.GetSection("Globalization");
var defaultCulture = globalizationSection["DefaultCulture"] ?? "ko-KR";
var defaultTimeZone = globalizationSection["TimeZone"] ?? "Korea Standard Time";

// 지원되는 문화권 설정
var supportedCultures = new[] { new CultureInfo(defaultCulture) };

// 로케일 설정
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(defaultCulture);
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

// 서비스에 타임존 추가 (DI에서 사용할 수 있도록)
builder.Services.AddSingleton(TimeZoneInfo.FindSystemTimeZoneById(defaultTimeZone));

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
builder.Services.AddScoped<IInspectionRepository, InspectionRepository>();

// 서비스 등록
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddScoped<IInspectionService, InspectionService>();

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

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT 인증 헤더를 사용하고 있습니다. 인증예시: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
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
