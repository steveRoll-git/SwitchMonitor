
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("רכיבים עם אירועים חדשים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("רכיבים תקולים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("רכיבים תקינים", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("חיפוש", System.Windows.Forms.HorizontalAlignment.Left);
            this.devicesListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.רכיביםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אירועיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acknowledgeAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllEventsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.deviceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.devicesGroupBox = new System.Windows.Forms.GroupBox();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new SwitchMonitor.CueTextBox();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.deviceContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.devicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesListView
            // 
            this.devicesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            listViewGroup5.Header = "רכיבים עם אירועים חדשים";
            listViewGroup5.Name = "UnacknowledgedEvents";
            listViewGroup6.Header = "רכיבים תקולים";
            listViewGroup6.Name = "DevicesDown";
            listViewGroup7.Header = "רכיבים תקינים";
            listViewGroup7.Name = "DevicesUp";
            listViewGroup8.Header = "חיפוש";
            listViewGroup8.Name = "SearchResults";
            this.devicesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.devicesListView.HideSelection = false;
            this.devicesListView.Location = new System.Drawing.Point(6, 48);
            this.devicesListView.Name = "devicesListView";
            this.devicesListView.RightToLeftLayout = true;
            this.devicesListView.Size = new System.Drawing.Size(486, 460);
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
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
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
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // deviceContextMenu
            // 
            this.deviceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripItem,
            this.pingToolStripItem,
            this.deleteToolStripItem});
            this.deviceContextMenu.Name = "deviceContextMenu";
            this.deviceContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deviceContextMenu.Size = new System.Drawing.Size(126, 70);
            // 
            // showInfoToolStripItem
            // 
            this.showInfoToolStripItem.Name = "showInfoToolStripItem";
            this.showInfoToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.showInfoToolStripItem.Text = "הצג מידע";
            this.showInfoToolStripItem.Click += new System.EventHandler(this.showInfoToolStripItem_Click);
            // 
            // pingToolStripItem
            // 
            this.pingToolStripItem.Name = "pingToolStripItem";
            this.pingToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.pingToolStripItem.Text = "שלח Ping";
            this.pingToolStripItem.Click += new System.EventHandler(this.pingToolStripItem_Click);
            // 
            // deleteToolStripItem
            // 
            this.deleteToolStripItem.Name = "deleteToolStripItem";
            this.deleteToolStripItem.Size = new System.Drawing.Size(125, 22);
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
            this.splitContainer.Size = new System.Drawing.Size(801, 514);
            this.splitContainer.SplitterDistance = 498;
            this.splitContainer.TabIndex = 2;
            // 
            // devicesGroupBox
            // 
            this.devicesGroupBox.Controls.Add(this.searchPictureBox);
            this.devicesGroupBox.Controls.Add(this.searchBox);
            this.devicesGroupBox.Controls.Add(this.devicesListView);
            this.devicesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.devicesGroupBox.Name = "devicesGroupBox";
            this.devicesGroupBox.Size = new System.Drawing.Size(498, 514);
            this.devicesGroupBox.TabIndex = 1;
            this.devicesGroupBox.TabStop = false;
            this.devicesGroupBox.Text = "רשימת רכיבים";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPictureBox.Image = global::SwitchMonitor.Properties.Resources.icon_search;
            this.searchPictureBox.Location = new System.Drawing.Point(479, 22);
            this.searchPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(16, 16);
            this.searchPictureBox.TabIndex = 2;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Cue = "חיפוש לפי שם או IP...";
            this.searchBox.Location = new System.Drawing.Point(6, 19);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(470, 23);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // eventsGroupBox
            // 
            this.eventsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(299, 514);
            this.eventsGroupBox.TabIndex = 0;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "אירועים אחרונים";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 538);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Switch Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.deviceContextMenu.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.devicesGroupBox.ResumeLayout(false);
            this.devicesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
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
        private CueTextBox searchBox;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripItem;
    }
}

