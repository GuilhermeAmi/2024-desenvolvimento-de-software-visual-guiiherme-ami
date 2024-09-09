using System.Runtime.InteropServices;

namespace API.Models;

public class Produto
{
    //Construtor
    public Produto()
    {
        Id = Guid.NewGuid ().ToString();
        Criadoem = DateTime.Now;
    }
    //Atributos/Categorias - Características
    public string? Id { get; set; }

    public string? Nome { get; set; }
    public double Valor { get; set; } 

    public int Quantidade { get; set; }
    public DateTime Criadoem { get; set; }


    
}
