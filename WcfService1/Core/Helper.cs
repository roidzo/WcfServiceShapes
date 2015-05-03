using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WcfService1.Core
{
    public static class Helper
    {
        public static string GetEnumDescription<T>(T enumOption)
        {
            string description = "";
            try
            {
                var type = typeof(T);
                var memInfo = type.GetMember(enumOption.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                description = ((DescriptionAttribute)attributes[0]).Description;
            }
            catch (Exception ex)
            {

            }

            return description;
        }

    }
}
