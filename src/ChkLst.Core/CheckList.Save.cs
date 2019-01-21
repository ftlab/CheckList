using System.IO;
using System.IO.Compression;

namespace ChkLst.Core
{
    public partial class CheckList
    {
        public void Save(FileInfo file)
        {
            Guard.ArgumentNotNull(file, nameof(file));

            if (file.Exists && file.IsReadOnly)
                file.IsReadOnly = false;

            if (file.Extension == ".clx")
            {
                using (var fs = new FileStream(file.FullName, FileMode.Create, FileAccess.Write))
                {
                    Save(fs);
                }
            }
        }

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
