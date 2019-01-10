using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ChkLst.Core
{
    public partial class XCheckList
    {
        protected static XmlSerializer Serializer = new XmlSerializer(typeof(XCheckList));

        public void Serialize(Stream stream)
        {
            Guard.ArgumentNotNull(stream, nameof(stream));
            Serializer.Serialize(stream, this);
        }

        public override string ToString()
        {
            string result;

            using (var ms = new MemoryStream())
            {
                Serialize(ms);
                result = Encoding.UTF8.GetString(ms.ToArray());
            }

            return result;
        }
    }
}
