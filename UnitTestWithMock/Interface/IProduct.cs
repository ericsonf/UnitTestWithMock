using UnitTestWithMock.Entity;

namespace UnitTestWithMock.Interface
{
    public interface IProduct
    {
        string VerifyProductPrice(Product product);
        bool GetDiscount(Product product, int discount);
    }
}
