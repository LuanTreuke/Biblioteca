using Biblioteca.Interfaces;

namespace Biblioteca.Entities
{
    public class Emprestimo
    {
        public Livro Livro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public Emprestimo(Livro livro, Cliente cliente)
        {
            Livro = livro;
            Cliente = cliente;
            DataEmprestimo = DateTime.Now;
            DataDevolucao = null;

            livro.Disponivel = false;
        }

        public void RegistrarDevolucao()
        {
            DataDevolucao = DateTime.Now;
            Livro.Disponivel = true;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Livro: {Livro.Titulo}, Cliente: {Cliente.Nome}, Data do Empréstimo: {DataEmprestimo}, Data de Devolução: {DataDevolucao?.ToString() ?? "Não devolvido"}");
        }
    }
}