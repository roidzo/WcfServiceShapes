using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WcfService1;
using WcfService1.Services;
using Serilog;
using WcfService1.Core.Enums;
using WcfService1.Core;

namespace WcfService.Test
{
    [TestClass]
    public class UnitTestQuadrilateralService
    {
        private Mock<IQuadrilateralTypeService> _quadrilateralTypeService;
        private Mock<IQuadrilateralService> _quadrilateralService;
        private Mock<ILogger> _logger;
        //private Mock<IWCFService> _logger;
        // Our service
        //private Mock<WcfService1.IQuadrilateralTypeService> _serviceMock;
        private WcfService1.IQuadrilateralTypeService _service;

        [TestInitialize]
        public void StartUp()
        {
            _quadrilateralService = new Mock<IQuadrilateralService>();
            _logger = new Mock<ILogger>();

            //_serviceMock = new Mock<IQuadrilateralTypeService>();
            _service = new QuadrilateralTypeService(_logger.Object, _quadrilateralService.Object);
        }

          [TestMethod]
        public void TestGetQuadrilateralTypeService()
        {
            //Arrange
            //_quadrilateralTypeService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(Helper.GetEnumDescription(QuadrilateralTypeEnum.Parallelogram));
            //_quadrilateralService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(QuadrilateralTypeEnum.Parallelogram);
            
             //Act
            //var result = _quadrilateralService.Object.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2);
            var quadFinderService = new QuadrilateralService(_logger.Object);
            var result = quadFinderService.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2);
                        
             //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.IsoscelesTrapezoid);
        }

    }
}
