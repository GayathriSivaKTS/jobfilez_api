using jobfilez_api.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobfilez_api.Repository
{
    public class ConnectorSettingsRepository
    {
        private readonly AppDbContext appDbContext;

        public ConnectorSettingsRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<ConnectorSettings>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }
    }
}
