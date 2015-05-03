using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core.Enums;
using Serilog;
using System.Collections;

namespace WcfService1.BusinessLogic
{
    public class QuadrilateralTypeProvider : IQuadrilateralTypeProvider
    {
        private readonly ILogger _logger;
        private readonly IQuadrilateral _quadrilateral;


        public QuadrilateralTypeProvider(IQuadrilateral quadrilateral)
        {
            _quadrilateral = quadrilateral;
        }


        public QuadrilateralTypeEnum GetQuadrilateralType()
        {
            int numberOfPairsOfCongruentAngles = NumberOfPairsOfCongruentAngles();
            int numberOfPairsOfCongruentSides = NumberOfPairsOfCongruentSides();
            int numberOfPairsOfCongruentOppositeSides = NumberOfPairsOfCongruentOppositeSides();
            bool allSidesCongruent = AllSidesCongruent();
            bool allAnglesCongruent = AllAnglesCongruent();
            int numberOfParallelSides = NumberOfParallelSides();

            if (numberOfPairsOfCongruentSides == 0)
            {
                if (numberOfPairsOfCongruentAngles == 0)
                {
                    return QuadrilateralTypeEnum.Quadrilateral;
                }
                //else if (numberOfPairsOfCongruentAngles == 1)
                //{
                //    return QuadrilateralTypeEnum.Trapezoid;
                //}
                else
                {
                    return QuadrilateralTypeEnum.Unknown;
                }
            }
            else if (allSidesCongruent)
            {
                if (allAnglesCongruent)
                {
                    return QuadrilateralTypeEnum.Square;
                } 
                else if (numberOfPairsOfCongruentAngles == 2)
                {
                    return QuadrilateralTypeEnum.Rhombus;
                }
                else
                {
                    return QuadrilateralTypeEnum.Unknown;
                }
            }
            else if (numberOfPairsOfCongruentSides > 1)
            {
                if (allAnglesCongruent)
                {
                    return QuadrilateralTypeEnum.Rectangle;
                }
                else if (numberOfPairsOfCongruentAngles == 1)
                {
                    return QuadrilateralTypeEnum.Kite;
                }
                else if (numberOfPairsOfCongruentAngles == 2)
                {
                    //if (numberOfParallelSides == 4 && numberOfPairsOfCongruentSides == 2)
                    //{
                        return QuadrilateralTypeEnum.Parallelogram;
                    //}
                    //else
                    //{
                    //    return QuadrilateralTypeEnum.IsoscelesTrapezoid;
                    //}
                }
                
                else
                {
                    return QuadrilateralTypeEnum.Unknown;
                }
            }
            
            else
            {
                
                if (numberOfParallelSides == 2)
                {
                    if (numberOfPairsOfCongruentOppositeSides == 1)
                    {
                        return QuadrilateralTypeEnum.IsoscelesTrapezoid;
                    }
                    else
                    {
                        return QuadrilateralTypeEnum.Trapezoid;
                    }
                }
                else
                {
                    return QuadrilateralTypeEnum.Quadrilateral;
                }
            }

        }

        #region Helpers

        //private bool ValidQuadrilateral()
        //{
        //    //if (_quadrilateral)

        //    return false;
        //}

        //bool CheckOppositeSidesParallel(); //Parallelogram, Rectangle, Square, Rhombus
        //bool CheckOnlyOnePairOfSidesParallel(); //Trapezoid
        //bool CheckEqualLengthNonParallelSides(); //Isosceles Trapezoid
        //bool CheckAllSidesEqualLength(); //Square, Rhombus
        //bool CheckAllRightAngles(); //Sqare or rectangle

        //bool CheckNoPairsOfParallelSides();
        //bool CheckBothPairsOfAdjacentSidesAreCongruent(); //Kite, (includes shape like an arrow)

        private int NumberOfParallelSides()
        {
            if (_quadrilateral.Sides.Count != 4) throw new ArgumentOutOfRangeException("Number of sides do not equal 4");

            int parallelSidesCount = 0;
            int[] a = _quadrilateral.Angles.Select(i=>i.Value).ToArray<int>();

            for (int i=0;i<=3;i++)
            {
                if (i == 3)
                {
                    if (a[i] + a[0] == 180)
                    {
                        parallelSidesCount++;
                    }
                }
                else
                {
                    if (a[i] + a[i + 1] == 180)
                    {
                        parallelSidesCount++;
                    }
                }
            }

            
            return parallelSidesCount;
        }


        private int NumberOfPairsOfCongruentAngles()
        {
            int pairsOfCongruentAnglesCount = 0;

            var results = from a in _quadrilateral.Angles
                          group a by a.Value into g
                          where g.Count() > 1
                          select g;

            foreach (var group in results)
                foreach (var item in group)
                    pairsOfCongruentAnglesCount += 1;

            double n = pairsOfCongruentAnglesCount / 2;

            return (int)(Math.Floor(n));
        }


        private int NumberOfPairsOfCongruentSides()
        {
            int pairsOfCongruentSidesCount = 0;

            var results = from s in _quadrilateral.Sides
                          group s by s.Value into g
                          where g.Count() > 1
                          select g;

            foreach (var group in results)
                foreach (var item in group)
                    pairsOfCongruentSidesCount += 1;

            double n = pairsOfCongruentSidesCount / 2;

            return (int)(Math.Floor(n));

            //return pairsOfCongruentSidesCount;
        }


        private int NumberOfPairsOfCongruentOppositeSides()
        {
            if (_quadrilateral.Sides.Count != 4) throw new ArgumentOutOfRangeException("Number of sides do not equal 4");

            int pairsOfCongruentSidesCount = 0;
            int[] a = _quadrilateral.Sides.Select(i => i.Value).ToArray<int>();

            if (a[0] == a[2])
                pairsOfCongruentSidesCount++;

            if (a[1] == a[3])
                pairsOfCongruentSidesCount++;

            return pairsOfCongruentSidesCount;
        }


        private bool AllAnglesCongruent()
        {
            var results = from a in _quadrilateral.Angles
                          group a by a.Value into g
                          where g.Count() == 4
                          select g;

            return results.Count() == 1;
        }

        private bool AllSidesCongruent()
        {
            var results = from a in _quadrilateral.Sides
                          group a by a.Value into g
                          where g.Count() == 4
                          select g;

            return results.Count() == 1;
        }


        #endregion

    }
}
