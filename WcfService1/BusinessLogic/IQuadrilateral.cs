using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core.Enums;

namespace WcfService1.BusinessLogic
{
    public interface IQuadrilateral
    {
        Dictionary<QuadrilateralSideNamesEnum, int> Sides { get; }
        Dictionary<QuadrilateralAngleNamesEnum, int> Angles { get; }

        //int SideA { get;  }
        //int SideB { get;  }
        //int SideC { get;  }
        //int SideD { get; }
        //int AngleDAB { get; }
        //int AngleABC { get;  }
        //int AngleBCD { get;  }
        //int AngleCDA { get; }

        //bool IsValid();
    }
}
