using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core.Enums;
using WcfService1.BusinessLogic;

namespace WcfService.Test.Core
{
    public class QuadrilateralBuilder
    {
        //private readonly QuadrilateralTypeEnum quadrilateralType;
        
        public QuadrilateralBuilder()
        {
            //quadrilateralType = quadrilateralType;
        }

        public IQuadrilateral Build(QuadrilateralTypeEnum quadrilateralType)
        {
            IQuadrilateral q;

            switch (quadrilateralType)
            {
                case QuadrilateralTypeEnum.Unknown:
                    q = new Quadrilateral(11, 1, 1, 1, 190, 90, 90, 90); //TODO: Cannot create an unknown type without error.
                    break;
                case QuadrilateralTypeEnum.Parallelogram:
                    q = new Quadrilateral(2, 3, 2, 3, 45, 135, 45, 135);
                    break;
                case QuadrilateralTypeEnum.Rectangle:
                    q = new Quadrilateral(4, 2, 4, 2, 90, 90, 90, 90);
                    break;
                case QuadrilateralTypeEnum.Rhombus:
                    q = new Quadrilateral(2, 2, 2, 2, 45, 135, 45, 135);
                    break;
                case QuadrilateralTypeEnum.Square:
                    q = new Quadrilateral(2, 2, 2, 2, 90, 90, 90, 90);
                    break;
                case QuadrilateralTypeEnum.Kite:
                    q = new Quadrilateral(1, 1, 3, 3, 30, 140, 50, 140);
                    break;
                case QuadrilateralTypeEnum.Trapezoid:
                    q = new Quadrilateral(5, 4, 4, 6, 120, 60, 90, 90);
                    break;
                case QuadrilateralTypeEnum.IsoscelesTrapezoid:
                    q = new Quadrilateral(2, 3, 4, 3, 45, 135, 135, 45);
                    break;
                case QuadrilateralTypeEnum.Quadrilateral:
                    q = new Quadrilateral(4, 4, 7, 5, 160, 30, 70, 100);
                    break;
                default:
                    q = new Quadrilateral(4, 4, 7, 5, 160, 30, 70, 100);
                    break;
            }

            return q;
        }

        public IQuadrilateral BuildInvalidAngle(QuadrilateralTypeEnum quadrilateralType)
        {
            IQuadrilateral q;
            q = new Quadrilateral(1, 1, 1, 1, 90, 90, 90, 90);

            return q;
        }

        public IQuadrilateral BuildInvalidLength(QuadrilateralTypeEnum quadrilateralType)
        {
            IQuadrilateral q;
            q = new Quadrilateral(1, 1, 1, 1, 90, 90, 90, 90);
            return q;
        }

    }
}
