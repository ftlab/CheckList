using System;
using System.Collections.Generic;
using System.Xml;

namespace ChkLst.Core
{
    public partial class CheckItem : Node<CheckItem>
    {
        private double _timeCostsInHours;

        public bool Done { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeCosts
        {
            get
            {
                return TimeSpan.FromHours(_timeCostsInHours);
            }
            set
            {
                TimeCostsInHours = value.TotalHours;
            }
        }

        public double TimeCostsInHours
        {
            get
            {
                return _timeCostsInHours;
            }
            set
            {
                _timeCostsInHours = value;

                RaiseOnPropertyChanged(nameof(TimeCostsInHours));
                RaiseOnPropertyChanged(nameof(TimeCosts));
            }
        }
    }
}
