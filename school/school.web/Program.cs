using school.web.Components;
using school.web.Data;
using school.web.Data.Services;
using school.web.Data;
using MatBlazor;
using Microsoft.EntityFrameworkCore;
using school.Db;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<CabinetService>();
builder.Services.AddScoped<ClassModelService>();
builder.Services.AddScoped<ManagmentService>();
builder.Services.AddScoped<ScheduleService>();
builder.Services.AddScoped<TeacherService>();
builder.Services.AddDbContext<SchoolDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext"));//Говорим, что есть такой DbContext и передаем через options дополнительные настройки (строка подключения и тд)
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddMatBlazor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
