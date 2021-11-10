using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        // <Product> is Mongo db Product entity
        IMongoCollection<Product> Products { get; }
    }
}
