using ModelAndSuch.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAndSuch.Models
{
    public class CompanyService
    {
        EntityContext e;

        public CompanyService(EntityContext e)
        {
            this.e = e;
        }

        public async Task AddCompanyAsync(Company c)
        {
            e.Add(c);
            await e.SaveChangesAsync();
        }
    }
}
