using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ChkLst.Core
{
    public partial class XItem
    {
        [XmlIgnore]
        public TimeSpan TimeCostDuration
        {
            get
            {
                if (string.IsNullOrEmpty(TimeCost))
                    return default(TimeSpan);

                return XmlConvert.ToTimeSpan(TimeCost);
            }
            set
            {
                TimeCost = XmlConvert.ToString(value);
            }
        }
    }
}
