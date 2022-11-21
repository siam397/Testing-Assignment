using lab_assignment_VandV.Data;

namespace lab_assignment_VandV.OnlineShoppingSystem
{
    public class Cart
    {
        public int Id { get; set; }
        public int NumberOfProducts { get; set; }
        public CartProducts _cartProducts;
        public Cart()
        {
            _cartProducts = new();
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
    }
}