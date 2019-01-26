using ChkLst.Core;
using ChkLst.WF.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Windows.Forms;

namespace ChkLst.WF.Views
{
    public partial class CheckListView : XtraUserControl
    {
        public CheckListView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_mvvmCtx.IsDesignMode == false)
            {
                InitBindings();
            }
        }

        private void InitBindings()
        {
            var fluentAPI = _mvvmCtx.OfType<CheckListViewModel>();

            fluentAPI.SetBinding(_checkListTree, t => t.DataSource, p => p.DxCheckList);
            fluentAPI.SetTrigger(p => p.DxCheckList, d => _checkListTree.RefreshDataSource());
            fluentAPI.WithEvent<TreeList, FocusedNodeChangedEventArgs>(
                _checkListTree, nameof(_checkListTree.FocusedNodeChanged))
                .SetBinding(vm => vm.FocusedItem
                    , arg => arg.Node?.TreeList.GetDataRecordByNode(arg.Node) as CheckItem
                    , (v, m) => { v.FocusedNode = v.FindNode(n => n.TreeList.GetDataRecordByNode(n) == m); });

            fluentAPI.BindCommand(_addAboveBtn, p => p.AddAbove());
            fluentAPI.BindCommand(_addBelowBtn, p => p.AddBelow());
            fluentAPI.BindCommand(_outdentBtn, p => p.Outdent());
            fluentAPI.BindCommand(_indentBtn, p => p.Indent());
            fluentAPI.BindCommand(_placeAboveBtn, p => p.PlaceAbove());
            fluentAPI.BindCommand(_placeBelowBtn, p => p.PlaceBelow());
            fluentAPI.BindCommand(_deleteBtn, p => p.Delete());
            fluentAPI.BindCommand(_openBtn, p => p.Open());
            fluentAPI.BindCommand(_saveAsBtn, p => p.SaveAs());

            _checkListTree.NodesReloaded += _checkListTree_NodesReloaded;
        }

        private void _checkListTree_NodesReloaded(object sender, EventArgs e)
        {
            _checkListTree.NodesIterator.Do(node =>
            {
                var checkItem = node.TreeList.GetDataRecordByNode(node) as CheckItem;
                if (checkItem != null)
                {
                    if (checkItem.Done == null)
                    {
                        node.CheckState = CheckState.Indeterminate;
                    }
                    else if (checkItem.Done.Value)
                    {
                        node.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        node.CheckState = CheckState.Unchecked;
                    }
                }
            });
        }

        private void _hoursEditFactory_Enter(object sender, EventArgs e)
        {
            var edit = (SpinEdit)sender;
            edit.SelectAll();
        }
    }
}
