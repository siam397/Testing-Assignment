using lab_assignment_VandV.OnlineShoppingSystem;

namespace ECommerceTest
{
    public class CartTest
    {
        Cart cart = new Cart();
        [Fact]
        public void TotalPriceTest()
        {
            Assert.Equal(cart.TotalPrice(), 46000);
        }

        [Fact]
        public void TotalNumberOfProductsTest()
        {
            Assert.Equal(cart.TotalNumberOfProducts(), 2);
        }
    }
}