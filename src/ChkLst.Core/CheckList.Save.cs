using System.IO;
using System.IO.Compression;

namespace ChkLst.Core
{
    public partial class CheckList
    {
        public void Save(Stream stream)
        {
            var data = GetData();
            data.Serialize(stream);
        }

        public void SaveCompressed(Stream stream)
        {
            using (var gz = new GZipStream(stream, CompressionMode.Compress, true))
            {
                Save(gz);
            }
        }
    }
}
