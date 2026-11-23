
using BackUrbanPark;
using BackUrbanPark.Model;
using BackUrbanPark.Repository;

namespace backUrbanPark
{
    public class Program
    {

        static void Main(string[] args)
        {

            Banco.TestarConexao();

            VagaRepository repository = new VagaRepository();

            List<Vaga> vagas = repository.BuscarTodos();

            foreach (Vaga vag in vagas)
            {
                System.Console.WriteLine($"ID: {vag.Id} - TIpo: {vag.Status} {vag.TipoVaga}");
            }
        }

          

    }

}