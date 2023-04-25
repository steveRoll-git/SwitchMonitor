
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("רכיבים עם אירועים חדשים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("רכיבים תקולים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("רכיבים תקינים", System.Windows.Forms.HorizontalAlignment.Left);
            this.devicesListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.רכיביםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllEventsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.deviceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.devicesGroupBox = new System.Windows.Forms.GroupBox();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            this.acknowledgeAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.deviceContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.devicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesListView
            // 
            this.devicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup4.Header = "רכיבים עם אירועים חדשים";
            listViewGroup4.Name = "UnacknowledgedEvents";
            listViewGroup5.Header = "רכיבים תקולים";
            listViewGroup5.Name = "DevicesDown";
            listViewGroup6.Header = "רכיבים תקינים";
            listViewGroup6.Name = "DevicesUp";
            this.devicesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.devicesListView.HideSelection = false;
            this.devicesListView.Location = new System.Drawing.Point(3, 19);
            this.devicesListView.Name = "devicesListView";
            this.devicesListView.RightToLeftLayout = true;
            this.devicesListView.Size = new System.Drawing.Size(522, 492);
            this.devicesListView.TabIndex = 0;
            this.devicesListView.UseCompatibleStateImageBehavior = false;
            this.devicesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.devicesListView_MouseClick);
            this.devicesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.devicesListView_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.רכיביםToolStripMenuItem,
            this.אירועיםToolStripMenuItem});
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
            // אירועיםToolStripMenuItem
            // 
            this.אירועיםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acknowledgeAllButton,
            this.toolStripSeparator1,
            this.showAllEventsItem});
            this.אירועיםToolStripMenuItem.Name = "אירועיםToolStripMenuItem";
            this.אירועיםToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.אירועיםToolStripMenuItem.Text = "אירועים";
            // 
            // showAllEventsItem
            // 
            this.showAllEventsItem.Name = "showAllEventsItem";
            this.showAllEventsItem.Size = new System.Drawing.Size(181, 22);
            this.showAllEventsItem.Text = "הצג את כל האירועים";
            this.showAllEventsItem.Click += new System.EventHandler(this.showAllEventsItem_Click);
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
            this.deleteToolStripItem});
            this.deviceContextMenu.Name = "deviceContextMenu";
            this.deviceContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deviceContextMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // showInfoToolStripItem
            // 
            this.showInfoToolStripItem.Name = "showInfoToolStripItem";
            this.showInfoToolStripItem.Size = new System.Drawing.Size(121, 22);
            this.showInfoToolStripItem.Text = "הצג מידע";
            this.showInfoToolStripItem.Click += new System.EventHandler(this.showInfoToolStripItem_Click);
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
            this.splitContainer.Panel1.Controls.Add(this.devicesGroupBox);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel1MinSize = 70;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.eventsGroupBox);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel2MinSize = 70;
            this.splitContainer.Size = new System.Drawing.Size(854, 514);
            this.splitContainer.SplitterDistance = 528;
            this.splitContainer.TabIndex = 2;
            // 
            // devicesGroupBox
            // 
            this.devicesGroupBox.Controls.Add(this.devicesListView);
            this.devicesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.devicesGroupBox.Name = "devicesGroupBox";
            this.devicesGroupBox.Size = new System.Drawing.Size(528, 514);
            this.devicesGroupBox.TabIndex = 1;
            this.devicesGroupBox.TabStop = false;
            this.devicesGroupBox.Text = "רשימת רכיבים";
            // 
            // eventsGroupBox
            // 
            this.eventsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(322, 514);
            this.eventsGroupBox.TabIndex = 0;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "אירועים אחרונים";
            // 
            // acknowledgeAllButton
            // 
            this.acknowledgeAllButton.Name = "acknowledgeAllButton";
            this.acknowledgeAllButton.Size = new System.Drawing.Size(181, 22);
            this.acknowledgeAllButton.Text = "סמן את כולם ב-✓";
            this.acknowledgeAllButton.Click += new System.EventHandler(this.acknowledgeAllButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
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
            this.devicesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView devicesListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem רכיביםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceMenuItem;
        private System.Windows.Forms.Timer statusChangeTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip deviceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox devicesGroupBox;
        private System.Windows.Forms.GroupBox eventsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem אירועיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllEventsItem;
        private System.Windows.Forms.ToolStripMenuItem acknowledgeAllButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

