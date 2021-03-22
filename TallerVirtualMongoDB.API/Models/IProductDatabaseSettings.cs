﻿namespace TallerVirtualMongoDB.API.Models
{
    public interface IProductDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string ProductsCollectionName { get; set; }
    }
}