using SelFood.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelFood.Services
{
    public class ProductsDataStore : IDataStore<Product>
    {
        private readonly List<Product> _products = new List<Product>() { };

        public async Task<bool> AddItemAsync(Product item)
        {
            _products.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Product item)
        {
            var oldItem = _products.Where(p => p.Id == item.Id).FirstOrDefault();
            _products.Remove(oldItem);
            _products.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _products.Where(p => p.Id == id).FirstOrDefault();
            _products.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Product> GetItemAsync(string id)
        {
            return await Task.FromResult(_products.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Product>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_products);
        }
    }
}
