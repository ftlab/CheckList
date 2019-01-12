namespace ChkLst.Core
{
    public partial class CheckListHeader
    {
        public static CheckListHeader FromData(XCheckListHeader data)
        {
            Guard.ArgumentNotNull(data, nameof(data));

            var r = new CheckListHeader();
            r.WorkItem = data.WorkItem;
            r.CreatedBy = data.CreatedBy;
            r.CreationDate = data.CreationDate;

            return r;
        }

        public XCheckListHeader GetData()
        {
            var result = new XCheckListHeader();
            result.WorkItem = WorkItem;
            result.CreatedBy = CreatedBy;
            result.CreationDate = CreationDate;

            return result;
        }

        public override string ToString()
        {
            return $"WI: {WorkItem}, CreationDate: {CreationDate}, CreatedBy: {CreatedBy}";
        }
    }
}
