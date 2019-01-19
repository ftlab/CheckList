using System;
using System.Collections.Generic;
using System.Text;

namespace ChkLst.Core
{
    public static class Global
    {
        public static bool NotEquals(this object left, object right)
        {
            if (left == null) return true;
            return !left.Equals(right);
        }
    }
}
