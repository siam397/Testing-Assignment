using lab_assignment_VandV.OnlineShoppingSystem;

namespace ECommerceTest
{
    public class GuestTest
    {
        Guest guest = new Guest();

        [Fact]
        public void ViewProductsTest()
        {
            var products = guest.ViewProducts();
            Assert.Equal(products.Count(), 4);
        }

        [Fact]
        public void GetRegisteredTest()
        {
            Customer customer = new Customer("Vandana", "Dhaka", "0171123213");
            var registeredCustomer = guest.GetRegistered(customer);
            Assert.Equal(registeredCustomer.Name, "Vandana");
        }
    }
}