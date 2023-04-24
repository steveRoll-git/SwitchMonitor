
namespace SwitchMonitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("רכיבים תקולים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("רכיבים תקינים", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.devicesListView = new System.Windows.Forms.ListView();
            this.devicesImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.רכיביםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.deviceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.olvEvents = new BrightIdeasSoftware.ObjectListView();
            this.DateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DeviceNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StatusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AcknowledgeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip1.SuspendLayout();
            this.deviceContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesListView
            // 
            this.devicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "רכיבים תקולים";
            listViewGroup1.Name = "DevicesDown";
            listViewGroup2.Header = "רכיבים תקינים";
            listViewGroup2.Name = "DevicesUp";
            this.devicesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.devicesListView.HideSelection = false;
            this.devicesListView.LargeImageList = this.devicesImageList;
            this.devicesListView.Location = new System.Drawing.Point(0, 0);
            this.devicesListView.Name = "devicesListView";
            this.devicesListView.RightToLeftLayout = true;
            this.devicesListView.Size = new System.Drawing.Size(500, 514);
            this.devicesListView.TabIndex = 0;
            this.devicesListView.UseCompatibleStateImageBehavior = false;
            this.devicesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.devicesListView_MouseClick);
            // 
            // devicesImageList
            // 
            this.devicesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("devicesImageList.ImageStream")));
            this.devicesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.devicesImageList.Images.SetKeyName(0, "deviceUp");
            this.devicesImageList.Images.SetKeyName(1, "deviceDown");
            this.devicesImageList.Images.SetKeyName(2, "deviceUnknown");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.רכיביםToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // רכיביםToolStripMenuItem
            // 
            this.רכיביםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceMenuItem});
            this.רכיביםToolStripMenuItem.Name = "רכיביםToolStripMenuItem";
            this.רכיביםToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.רכיביםToolStripMenuItem.Text = "רכיבים";
            // 
            // addDeviceMenuItem
            // 
            this.addDeviceMenuItem.Name = "addDeviceMenuItem";
            this.addDeviceMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addDeviceMenuItem.Text = "הוסף רכיב...";
            this.addDeviceMenuItem.Click += new System.EventHandler(this.addDeviceMenuItem_Click);
            // 
            // statusChangeTimer
            // 
            this.statusChangeTimer.Enabled = true;
            this.statusChangeTimer.Interval = 1000;
            this.statusChangeTimer.Tick += new System.EventHandler(this.statusChangeTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "סטטוס מתגים";
            this.notifyIcon.Visible = true;
            // 
            // deviceContextMenu
            // 
            this.deviceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripItem,
            this.editToolStripItem,
            this.deleteToolStripItem});
            this.deviceContextMenu.Name = "deviceContextMenu";
            this.deviceContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deviceContextMenu.Size = new System.Drawing.Size(122, 70);
            // 
            // showInfoToolStripItem
            // 
            this.showInfoToolStripItem.Name = "showInfoToolStripItem";
            this.showInfoToolStripItem.Size = new System.Drawing.Size(121, 22);
            this.showInfoToolStripItem.Text = "הצג מידע";
            // 
            // editToolStripItem
            // 
            this.editToolStripItem.Name = "editToolStripItem";
            this.editToolStripItem.Size = new System.Drawing.Size(121, 22);
            this.editToolStripItem.Text = "ערוך";
            // 
            // deleteToolStripItem
            // 
            this.deleteToolStripItem.Name = "deleteToolStripItem";
            this.deleteToolStripItem.Size = new System.Drawing.Size(121, 22);
            this.deleteToolStripItem.Text = "מחק";
            this.deleteToolStripItem.Click += new System.EventHandler(this.deleteToolStripItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.devicesListView);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel1MinSize = 70;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.olvEvents);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel2MinSize = 70;
            this.splitContainer.Size = new System.Drawing.Size(854, 514);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.TabIndex = 2;
            // 
            // olvEvents
            // 
            this.olvEvents.AllColumns.Add(this.DateColumn);
            this.olvEvents.AllColumns.Add(this.DeviceNameColumn);
            this.olvEvents.AllColumns.Add(this.StatusColumn);
            this.olvEvents.AllColumns.Add(this.AcknowledgeColumn);
            this.olvEvents.CellEditUseWholeCell = false;
            this.olvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateColumn,
            this.DeviceNameColumn,
            this.StatusColumn,
            this.AcknowledgeColumn});
            this.olvEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvEvents.FullRowSelect = true;
            this.olvEvents.HideSelection = false;
            this.olvEvents.Location = new System.Drawing.Point(0, 0);
            this.olvEvents.Name = "olvEvents";
            this.olvEvents.RightToLeftLayout = true;
            this.olvEvents.Size = new System.Drawing.Size(350, 514);
            this.olvEvents.TabIndex = 0;
            this.olvEvents.UseCellFormatEvents = true;
            this.olvEvents.UseCompatibleStateImageBehavior = false;
            this.olvEvents.View = System.Windows.Forms.View.Details;
            this.olvEvents.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvEvents_ButtonClick);
            this.olvEvents.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvEvents_FormatRow);
            this.olvEvents.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.olvEvents_ItemsChanged);
            // 
            // DateColumn
            // 
            this.DateColumn.AspectName = "Time";
            this.DateColumn.Groupable = false;
            this.DateColumn.Text = "תאריך";
            this.DateColumn.Width = 124;
            // 
            // DeviceNameColumn
            // 
            this.DeviceNameColumn.AspectName = "DeviceName";
            this.DeviceNameColumn.Groupable = false;
            this.DeviceNameColumn.Text = "שם רכיב";
            this.DeviceNameColumn.Width = 117;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AspectName = "Status";
            this.StatusColumn.AspectToStringFormat = "{0}";
            this.StatusColumn.Text = "מצב";
            this.StatusColumn.Width = 52;
            // 
            // AcknowledgeColumn
            // 
            this.AcknowledgeColumn.AspectName = "DeviceName";
            this.AcknowledgeColumn.AspectToStringFormat = "✔";
            this.AcknowledgeColumn.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.AcknowledgeColumn.FillsFreeSpace = true;
            this.AcknowledgeColumn.Groupable = false;
            this.AcknowledgeColumn.IsButton = true;
            this.AcknowledgeColumn.Sortable = false;
            this.AcknowledgeColumn.Text = "אוקיי";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 538);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Switch Monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.deviceContextMenu.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView devicesListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem רכיביםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceMenuItem;
        private System.Windows.Forms.ImageList devicesImageList;
        private System.Windows.Forms.Timer statusChangeTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip deviceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private BrightIdeasSoftware.ObjectListView olvEvents;
        private BrightIdeasSoftware.OLVColumn DateColumn;
        private BrightIdeasSoftware.OLVColumn DeviceNameColumn;
        private BrightIdeasSoftware.OLVColumn StatusColumn;
        private BrightIdeasSoftware.OLVColumn AcknowledgeColumn;
    }
}

