using System.Collections.Generic;

namespace PetHero.Data.Repository
{
    public class PetRepository
    {
        public List<string> GetAll()
        {
            var listaDeNomes = new List<string>();
            listaDeNomes.Add("Holly");
            listaDeNomes.Add("Luly");
            listaDeNomes.Add("Bob");
            listaDeNomes.Add("Romeu");
            listaDeNomes.Add("Tá lá");
            return listaDeNomes;
        }
    }
}