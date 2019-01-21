using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ChkLst.Core
{
    public partial class CheckList
    {
        public void Open(FileInfo file)
        {
            Guard.ArgumentNotNull(file, nameof(file));

            using (var fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
            {
                Open(fs);
            }
        }

        public void Open(XCheckList data)
        {
            Guard.ArgumentNotNull(data, nameof(data));

            if (data.Header != null)
                Header = CheckListHeader.FromData(data.Header);
            else
                Header = new CheckListHeader();

            if (data.Root != null)
                Root = CheckItem.FromData(data.Root);
            else
                Root = new CheckItem();
        }

        public void Open(Stream stream)
        {
            Guard.ArgumentNotNull(stream, nameof(stream));

            var data = XCheckList.Deserialize(stream);
            Open(data);
        }

        public void OpenCompressed(Stream stream)
        {
            Guard.ArgumentNotNull(stream, nameof(stream));

            using (var gz = new GZipStream(stream, CompressionMode.Decompress, true))
            {
                Open(gz);
            }
        }
    }
}
