using Moq;
using NUnit.Framework;
using UnitTestWithMock.Entity;
using UnitTestWithMock.Interface;
using UnitTestWithMock.Service;

namespace UnitTestWithMock.Tests
{
    public class VerifyProductPriceTests
    {
        [Test]
        public void VerifyProductPrice()
        {
            //Arrange
            var cheapProduct = new Product() { Name = "Product 01", Price = 20 };
            var mockVerifyProductPrice = new Mock<IProduct>();
            mockVerifyProductPrice.Setup(x => x.VerifyProductPrice(cheapProduct)).Returns("Cheap");
            var verifyProductPriceService = new ProductService();

            //Act
            var expectedResult = mockVerifyProductPrice.Object.VerifyProductPrice(cheapProduct);
            var result = verifyProductPriceService.VerifyProductPrice(cheapProduct);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetDiscount()
        {
            //Arrange
            var expansiveProduct = new Product() { Name = "Product 02", Price = 150 };
            var mockVerifyProductPrice = new Mock<IProduct>();
            mockVerifyProductPrice.Setup(x => x.GetDiscount(expansiveProduct, 10)).Returns(true);
            var verifyProductPriceService = new ProductService();

            //Act
            var expectedResult = mockVerifyProductPrice.Object.GetDiscount(expansiveProduct, 10);
            var result = verifyProductPriceService.GetDiscount(expansiveProduct, 10);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
