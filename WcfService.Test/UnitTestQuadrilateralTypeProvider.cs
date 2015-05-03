using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WcfService1;
using WcfService1.Services;
using Serilog;
using WcfService1.Core.Enums;
using WcfService1.Core;
using WcfService1.BusinessLogic;
using WcfService.Test.Core;

namespace WcfService.Test
{
    [TestClass]
    public class UnitTestQuadrilateralTypeProvider
    {
        private Mock<IQuadrilateral> _quadrilateral;
        private Mock<ILogger> _logger;
        private QuadrilateralBuilder _quadBuilder;

        [TestInitialize]
        public void StartUp()
        {
            _quadrilateral = new Mock<IQuadrilateral>();
            _logger = new Mock<ILogger>();
            _quadBuilder = new QuadrilateralBuilder();
        }


        //#region Test QuadrilateralTypeProvider
        //[TestMethod]
        //public void TestQuadrilateralTypeProviderReturns()
        //{
        //    //Arrange
        //    IQuadrilateral quad = new Quadrilateral(2, 3, 4, 2, 45, 135, 135, 45);

        //    //Act
        //    var quadProvider = new QuadrilateralTypeProvider(quad);
        //    var result = quadProvider.GetQuadrilateralType();

        //    //Assert
        //    Assert.AreEqual(result, QuadrilateralTypeEnum.IsoscelesTrapezoid);
        //}

        //#endregion

        #region Test quadrilateral recognition


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Sqaure()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Square);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Square);
        }

        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Quadrilateral()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Quadrilateral);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Quadrilateral);
        }


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Parallelogram()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Parallelogram);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Parallelogram);
        }


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Trapazoid()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Trapezoid);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Trapezoid);
        }


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_IsoscelesTrapazoid()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.IsoscelesTrapezoid);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.IsoscelesTrapezoid);
        }

        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Rectangle()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Rectangle);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Rectangle);
        }


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Rhombus()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Rhombus);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Rhombus);
        }


        [TestMethod]
        public void TestQuadrilateralTypeProviderValid_Kite()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadrilateralTypeEnum.Kite);

            //Act
            var quadProvider = new QuadrilateralTypeProvider(quad);
            var result = quadProvider.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadrilateralTypeEnum.Kite);
        }

        #endregion

    }
}
