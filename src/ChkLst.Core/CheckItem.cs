using System;
using System.Linq;

namespace ChkLst.Core
{
    public partial class CheckItem : Node<CheckItem>
    {
        private double _timeCostsInHours;

        private bool _done;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaiseOnPropertyChanged(nameof(Name));
            }
        }

        public bool? Done
        {
            get
            {
                bool? result = null;

                if (Count > 0)
                {
                    if (Nodes.TrueForAll(child => child.Done == true))
                        result = true;
                }
                else
                    result = _done;

                return result;
            }
            set
            {
                if (value.HasValue && value.Value != _done)
                {
                    _done = value.Value;
                    RaiseOnPropertyChanged(nameof(Done));

                    var parent = Parent;
                    while (parent != null)
                    {
                        parent.RaiseOnPropertyChanged(nameof(Done));
                        parent = parent.Parent;
                    }
                }
            }
        }

        public TimeSpan TimeCosts
        {
            get { return TimeSpan.FromHours(_timeCostsInHours); }
            set { TimeCostsInHours = value.TotalHours; }
        }

        public double TimeCostsInHours
        {
            get
            {
                double result = _timeCostsInHours;

                if (Count > 0)
                {
                    result = Nodes.Sum(child => child.TimeCostsInHours);
                }

                return result;
            }
            set
            {
                _timeCostsInHours = value;

                RaiseOnPropertyChanged(nameof(TimeCostsInHours));
                RaiseOnPropertyChanged(nameof(TimeCosts));

                var parent = Parent;
                while (parent != null)
                {
                    parent.RaiseOnPropertyChanged(nameof(TimeCostsInHours));
                    parent.RaiseOnPropertyChanged(nameof(TimeCosts));
                    parent = parent.Parent;
                }
            }
        }
    }
}
