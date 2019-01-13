using ChkLst.Core;
using DevExpress.Mvvm;

namespace ChkLst.WF.ViewModels
{
    public class CheckListViewModel : ViewModelBase
    {
        private CheckList _checkList;

        private DxCheckList _dxCheckList;

        public CheckListViewModel(CheckList checkList)
        {
            CheckList = Guard.ArgumentNotNull(checkList, nameof(checkList));
        }

        public CheckListViewModel() : this(Gen.CreateDefault())
        {
        }

        public CheckList CheckList
        {
            get { return _checkList; }
            set
            {
                SetProperty(ref _checkList, value, () => CheckList);

                _dxCheckList = null;
                RaisePropertyChanged(() => DxCheckList);
            }
        }

        public DxCheckList DxCheckList
        {
            get
            {
                if (_dxCheckList == null && _checkList != null)
                {
                    _dxCheckList = new DxCheckList(_checkList);
                }

                return _dxCheckList;
            }
        }
    }
}