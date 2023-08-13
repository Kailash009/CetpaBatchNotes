var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello First MiddleWare!\n");
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello Second MiddleWare!\n");
    await next();
});


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello Third MiddleWare!\n");
    await next();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello Fourth MiddleWare!");
});
app.Run();