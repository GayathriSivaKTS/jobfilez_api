using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobfilez_api.Data.model
{
    public class ConnectorSettings
    {
       public int SettingID { get; set; }
       public int ASPClientID { get; set; }
        public string SourceSystem { get; set; }
        public string JobFilezUserID { get; set; }
        public string QBORealmID { get; set; }
        public string QBOClientId { get; set; }
        public string QBOClientSecret { get; set; }
        public string QBOScope { get; set; }
        public string QBORefreshToken { get; set; }
        public DateTime TokenValidFrom { get; set; }
        public DateTime TokenValidTo { get; set; }
        public string QBOAPAccountRefID { get; set; }
        public bool IsActive { get; set; }
        public bool IsMigrationRequired { get; set; }
        public bool IsMigrationCompleted { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public int? MaxinvoiceId { get; set; }
        public int? MaxpurchaseOrderId { get; set; }

        public short InstanceId { get; set; }
        public bool EnableJFMigration { get; set; }
        public bool EnableSourceSystemMigration { get; set; }
        public bool EnableOpenInvoiceMigrate { get; set; }
        public bool IsStockUpdateRequired { get; set; }
        public bool syncCategory { get; set; }
        public DateTime MigrationCompletedDateInUTC { get; set; }
        public DateTime DailySyncEnabledDateInUTC { get; set; }


    }
}
