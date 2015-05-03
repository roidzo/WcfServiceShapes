using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WcfService1.Core.Enums;

namespace WcfService1.BusinessLogic
{
    public class Quadrilateral : IQuadrilateral
    {
        public Dictionary<QuadrilateralSideNamesEnum, int> Sides { get; private set; }
        public Dictionary<QuadrilateralAngleNamesEnum, int> Angles { get; private set; }

        //public int SideA { get; private set; }
        //public int SideB { get; private set; }
        //public int SideC { get; private set; }
        //public int SideD { get; private set; }
        //public int AngleDAB { get; private set; }
        //public int AngleABC { get; private set; }
        //public int AngleBCD { get; private set; }
        //public int AngleCDA { get; private set; }

        public Quadrilateral(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            Sides = new Dictionary<QuadrilateralSideNamesEnum, int>();
            Sides.Add(QuadrilateralSideNamesEnum.A, sideA);
            Sides.Add(QuadrilateralSideNamesEnum.B, sideB);
            Sides.Add(QuadrilateralSideNamesEnum.C, sideC);
            Sides.Add(QuadrilateralSideNamesEnum.D, sideD);

            Angles = new Dictionary<QuadrilateralAngleNamesEnum, int>();
            Angles.Add(QuadrilateralAngleNamesEnum.AB, angleAB);
            Angles.Add(QuadrilateralAngleNamesEnum.BC, angleBC);
            Angles.Add(QuadrilateralAngleNamesEnum.CD, angleCD);
            Angles.Add(QuadrilateralAngleNamesEnum.DA, angleDA);

            //SideA = sideA;
            //SideB = sideB;
            //SideC = sideC;
            //SideD = sideD;
            //AngleDAB = angleDAB;
            //AngleABC = angleABC;
            //AngleBCD = angleBCD;
            //AngleCDA = angleCDA;

            Validate();
        }

        public Quadrilateral(Point vertexA, Point vertexB, Point vertexC, Point vertexD)
        {
        }


        public void Validate()
        {
            if (Sides.Count != 4)
            {
                throw new ArgumentException("Number of sides are not 4");
            }

            if (Angles.Count != 4)
            {
                throw new ArgumentException("Number of angles are not 4");
            }

            if (Sides.Where(i => i.Value < 1).Count() > 0)
            {
                throw new ArgumentOutOfRangeException("One or more sides have zero length");
            }

            if (Angles.Sum(i => i.Value) != 360)
            {
                throw new ArgumentException("The sum of all angles is not 360");
            }

        }

    }
}
