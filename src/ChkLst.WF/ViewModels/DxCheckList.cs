using ChkLst.Core;
using DevExpress.XtraTreeList;
using static DevExpress.XtraTreeList.TreeList;

namespace ChkLst.WF.ViewModels
{
    public class DxCheckList : IVirtualTreeListData
    {
        public DxCheckList(CheckList source)
        {
            Source = Guard.ArgumentNotNull(source, nameof(source));
        }

        public CheckList Source { get; }

        void IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info)
        {
            Guard.ArgumentNotNull(info, nameof(info));

            var checkItem = (CheckItem)info.Node;
            var prop = typeof(CheckItem).GetProperty(info.Column.FieldName);
            if (prop != null)
            {
                info.CellData = prop.GetValue(checkItem);
            }
        }

        void IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info)
        {
            Guard.ArgumentNotNull(info, nameof(info));

            var node = info.Node;
            if (Equals(node))
            {
                info.Children = Source.Root;
            }
            else
            {
                var checkItem = (CheckItem)node;
                info.Children = checkItem;
            }
        }

        void IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info)
        {
            Guard.ArgumentNotNull(info, nameof(info));

            var checkItem = (CheckItem)info.Node;
            var prop = typeof(CheckItem).GetProperty(info.Column.FieldName);
            if (prop != null)
            {
                prop.SetValue(checkItem, info.NewCellData);
            }
        }
    }
}
