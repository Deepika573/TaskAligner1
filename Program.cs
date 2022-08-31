using Microsoft.EntityFrameworkCore;
using TaskAligner.Business;
using TaskAligner.Data;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;
using TaskAligner.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TaskAlignerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskAlignerCon"));
});

builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IIssueManager, IssueManager>();
builder.Services.AddScoped<IIssueRepository, IssueRepository>();
builder.Services.AddScoped<IIssueTypeManager, IssueTypeManager>();
builder.Services.AddScoped<IIssueTypeRepository, IssueTypeRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
