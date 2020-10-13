using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models.Interfaces
{
    public interface ISpells
    {
        public Task<List<SpellsObject>> GetAllSpells();

        public Task<List<SpellsObject>> GetSpellsByType(string type);
    }
}
