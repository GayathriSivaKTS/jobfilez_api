using jobfilez_api.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobfilez_api.Repository.Base
{
    interface IConnnectorSettingsRepository
    {
        Task<IEnumerable<ConnectorSettings>> GetEmployees();
    }
}
