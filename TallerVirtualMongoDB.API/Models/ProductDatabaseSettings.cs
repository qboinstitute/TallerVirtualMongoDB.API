using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerVirtualMongoDB.API.Models
{
    public class ProductDatabaseSettings : IProductDatabaseSettings
    {
        public string ProductsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
