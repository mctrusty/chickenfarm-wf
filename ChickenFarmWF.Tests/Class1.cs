using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Rhino.Mocks;
using ChickenFarmWF.Models;

namespace ChickenFarmWF.Tests
{
    public class DisplayDataControllerTests
    {
        [Fact]
        public void AboutControllerReturnsChickenFarmers()
        {
            IDisplayDataView view = MockRepository.GenerateStub<IDisplayDataView>();
            DisplayDataController controller = new DisplayDataController(view);
            var result = controller.GetFarmers().ToList();
            Assert.Equal(2, result.Count);
        }
    }
}
