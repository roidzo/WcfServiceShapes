using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Core.Enums;

namespace WcfService1.BusinessLogic
{
    public interface IQuadrilateralTypeProvider
    {
        QuadrilateralTypeEnum GetQuadrilateralType();
    }
}
