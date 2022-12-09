using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_assignment_VandV.Data;
using lab_assignment_VandV.OnlineShoppingSystem;
using Xunit;

namespace ECommerceTest
{
    public class CartProductsTest
    {
        CartProducts cartProducts = new CartProducts();
        [Fact]
        public void AddProductToCartTest()
        {
            Product product = new Product
            {
                Id = "32",
                Name = "MacBook Air",
                Group = "Technology",
                SubGroup = "Laptop",
                Price = 23000,
            };
            cartProducts.Add(product);
            Assert.Equal(cartProducts.GetProductsInCart().Count(), 3);
        }

        [Fact]
        public void DeleteProductFromCartTest()
        {
            cartProducts.Delete("1");
            Assert.Equal(cartProducts.GetProductsInCart().Count(), 1);
        }

        [Fact]
        public void GetProductsInCartTest()
        {
            var products = cartProducts.GetProductsInCart();
            Assert.Equal(products.Count(), 2);
        }

    }
}