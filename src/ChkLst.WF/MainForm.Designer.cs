namespace ChkLst.WF
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkListView1 = new ChkLst.WF.Views.CheckListView();
            this.SuspendLayout();
            // 
            // checkListView1
            // 
            this.checkListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListView1.Location = new System.Drawing.Point(0, 0);
            this.checkListView1.Name = "checkListView1";
            this.checkListView1.Size = new System.Drawing.Size(800, 450);
            this.checkListView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkListView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Check list";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.CheckListView checkListView1;
    }
}

