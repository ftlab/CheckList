namespace ChkLst.WF.VS
{
    using ChkLst.WF.Views;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for CheckListToolFormControl.
    /// </summary>
    public partial class CheckListToolFormControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckListToolFormControl"/> class.
        /// </summary>
        public CheckListToolFormControl()
        {
            this.InitializeComponent();

            host.Child = new CheckListView();
        }

    }
}