using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Contracts;
using WebShop.Core.Models;

namespace WebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IConfiguration config;
        public ProductService(IConfiguration _config)
        {
            config = _config;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            string dataPath = config.GetSection("DataFiles:Products").Value;
            string data = await File.ReadAllTextAsync(dataPath);

            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(data);
        }
    }
}
