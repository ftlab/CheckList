using ChkLst.WF.ViewModels;
using System;

namespace ChkLst.WF.Views
{
    public partial class CheckListView : DevExpress.XtraEditors.XtraUserControl
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
        }
    }
}
