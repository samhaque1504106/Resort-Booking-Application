﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using White.Lagoon.Application.Common.Interfaces;
using White.Lagoon.Application.Common.Utility;
using White.Lagoon.Domain.Entities;
using White.Lagoon.infrastructure.Data;

namespace White.Lagoon.infrastructure.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {

        private readonly ApplicationDbContext _db;

        public BookingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Booking entity)
        {
            _db.Bookings.Update(entity);
        }

    
    }
}
