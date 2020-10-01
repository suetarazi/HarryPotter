﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models.Interfaces
{
    public interface IHouses
    {
        public Task<List<HouseObjects>> GetAllHouses();

        public Task<List<HouseObjects>> GetHouseById();
    }
}
