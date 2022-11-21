using lab_assignment_VandV.Data;

namespace lab_assignment_VandV.OnlineShoppingSystem
{
    public class Guest
    {
        private Products _products;
        public Guest()
        {
            _products = new();
        }
        public IList<Product> ViewProducts()
        {
            return _products.GetProducts();
        }

        public Customer GetRegistered(Customer customer)
        {
            return customer;
        }
    }
}