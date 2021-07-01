using jobfilez_api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobfilez_api.Service.Base
{
    interface IConnectorSettingsService
    {
        Task<ConnectorSettingsDomain> ConnectorSettingsService();
    }
}
