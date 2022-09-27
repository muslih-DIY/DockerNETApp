var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/",() => "Hi! I saw You..");
app.Run();