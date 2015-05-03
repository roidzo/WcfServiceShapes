using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace WcfService1.Core.Enums
{
    public enum QuadrilateralTypeEnum
    {
        [Description("Unknown")]
        Unknown = 0,

        [Description("Parallelogram")]
        Parallelogram = 1,

        [Description("Rectangle")]
        Rectangle = 2,

        [Description("Rhombus")]
        Rhombus = 3,

        [Description("Square")]
        Square = 4,

        [Description("Kite")]
        Kite = 5,

        [Description("Trapezoid")]
        Trapezoid = 6,

        [Description("IsoscelesTrapezoid")]
        IsoscelesTrapezoid = 7,

        [Description("Quadrilateral")]
        Quadrilateral = 8,
    }
}
