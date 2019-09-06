using System;
using System.Collections.Generic;
using System.Text;

namespace ChuangLan
{
    public class Check
    {
        public static void CheckNull(object obj, string error)
        {
            if (obj == null)
                throw new ArgumentNullException(error);
        }

        public static void CheckNullOrWhiteSpace(string str, string error)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException(error);
        }
    }
}
