using lab_assignment_VandV.Data;
using lab_assignment_VandV.OnlineShoppingSystem;

namespace ECommerceTest
{
    public class ProductsTest
    {
        Products products = new Products();

        [Fact]
        public void GetProductsTest()
        {
            var products = this.products.GetProducts();
            Assert.Equal(products.Count(), 4);
        }

        [Fact]
        public void GetProductTest()
        {
            var product = this.products.GetProductById("2");
            Assert.Equal(product!.Name, "ASUS");
        }

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
            this.products.AddProduct(product);
            var products = this.products.GetProducts();
            Assert.Equal(products.Count(), 5);
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
            this.products.UpdateProduct("1", product);
            var products = this.products.GetProducts();
            var updatedProduct = products.Where(x => x.Id == "1").FirstOrDefault();
            Assert.Equal(updatedProduct!.Name, "MacBook Air");
        }

        [Fact]
        public void DeleteProductTest()
        {
            this.products.DeleteProduct("1");
            var products = this.products.GetProducts();
            Assert.Equal(products.Count(), 3);
        }
    }
}