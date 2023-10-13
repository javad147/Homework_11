using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.Service.Service;



namespace Classroom11Teacher.Controllers
{
    internal class ProductController
    {
        private readonly ProductServie _productService;

        public ProductController()
        {
            _productService = new ProductServie();
        }
        public void GetAllByCount() 
        {
            foreach (var item in _productService.(14)) 
            {
                Console.WriteLine($"{item.Name} - {item.Count} - {item.Color}");

            }
        
        }
    }
}
