using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core;
using WcfService1.Core.Enums;
using System.Drawing;
using Serilog;
using WcfService1.BusinessLogic;

namespace WcfService1.Services
{
    public class QuadrilateralService : IQuadrilateralService
    {
        private readonly ILogger _logger;

        public QuadrilateralService(ILogger logger )
        {
            _logger = logger;
        }

        public QuadrilateralTypeEnum GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            try
            {
                var q = new Quadrilateral(sideA, sideB, sideC, sideD, angleAB, angleBC, angleCD, angleDA);

                var t = new QuadrilateralTypeProvider(q);

                return t.GetQuadrilateralType();

                //return QuadrilateralTypeEnum.IsoscelesTrapezoid;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error finding quadrilateral type.");
                throw;
            }
        }

        public QuadrilateralTypeEnum GetQuadrilateralType(Point vertexA, Point vertexB, Point vertexC, Point vertexD)
        {
            try
            {
                return QuadrilateralTypeEnum.IsoscelesTrapezoid;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error finding quadrilateral type.");
                throw;
            }
        }

    }
}
