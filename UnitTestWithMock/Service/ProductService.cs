using UnitTestWithMock.Entity;
using UnitTestWithMock.Interface;

namespace UnitTestWithMock.Service
{
    public class ProductService : IProduct
    {
        public string VerifyProductPrice(Product product)
        {
            if (product.Price > 100)
                return "Expansive";
            else if (product.Price <= 100 && product.Price > 50)
                return "OK";
            else
                return "Cheap";
        }

        public bool GetDiscount(Product product, int discount)
        {
            var result = VerifyProductPrice(product);

            if (result == "Expansive" && discount <= 10)
                return true;
            else if (result == "OK" && discount <= 5)
                return true;
            else
                return false;
        }
    }
}
