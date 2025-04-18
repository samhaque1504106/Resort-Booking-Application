﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using White.Lagoon.Domain.Entities;

namespace White.Lagoon.Application.Services.Interface
{
    public interface IVillaService
    {
        IEnumerable<Villa> GetAllVillas();
        Villa GetVillaById(int id);
        void CreateVilla(Villa villa);
        void UpdateVilla(Villa villa);
        bool DeleteVilla(int id);
        IEnumerable<Villa> GetVillasAvailabilityByDate(int nights, DateOnly checkInDate);
        bool IsVillaAvailable(int villaId, int nights, DateOnly checkInDate);
    }
}
