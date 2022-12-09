using lab_assignment_VandV.OnlineShoppingSystem;

namespace lab_assignment_VandV.Data
{
    public class CartProducts
    {
        private IList<Product> _productsInCart;
        public CartProducts()
        {
            _productsInCart = new List<Product>()
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
                    Name = "HP",
                    Group = "Technology",
                    SubGroup = "Laptop",
                    Price = 23000,
                },
            };
        }

        public IList<Product> GetProductsInCart()
        {
            return _productsInCart;
        }

        public void Add(Product product)
        {
            _productsInCart.Add(product);
        }

        public void Delete(string productId)
        {
            var product = _productsInCart.Where(x => x.Id == productId).FirstOrDefault();
            if (product != null)
            {
                _productsInCart.Remove(product);
            }
        }

    }
}