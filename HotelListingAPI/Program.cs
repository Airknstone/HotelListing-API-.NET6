using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS configuration, sets policy type and allows certain conditions, b = builder
//After setting cors, include it in pipeline app.UseCors("AllowAll");
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});


//Adding serilog package
builder.Host.UseSerilog((ctx, lc) =>
{
    //Telling builder to use serilog, ctx = instance creating, lc = logger console
    // write to console and read from configuration context, dont forget to define behavior in appsettings.json
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); //Allows computers from different areas to access resources

app.UseAuthorization();

app.MapControllers();

app.Run();
