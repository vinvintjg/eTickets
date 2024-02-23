﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);

        void Delete(int id);
        Task<string?> GetAllAsync();
    }
}
