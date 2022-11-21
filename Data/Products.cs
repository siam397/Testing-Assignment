using lab_assignment_VandV.OnlineShoppingSystem;

namespace lab_assignment_VandV.Data
{
    public class Products
    {

        private IList<Product> _productList;
        public Products()
        {
            _productList = new List<Product>()
            {
                new Product{
                    Id = "1",
                    Name = "Lenovo",
                    Group = "Technology",
                    SubGroup = "Headphones",
                    Price = 23000,
                },
                new Product{
                    Id = "2",
                    Name = "ASUS",
                    Group = "Technology",
                    SubGroup = "Laptop",
                    Price = 23000,
                },
                new Product{
                    Id = "3",
                    Name = "AMD Ryzen",
                    Group = "Technology",
                    SubGroup = "Desktop CPU",
                    Price = 23000,
                },
                new Product{
                    Id = "4",
                    Name = "Samsung",
                    Group = "Technology",
                    SubGroup = "Mobile Phone",
                    Price = 23000,
                },
            };
        }

        public IList<Product> GetProducts()
        {
            return _productList;
        }

        public Product? GetProductById(string id)
        {
            return _productList.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddProducts(Product product)
        {
            _productList.Add(product);
        }

        public void UpdateProduct(string id)
        {
            var result = _productList.Select(product =>
            {
                product.Id = id;
                return product;
            }).ToList();
        }

        public void DeleteProducts(string id)
        {
            var product = _productList.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _productList.Remove(product);
            }
        }
    }
}