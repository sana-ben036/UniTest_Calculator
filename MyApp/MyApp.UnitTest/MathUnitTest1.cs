using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp.ViewModels;

namespace MyApp.UnitTest
{
    [TestClass]
    public class MathUnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange

            var vm = new MathViewModel();
            vm.ValueA = 4;
            vm.ValueB = 6;

            //Act

            vm.AddCommand.Execute(null);

            //Assert

            Assert.IsTrue(vm.Result == 9, "vm.Result != 10 !");

        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange

            var vm = new MathViewModel();
            vm.ValueA = 4;
            vm.ValueB = 4;

            //Act

            vm.AddCommand.Execute(null);

            //Assert

            Assert.IsTrue(vm.Result == 16, "vm.Result != 16 !");

        }
    }
}
