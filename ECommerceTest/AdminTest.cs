using lab_assignment_VandV.OnlineShoppingSystem;
using Xunit;

namespace ECommerceTest
{
    public class AdminTest
    {
        Admin admin = new Admin();

        [Fact]
        public void AddProductTest()
        {
            Product product = new Product
            {
                Id = "32",
                Name = "MacBook Air",
                Group = "Technology",
                SubGroup = "Laptop",
                Price = 23000,
            };
            var addedProduct = admin.AddProduct(product);
            Assert.Equal(addedProduct.Id, "32");
        }

        [Fact]
        public void UpdateProductTest()
        {
            Product product = new Product
            {
                Id = "1",
                Name = "MacBook Air",
                Group = "Technology",
                SubGroup = "Laptop",
                Price = 92000,
            };
            var updatedProduct = admin.ModifyProduct("1", product);
            Assert.Equal(updatedProduct, true);
        }

        [Fact]
        public void DeleteProductTest()
        {
            var deletedProduct = admin.DeleteProduct("1");
            Assert.Equal(deletedProduct, true);
        }

        [Fact]
        public void GetProductTest()
        {
            var products = admin.ViewProducts();
            Assert.Equal(products!.Count(), 4);
        }

        [Fact]
        public void MakeShipmentTest()
        {
            var shipment = admin.MakeShipment("1");
            Assert.Equal(shipment, true);
        }

        [Fact]
        public void ConfirmDeliveryTest()
        {
            var delivery = admin.ConfirmDelivery("1");
            Assert.Equal(delivery, true);
        }
    }
}