using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGECA_Shop.Data
{
    public interface ISigecaDataBaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string StorageConnectionString { get; set; }

    }
    public class SigecaDataBaseSettings : ISigecaDataBaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string StorageConnectionString { get; set; }
    }
}
