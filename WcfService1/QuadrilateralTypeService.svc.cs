using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using WcfService1.Core;
using WcfService1.Core.Enums;
using Serilog;
using Autofac;
using Autofac.Integration.Wcf;
using WcfService1.Services;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class QuadrilateralTypeService : IQuadrilateralTypeService
    {
        private readonly ILogger _logger;
        private readonly IQuadrilateralService _quadrilateralService;

        public QuadrilateralTypeService(ILogger logger, IQuadrilateralService quadrilateralService)
        {
            _logger = logger;
            _quadrilateralService = quadrilateralService;
        }

        //public string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD)
        //{
        //    return Helper.GetEnumDescription(QuadrilateralTypeEnum.Kite);
        //}

        public string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            return Helper.GetEnumDescription(_quadrilateralService.GetQuadrilateralType(sideA, sideB, sideC, sideD, angleAB, angleBC, angleCD, angleDA));
            //return Helper.GetEnumDescription(QuadrilateralTypeEnum.Kite);
        }

        public string GetQuadrilateralTypeByVertices(Point vertexA, Point vertexB, Point vertexC, Point vertexD)
        {
            return Helper.GetEnumDescription(QuadrilateralTypeEnum.Kite);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
