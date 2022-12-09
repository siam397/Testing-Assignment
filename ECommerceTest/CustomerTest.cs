using lab_assignment_VandV.Data;
using lab_assignment_VandV.OnlineShoppingSystem;

namespace ECommerceTest;

public class CustomerTest
{
    Customer customer = new Customer("Vandana", "Dhaka", "0171123213");
    Products products = new Products();
    [Fact]
    public void PaymentTest()
    {
        Payment payment = customer.MakePayment();
        Assert.Equal(23, payment.CustomerId);
    }

    [Fact]
    public void AddToCartTest()
    {
        var product = products.GetProducts()[0];
        customer.AddToCart(product);
        var cartProducts = customer.GetCartProducts();
        Assert.Equal(cartProducts.GetProductsInCart().Count(), 3);
    }

    [Fact]
    public void CartDeleteTest()
    {
        customer.DeleteFromCart("1");
        var cartProducts = customer.GetCartProducts();
        Assert.Equal(cartProducts.GetProductsInCart().Count(), 1);
    }

    [Fact]
    public void ViewProductsTest()
    {
        var products = customer.ViewProducts();
        Assert.Equal(products.Count(), 4);
    }

    [Fact]
    public void BuyProductsTest()
    {
        var products = customer.ViewProducts();
        customer.AddToCart(products[0]);
        var result = customer.BuyProducts();
        Assert.True(result);
    }

}