using Domain.Models;

namespace Classroom11Teacher.Controllers
{
    public class ProductServie
    {
        public class ProductService
        {
            private Productc[] GetAll()
            {
                return new Productc[]
                {
                new Productc { Id = 1, Name = "Iphone14", Price = 3000, Color = "White", Count = 10},
                new Productc { Id = 2, Name = "Iphone12", Price = 2000, Color = "Black", Count = 20 },
                new Productc { Id = 3, Name = "Iphone11", Price = 1000, Color = "Silver", Count = 5 },
                new Productc { Id = 4, Name = "Iphone15", Price = 4000, Color = "White", Count = 10 },
                };
            }

            public Productc[] GetAllByCount(int count)
            {
                Productc[] products = GetAll();

                return products.Where(m => m.Count > count).ToArray();

            }
        }
    }
}
}