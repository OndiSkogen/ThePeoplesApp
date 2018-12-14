using ModelAndSuch.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelAndSuch.Models.ViewModels;

namespace ModelAndSuch.Models
{
    public class PeopleService
    {
        EntityContext e;

        public PeopleService(EntityContext e)
        {
            this.e = e;
        }

        public async Task<PeopleIndexVM[]> GetAllPeopleAsync()
        {
            var p = await e.Person
                .Select(o => new PeopleIndexVM
                {
                    Name = o.Name,
                    Id = o.Id,
                    Email = o.Email,
                    CompanyName = o.Company.Name,
                    ShowAsHighlighted = o.Email.StartsWith("admin")
                })
                .ToArrayAsync();
            return p;
        }

        public async Task AddPersonAsync(PeopleCreateVM p)
        {
            e.Person.Add(new Person
            {
                Name = p.Name,
                Email = p.Email
            });
            await e.SaveChangesAsync();
        }

        public async Task<PeopleDetailsVM> GetPersonByIdAsync(int id)
        {
            return await e.Person.
               Select(o => new PeopleDetailsVM
               {
                   Id = o.Id,
                   Name = o.Name,
                   Email = o.Email,
                   CompanyName = o.Company.Name
               })
               .SingleOrDefaultAsync(e => e.Id == id);
        }
    }
}
