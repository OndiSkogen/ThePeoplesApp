using ModelAndSuch.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelAndSuch.Models
{
    public class PeopleService
    {
        EntityContext e;

        public PeopleService(EntityContext e)
        {
            this.e = e;
        }

        public async Task<Person[]> GetAllPeopleAsync()
        {
            var p = await e.Person
                .Include(o => o.Company)
                .OrderBy(i => i.Id).ToArrayAsync();
            return p;
        }

        public async Task AddPersonAsync(Person p)
        {
            e.Add(p);
            await e.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await e.Person.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
