using System;
using System.Collections.Generic;
using System.Xml;

namespace ChkLst.Core
{
    public partial class CheckItem : Node<CheckItem>
    {
        public bool Done { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeCost { get; set; }
    }
}
