using lab_assignment_VandV.Data;

namespace lab_assignment_VandV.OnlineShoppingSystem
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        private CartProducts _cartProducts;
        private Products _products;
        public Customer()
        {
            _cartProducts = new();
            _products = new();
        }

        public bool BuyProducts()
        {
            if (_cartProducts.GetProductsInCart().Count() > 0)
            {
                return true;
            }
            return false;
        }

        public IList<Product> ViewProducts()
        {
            return _products.GetProducts();
        }

        public Payment MakePayment()
        {
            return new Payment()
            {
                CustomerId = Id,
                CardNo = "2",
                CardType = "shundor"

            };
        }

        public void AddToCart(Product product)
        {
            _cartProducts.Add(product);
        }

        public void DeleteFromCart(string productId)
        {
            _cartProducts.Delete(productId);
        }

    }
}