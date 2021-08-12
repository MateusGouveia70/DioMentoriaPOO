using AvaCloud.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dio.AvaCloud.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullName_Test_Is_Valid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FistName = "Mateus",
                LastName = "Gouveia"
            };

            string expected = "Mateus Gouveia";
            //Act
            string result = customer.FullName;

            //Assert

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LastName_is_Empyt()
        {
            //Arrange
            Customer customer = new Customer
            {
                FistName = "Mateus",
            };

            var expected = "Mateus";

            //act
            var result = customer.FullName;

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
