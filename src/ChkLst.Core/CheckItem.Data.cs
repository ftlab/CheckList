using System.Xml;

namespace ChkLst.Core
{
    public partial class CheckItem
    {
        public static CheckItem FromData(XCheckItem data)
        {
            Guard.ArgumentNotNull(data, nameof(data));

            var r = new CheckItem();
            r.Name = data.Name;
            r.Done = data.Done;
            if (string.IsNullOrEmpty(data.TimeCost) == false)
                r.TimeCost = XmlConvert.ToTimeSpan(data.TimeCost);

            if (data.Item != null)
            {
                foreach (var item in data.Item)
                {
                    r.Add(FromData(item));
                }
            }

            return r;
        }

        public XCheckItem GetData()
        {
            var item = new XCheckItem();
            item.Done = Done;
            item.Name = Name;
            item.TimeCost = XmlConvert.ToString(TimeCost);

            for (int i = 0; i < Count; i++)
            {
                var child = this[i];
                item.Item.Add(child.GetData());
            }

            return item;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Done:{Done}";
        }
    }
}
