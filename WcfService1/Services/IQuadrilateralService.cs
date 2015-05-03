using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core;
using WcfService1.Core.Enums;
using System.Drawing;

namespace WcfService1.Services
{
    public interface IQuadrilateralService
    {
        QuadrilateralTypeEnum GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA);
        QuadrilateralTypeEnum GetQuadrilateralType(Point vertexA, Point vertexB, Point vertexC, Point vertexD);
    }
}
