using Biblioteca.Interfaces;

namespace Biblioteca.Entities;

public abstract class Pessoa : IPessoa
{
    public string Nome { get; set; }
    public string CPF  { get; set; }
    
    public Pessoa(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
    
    public abstract void ObterIdentificacao();

}


