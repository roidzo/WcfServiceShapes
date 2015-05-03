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
    public class UnitTest1
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


        [TestMethod]
        public void TestWcfServiceImplementation()
        {
            //Arrange
            //_quadrilateralTypeService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(Helper.GetEnumDescription(QuadrilateralTypeEnum.Parallelogram));
            //_quadrilateralService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(QuadrilateralTypeEnum.Parallelogram);

            //Act
            var result = _service.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2);

            //Assert
            Assert.AreEqual(result, Helper.GetEnumDescription(QuadrilateralTypeEnum.Kite));
        }

        //[TestMethod]
        //public void TestGetQuadrilateralType()
        //{
        //    //public QuadrilateralTypeEnum GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleDAB, int angleABC, int angleBCD, int angleCDA)

        //    //Arrange
        //    _quadrilateralService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(QuadrilateralTypeEnum.Parallelogram);

        //    //Act
        //    //var ex = Assert.Throws<System.IO.FileNotFoundException>(() => _contactManager.RunApplication(_filePath));
        //    //var b = _quadrilateralService.Verify(m => m.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2));
        //    //_quadrilateralService. (m => m.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2));

        //    //var blah = Assert.AreEqual(b, QuadrilateralTypeEnum.Parallelogram);

        //    //Assert


        //    // mock wcf interface
        //    Mock<IWCFService> wcfMock = new Mock<IWCFService>();

        //    // setup for wcf service GetData method
        //    wcfMock.Setup<string>(s => s.GetData(It.IsAny<int>())).Returns(val);

        //    // create object to register with IoC
        //    IWCFService wcfMockObject = wcfMock.Object;

        //    // register instance
        //    UnityHelper.IoC = new UnityContainer();
        //    UnityHelper.IoC.RegisterInstance<IWCFService>(wcfMockObject);


        //    // create ServiceAgent object using parameterized constructor (for unit test)

        //    WCFServiceAgent serviceAgent = new WCFServiceAgent(true);

        //    // method call to be tested

        //    actualRetVal = serviceAgent.HitWCFService();

        //    // verify if the expected method called during test or not
        //    wcfMock.Verify(s => s.GetData(It.IsAny<int>()), Times.Exactly(1));

        //    Assert.AreEqual("MockedValue", actualRetVal, "Not same.");


        //}
    }
}
