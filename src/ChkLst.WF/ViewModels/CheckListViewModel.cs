using ChkLst.Core;
using DevExpress.Mvvm;
using System.Linq;

namespace ChkLst.WF.ViewModels
{
    public class CheckListViewModel : ViewModelBase
    {
        private CheckList _checkList;

        private DxCheckList _dxCheckList;

        private CheckItem _focusedItem;

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

                if (CheckList != null && CheckList.Root != null)
                    FocusedItem = CheckList.Root.FirstOrDefault();
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

        public CheckItem FocusedItem
        {
            get { return _focusedItem; }
            set { SetProperty(ref _focusedItem, value, () => FocusedItem); }
        }

        public void AddAbove()
        {
            var node = FocusedItem ?? CheckList.Root;
            var newItem = new CheckItem() { Name = "<New Task>" };
            node.AddAbove(newItem);

            RaisePropertyChanged(() => DxCheckList);
            FocusedItem = newItem;
        }

        public void AddBelow()
        {
            var node = FocusedItem ?? CheckList.Root;
            var newItem = new CheckItem() { Name = "<New Task>" };
            node.AddBelow(newItem);

            RaisePropertyChanged(() => DxCheckList);
            FocusedItem = newItem;
        }

        public void Outdent()
        {
            var item = FocusedItem;
            if (item != null)
            {
                if (item.Outdent())
                {
                    RaisePropertyChanged(() => DxCheckList);
                    FocusedItem = item;
                }
            }
        }

        public void Indent()
        {
            var item = FocusedItem;
            if (item != null)
            {
                if (item.Indent())
                {
                    RaisePropertyChanged(() => DxCheckList);
                    FocusedItem = item;
                }
            }
        }

        public void PlaceAbove()
        {
            var item = FocusedItem;
            if (item != null)
            {
                if (item.PlaceAbove())
                {
                    RaisePropertyChanged(() => DxCheckList);
                    FocusedItem = item;
                }
            }
        }

        public void PlaceBelow()
        {
            var item = FocusedItem;
            if (item != null)
            {
                if (item.PlaceBelow())
                {
                    RaisePropertyChanged(() => DxCheckList);
                    FocusedItem = item;
                }
            }
        }
    }
}