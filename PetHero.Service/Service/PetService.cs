using System.Collections.Generic;
using PetHero.Data.Repository;

namespace PetHero.Service.Service
{
    public class PetService
    {
        public List<string> PetsNames()
        {
            var petRepository = new PetRepository();
            return petRepository.GetAll();   
        }
    }
}