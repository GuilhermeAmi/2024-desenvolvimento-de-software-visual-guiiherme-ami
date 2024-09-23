

using Microsoft.AspNetCore.Mvc;
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();




List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Produto A", Quantidade = 10, Valor = 29.99 },
    new Produto { Nome = "Produto B", Quantidade = 20, Valor = 49.99 },
    new Produto { Nome = "Produto C", Quantidade = 5, Valor = 99.99 },
    new Produto { Nome = "Produto D", Quantidade = 15, Valor = 15.99 },
    new Produto { Nome = "Produto E", Quantidade = 8, Valor = 8.49 },
    new Produto { Nome = "Produto F", Quantidade = 12, Valor = 22.00 },
    new Produto { Nome = "Produto G", Quantidade = 30, Valor = 10.75 },
    new Produto { Nome = "Produto H", Quantidade = 7, Valor = 55.20 },
    new Produto { Nome = "Produto I", Quantidade = 18, Valor = 37.90 },
    new Produto { Nome = "Produto J", Quantidade = 25, Valor = 65.00 },
    new Produto { Nome = "Produto K", Quantidade = 6, Valor = 80.00 },
    new Produto { Nome = "Produto L", Quantidade = 14, Valor = 12.99 },
    new Produto { Nome = "Produto M", Quantidade = 22, Valor = 27.50 },
    new Produto { Nome = "Produto N", Quantidade = 11, Valor = 40.00 },
    new Produto { Nome = "Produto O", Quantidade = 9, Valor = 48.75 },
    new Produto { Nome = "Produto P", Quantidade = 4, Valor = 100.00 },
    new Produto { Nome = "Produto Q", Quantidade = 16, Valor = 34.99 },
    new Produto { Nome = "Produto R", Quantidade = 13, Valor = 59.99 },
    new Produto { Nome = "Produto S", Quantidade = 17, Valor = 23.60 },
    new Produto { Nome = "Produto T", Quantidade = 21, Valor = 30.00 }
};



app.MapGet("/", () => "Deus é pai");

app.MapGet("/api/produto/listar", () =>
{
    if (produtos.Count > 0)
    {

        return Results.Ok(produtos);

    }
    return Results.NotFound();
});





//GET: /api/produto/buscar/{id}
app.MapGet("/api/produto/buscar/{id}", ([FromRoute] string id) =>
{
    Produto? produto = produtos.Find(x => x.Id == id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(produto);
});




app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto) =>
{
    produtos.Add(produto);
    return Results.Created("", produto);
});




//DELETE: /api/produto/deletar/{id}
app.MapDelete("/api/produto/deletar/{id}", ([FromRoute] string id) =>
{
    Produto? produto = produtos.Find(x => x.Id == id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    produtos.Remove(produto);
    return Results.Ok(produto);
});




//PUT: /api/produto/alterar/{id}
app.MapPut("/api/produto/alterar/{id}", ([FromRoute] string id, [FromBody] Produto produtoAlterado) =>
{
    Produto? produto = produtos.Find(x => x.Id == id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    produto.Nome = produtoAlterado.Nome;
    produto.Quantidade = produtoAlterado.Quantidade;
    produto.Valor = produtoAlterado.Valor;
    return Results.Ok(produto);
});


app.Run();


// Produto produto = new Produto();
//Exercícios para aula de hoje
// - Buscar um produto pelo nome
// - Remover um produto
// - Alterar um produto
