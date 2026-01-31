using System.Text.Json.Serialization;
using VolunteerHub.Core;
using VolunteerHub;
using VolunteerHub.Core.Repositories;
using VolunteerHub.Core.Services;
using VolunteerHub.Data;


using VolunteerHub.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICoordinatorRepository, CoordinatorRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IVolunteerRepository, VolunteerRepository>();

builder.Services.AddScoped<ICoordinatorService, CoordinatorsService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IVolunteerService, VolunteerService>();
builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(MappingPostModeles));


builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
