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

        public Product AddProduct(Product product)
        {
            _products.AddProduct(product);
            return product;
        }

        public bool DeleteProduct(string productId)
        {
            _products.DeleteProduct(productId);
            return true;
        }

        public bool ModifyProduct(string productId, Product product)
        {
            _products.UpdateProduct(productId, product);
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