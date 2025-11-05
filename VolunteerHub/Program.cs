using VolunteerHub.DataContext.DataContextVolunteer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddScoped<IDataContext, DataContext>(); - יוצר מופע  חדש עבור כל בקשה
//יוצר מופע בודד עבור כל זמן הריצה (עבור כל הבקשות)
builder.Services.AddSingleton<IDataContext, DataContext>();
//builder.Services.AddTransient<IDataContext, DataContext>(); - יוצר מופע חדש עבור על אוביקט (גם אם באותה הבקשה יהיה כמה פעמים מופעים)
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
