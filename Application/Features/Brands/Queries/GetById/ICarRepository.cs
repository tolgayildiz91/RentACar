﻿using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetById
{
    public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
    {
    }
}
