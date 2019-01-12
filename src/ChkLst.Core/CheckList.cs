using System;

namespace ChkLst.Core
{
    public partial class CheckList
    {
        public CheckListHeader Header { get; private set; } = new CheckListHeader()
        {
            CreatedBy = Environment.UserName,
            CreationDate = DateTime.Now,
        };

        public CheckItem Root { get; private set; } = new CheckItem();

    }
}
