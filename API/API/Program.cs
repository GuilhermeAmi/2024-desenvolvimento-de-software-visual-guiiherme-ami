


using API.Models;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

app.MapGet("/", () => "Deus é pai");

app.MapGet("/SegundoTeste", () => "não é padrasto");

app.Run();


Produto produto = new Produto();

