namespace ChkLst.WF.Views
{
    partial class CheckListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._mvvmCtx = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this._barManager = new DevExpress.XtraBars.BarManager(this.components);
            this._menuBar = new DevExpress.XtraBars.Bar();
            this._fileCat = new DevExpress.XtraBars.BarLinkContainerItem();
            this._openBtn = new DevExpress.XtraBars.BarButtonItem();
            this._saveAsBtn = new DevExpress.XtraBars.BarButtonItem();
            this._toolBar = new DevExpress.XtraBars.Bar();
            this._addBelowBtn = new DevExpress.XtraBars.BarButtonItem();
            this._addAboveBtn = new DevExpress.XtraBars.BarButtonItem();
            this._outdentBtn = new DevExpress.XtraBars.BarButtonItem();
            this._indentBtn = new DevExpress.XtraBars.BarButtonItem();
            this._placeAboveBtn = new DevExpress.XtraBars.BarButtonItem();
            this._placeBelowBtn = new DevExpress.XtraBars.BarButtonItem();
            this._deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this._statusBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this._layout = new DevExpress.XtraLayout.LayoutControl();
            this._checkListTree = new DevExpress.XtraTreeList.TreeList();
            this._nameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._layoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this._checkListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._mvvmCtx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._layout)).BeginInit();
            this._layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._checkListTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._layoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkListLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // _mvvmCtx
            // 
            this._mvvmCtx.ContainerControl = this;
            this._mvvmCtx.ViewModelType = typeof(ChkLst.WF.ViewModels.CheckListViewModel);
            // 
            // _barManager
            // 
            this._barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this._menuBar,
            this._toolBar,
            this._statusBar});
            this._barManager.DockControls.Add(this.barDockControlTop);
            this._barManager.DockControls.Add(this.barDockControlBottom);
            this._barManager.DockControls.Add(this.barDockControlLeft);
            this._barManager.DockControls.Add(this.barDockControlRight);
            this._barManager.Form = this;
            this._barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this._addBelowBtn,
            this._addAboveBtn,
            this._outdentBtn,
            this._indentBtn,
            this._placeAboveBtn,
            this._placeBelowBtn,
            this._deleteBtn,
            this._fileCat,
            this._openBtn,
            this._saveAsBtn});
            this._barManager.MainMenu = this._menuBar;
            this._barManager.MaxItemId = 10;
            this._barManager.StatusBar = this._statusBar;
            // 
            // _menuBar
            // 
            this._menuBar.BarName = "MainMenu";
            this._menuBar.DockCol = 0;
            this._menuBar.DockRow = 0;
            this._menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this._menuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._fileCat)});
            this._menuBar.OptionsBar.MultiLine = true;
            this._menuBar.OptionsBar.UseWholeRow = true;
            this._menuBar.Text = "MainMenu";
            // 
            // _fileCat
            // 
            this._fileCat.Caption = "File";
            this._fileCat.Id = 7;
            this._fileCat.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._openBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._saveAsBtn)});
            this._fileCat.Name = "_fileCat";
            // 
            // _openBtn
            // 
            this._openBtn.Caption = "Open";
            this._openBtn.Id = 8;
            this._openBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.file;
            this._openBtn.Name = "_openBtn";
            // 
            // _saveAsBtn
            // 
            this._saveAsBtn.Caption = "Save as...";
            this._saveAsBtn.Id = 9;
            this._saveAsBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.save;
            this._saveAsBtn.Name = "_saveAsBtn";
            // 
            // _toolBar
            // 
            this._toolBar.BarName = "Tools";
            this._toolBar.DockCol = 0;
            this._toolBar.DockRow = 1;
            this._toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this._toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._addBelowBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._addAboveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._outdentBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._indentBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._placeAboveBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._placeBelowBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this._deleteBtn)});
            this._toolBar.Text = "Tools";
            // 
            // _addBelowBtn
            // 
            this._addBelowBtn.Caption = "Add below";
            this._addBelowBtn.Id = 0;
            this._addBelowBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.add_below;
            this._addBelowBtn.Name = "_addBelowBtn";
            // 
            // _addAboveBtn
            // 
            this._addAboveBtn.Caption = "Add above";
            this._addAboveBtn.Id = 1;
            this._addAboveBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.add_above;
            this._addAboveBtn.Name = "_addAboveBtn";
            // 
            // _outdentBtn
            // 
            this._outdentBtn.Caption = "Outdent";
            this._outdentBtn.Id = 2;
            this._outdentBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.left_indent;
            this._outdentBtn.Name = "_outdentBtn";
            // 
            // _indentBtn
            // 
            this._indentBtn.Caption = "Indent";
            this._indentBtn.Id = 3;
            this._indentBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.right_indent;
            this._indentBtn.Name = "_indentBtn";
            // 
            // _placeAboveBtn
            // 
            this._placeAboveBtn.Caption = "Place above";
            this._placeAboveBtn.Id = 4;
            this._placeAboveBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.place_above;
            this._placeAboveBtn.Name = "_placeAboveBtn";
            // 
            // _placeBelowBtn
            // 
            this._placeBelowBtn.Caption = "Place below";
            this._placeBelowBtn.Id = 5;
            this._placeBelowBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.place_below;
            this._placeBelowBtn.Name = "_placeBelowBtn";
            // 
            // _deleteBtn
            // 
            this._deleteBtn.Caption = "Delete";
            this._deleteBtn.Id = 6;
            this._deleteBtn.ImageOptions.SvgImage = global::ChkLst.WF.Properties.Resources.delete;
            this._deleteBtn.Name = "_deleteBtn";
            // 
            // _statusBar
            // 
            this._statusBar.BarName = "StatusBar";
            this._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this._statusBar.DockCol = 0;
            this._statusBar.DockRow = 0;
            this._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this._statusBar.OptionsBar.AllowQuickCustomization = false;
            this._statusBar.OptionsBar.DrawDragBorder = false;
            this._statusBar.OptionsBar.UseWholeRow = true;
            this._statusBar.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this._barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(676, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 372);
            this.barDockControlBottom.Manager = this._barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(676, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this._barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 319);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(676, 53);
            this.barDockControlRight.Manager = this._barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 319);
            // 
            // _layout
            // 
            this._layout.Controls.Add(this._checkListTree);
            this._layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layout.Location = new System.Drawing.Point(0, 53);
            this._layout.Name = "_layout";
            this._layout.Root = this._layoutGroup;
            this._layout.Size = new System.Drawing.Size(676, 319);
            this._layout.TabIndex = 4;
            this._layout.Text = "layoutControl1";
            // 
            // _checkListTree
            // 
            this._checkListTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this._nameColumn});
            this._checkListTree.DataSource = null;
            this._checkListTree.Location = new System.Drawing.Point(12, 12);
            this._checkListTree.Name = "_checkListTree";
            this._checkListTree.OptionsView.ShowCheckBoxes = true;
            this._checkListTree.Size = new System.Drawing.Size(652, 295);
            this._checkListTree.TabIndex = 4;
            // 
            // _nameColumn
            // 
            this._nameColumn.Caption = "Name";
            this._nameColumn.FieldName = "Name";
            this._nameColumn.Name = "_nameColumn";
            this._nameColumn.Visible = true;
            this._nameColumn.VisibleIndex = 0;
            // 
            // _layoutGroup
            // 
            this._layoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this._layoutGroup.GroupBordersVisible = false;
            this._layoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this._checkListLayout});
            this._layoutGroup.Name = "_layoutGroup";
            this._layoutGroup.Size = new System.Drawing.Size(676, 319);
            this._layoutGroup.TextVisible = false;
            // 
            // _checkListLayout
            // 
            this._checkListLayout.Control = this._checkListTree;
            this._checkListLayout.Location = new System.Drawing.Point(0, 0);
            this._checkListLayout.Name = "_checkListLayout";
            this._checkListLayout.Size = new System.Drawing.Size(656, 299);
            this._checkListLayout.TextSize = new System.Drawing.Size(0, 0);
            this._checkListLayout.TextVisible = false;
            // 
            // CheckListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CheckListView";
            this.Size = new System.Drawing.Size(676, 395);
            ((System.ComponentModel.ISupportInitialize)(this._mvvmCtx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._layout)).EndInit();
            this._layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._checkListTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._layoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkListLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext _mvvmCtx;
        private DevExpress.XtraLayout.LayoutControl _layout;
        private DevExpress.XtraLayout.LayoutControlGroup _layoutGroup;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager _barManager;
        private DevExpress.XtraBars.Bar _menuBar;
        private DevExpress.XtraBars.Bar _toolBar;
        private DevExpress.XtraBars.Bar _statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTreeList.TreeList _checkListTree;
        private DevExpress.XtraLayout.LayoutControlItem _checkListLayout;
        private DevExpress.XtraTreeList.Columns.TreeListColumn _nameColumn;
        private DevExpress.XtraBars.BarButtonItem _addBelowBtn;
        private DevExpress.XtraBars.BarButtonItem _addAboveBtn;
        private DevExpress.XtraBars.BarButtonItem _outdentBtn;
        private DevExpress.XtraBars.BarButtonItem _indentBtn;
        private DevExpress.XtraBars.BarButtonItem _placeAboveBtn;
        private DevExpress.XtraBars.BarButtonItem _placeBelowBtn;
        private DevExpress.XtraBars.BarButtonItem _deleteBtn;
        private DevExpress.XtraBars.BarLinkContainerItem _fileCat;
        private DevExpress.XtraBars.BarButtonItem _openBtn;
        private DevExpress.XtraBars.BarButtonItem _saveAsBtn;
    }
}
