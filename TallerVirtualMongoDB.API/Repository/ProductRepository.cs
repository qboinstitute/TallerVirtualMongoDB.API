using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerVirtualMongoDB.API.Models;

namespace TallerVirtualMongoDB.API.Repository
{
    public class ProductRepository
    {
        private readonly IMongoCollection<Product> _mongoCollection;

        public ProductRepository(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _mongoCollection = database.GetCollection<Product>(settings.ProductsCollectionName);

        }

        public async Task<List<Product>> Get() {
            List<Product> products;
            products = await _mongoCollection.Find(prod => true).ToListAsync();
            return products;
        }

        public async Task<Product> Insert(Product product)
        {
           await _mongoCollection.InsertOneAsync(product);
            return product;
        }



    }
}
