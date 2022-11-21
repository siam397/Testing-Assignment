using lab_assignment_VandV.Data;

namespace lab_assignment_VandV.OnlineShoppingSystem
{
    public class Admin
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Products _products;
        public Admin()
        {
            _products = new();
        }

        public IList<string?> ViewProducts()
        {
            IList<string?> productNames = new List<string?>();
            foreach (var product in _products.GetProducts())
            {
                productNames.Add(product.Name);
            }
            return productNames;
        }

        public bool AddProducts(Product product)
        {
            _products.AddProducts(product);
            return true;
        }

        public bool DeleteProducts(string productId)
        {
            _products.DeleteProducts(productId);
            return true;
        }

        public bool ModifyProducts(string productId)
        {
            _products.UpdateProduct(productId);
            return true;
        }

        public bool MakeShipment(string id)
        {
            var product = _products.GetProductById(id);
            if (product == null)
            {
                return false;
            }
            return true;
        }

        public bool ConfirmDelivery(string id)
        {
            var product = _products.GetProductById(id);
            if (product == null)
            {
                return false;
            }
            return true;
        }

    }
}