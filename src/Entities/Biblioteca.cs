using Biblioteca.Interfaces;

namespace Biblioteca.Entities
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; } = new List<Livro>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void RegistrarEmprestimo(Cliente cliente, Livro livro)
        {
            if (livro.Disponivel)
            {
                Emprestimos.Add(new Emprestimo(livro, cliente));
                Console.WriteLine($"Empréstimo registrado para o cliente {cliente.Nome} com o livro {livro.Titulo}.");
            }
            else
            {
                Console.WriteLine("Livro indisponível para empréstimo.");
            }
        }

        public void ExibirLivrosDisponiveis()
        {
            var livrosDisponiveis = Livros.Where(l => l.Disponivel).ToList();
            Console.WriteLine("Livros disponíveis:");
            foreach (var livro in livrosDisponiveis)
            {
                livro.ExibirInformacoes();
            }
        }
    }
}