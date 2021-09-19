using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Project_XF_Products.Model;

namespace Project_XF_Products.viewModel
{
    public class ProductsViewModel
    {
        public IList<Product> Items { get; private set; }
        public int ItemsCount { get; private set; }
        public decimal ItemsSummary { get; private set; }

        public ProductsViewModel()
        {
            var service = new ProductService();
            Items = service.GetAll.OrderBy(c => c.Name).ToList();
            ItemsCount = service.GetAll.Count;
            ItemsSummary = service.GetAll.Sum(p => p.Price);
        }
    }
}
