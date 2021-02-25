using System.Collections.Generic;
using PetHero.Data.Repository;
using PetHero.Service.Dto;
using PetHero.Data.Models;

namespace PetHero.Service.Service
{
    public class OwnerService
    {
        public List<OwnerDto> GetOwners()
        {
            var repository = new OwnerRepository();
            var resultadoDaBuscaNoBanco = repository.GetAll();

            var resultadoConvertido = new List<OwnerDto>();

            resultadoDaBuscaNoBanco.ForEach(p => {
                resultadoConvertido.Add(new OwnerDto{ Name = p.Name});
            });

            return resultadoConvertido;
        }
    }
}