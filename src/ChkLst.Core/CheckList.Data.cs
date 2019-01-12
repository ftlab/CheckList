namespace ChkLst.Core
{
    public partial class CheckList
    {
        public XCheckList GetData()
        {
            var result = new XCheckList();

            result.Header = Header.GetData();
            result.Root = Root.GetData();

            return result;
        }

        public override string ToString()
        {
            return GetData().ToString();
        }
    }
}
