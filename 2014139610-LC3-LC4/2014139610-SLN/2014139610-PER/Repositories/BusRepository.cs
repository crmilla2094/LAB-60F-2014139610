﻿using _2014139610_ENT;
using _2014139610_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014139610_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        public BusRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
