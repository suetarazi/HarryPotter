using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models.Interfaces
{
    public interface ICharacters
    {
        public Task<List<CharacterObject>> GetAllCharacters();

        public Task<CharacterObject> GetCharacterById(string Id);

        public Task<List<CharacterObject>> GetAllCharactersInAHouse(string house);
    }
}
