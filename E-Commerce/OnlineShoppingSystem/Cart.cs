using lab_assignment_VandV.Data;

namespace lab_assignment_VandV.OnlineShoppingSystem
{
    public class Cart
    {
        private int Id { get; set; }
        private int NumberOfProducts { get; set; }
        private CartProducts _cartProducts;
        public Cart()
        {
            _cartProducts = new();
            NumberOfProducts = _cartProducts.GetProductsInCart().Count();
        }

        public int TotalPrice()
        {
            var sum = 0;
            foreach (var product in _cartProducts.GetProductsInCart())
            {
                sum += product.Price;
            }

            return sum;
        }

        public int TotalNumberOfProducts()
        {
            return NumberOfProducts;
        }
        public IList<Product> GetCartProducts()
        {
            return _cartProducts.GetProductsInCart();
        }

    }
}