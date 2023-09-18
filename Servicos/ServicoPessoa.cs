using WebApplication1.Models;

namespace WebApplication1.Servicos
{
    public class ServicoPessoa
    {
        private static readonly string[] Nomes = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Hannah", "Ivan", "Jessica", "Kevin", "Laura", "Michael", "Nina", "Oliver", "Paula", "Quincy", "Rachel", "Samuel", "Tina", "Ulysses", "Victoria", "Walter", "Xena", "Yasmine", "Zachary" };

        public List<Pessoa> CriarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                string nome = Nomes[random.Next(Nomes.Length)];
                int idade = random.Next(18, 60); // Idades fictícias entre 18 e 59 anos
                string email = $"{nome.ToLower()}@example.com";

                Pessoa pessoa = new Pessoa(nome, idade, email);
                pessoas.Add(pessoa);
            }
            return pessoas;
        }
    }
}
