﻿namespace SwitchMonitor
{
    partial class DeviceInfoForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceAddressBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.muteCheckbox = new System.Windows.Forms.CheckBox();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            this.deviceNameBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.revertButton = new System.Windows.Forms.ToolStripButton();
            this.deviceIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastPingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pingIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingIntervalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.44664F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55336F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deviceAddressBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.muteCheckbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lastPingLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pingIntervalBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 271);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(256, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "השתק";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(256, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "הערות";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "כתובת IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceAddressBox
            // 
            this.deviceAddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceAddressBox.Location = new System.Drawing.Point(55, 3);
            this.deviceAddressBox.Name = "deviceAddressBox";
            this.deviceAddressBox.ReadOnly = true;
            this.deviceAddressBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deviceAddressBox.Size = new System.Drawing.Size(195, 23);
            this.deviceAddressBox.TabIndex = 1;
            this.deviceAddressBox.Click += new System.EventHandler(this.deviceAddressBox_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBox.Location = new System.Drawing.Point(55, 33);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.descriptionBox, 3);
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionBox.Size = new System.Drawing.Size(195, 84);
            this.descriptionBox.TabIndex = 2;
            // 
            // muteCheckbox
            // 
            this.muteCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.muteCheckbox.Enabled = false;
            this.muteCheckbox.Location = new System.Drawing.Point(55, 123);
            this.muteCheckbox.Name = "muteCheckbox";
            this.muteCheckbox.Size = new System.Drawing.Size(195, 24);
            this.muteCheckbox.TabIndex = 5;
            this.muteCheckbox.UseVisualStyleBackColor = true;
            // 
            // eventsGroupBox
            // 
            this.eventsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsGroupBox.Location = new System.Drawing.Point(375, 28);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(232, 374);
            this.eventsGroupBox.TabIndex = 3;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "אירועים של הרכיב הזה";
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.deviceNameBox.Location = new System.Drawing.Point(82, 41);
            this.deviceNameBox.Name = "deviceNameBox";
            this.deviceNameBox.ReadOnly = true;
            this.deviceNameBox.Size = new System.Drawing.Size(287, 39);
            this.deviceNameBox.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editButton,
            this.toolStripSeparator1,
            this.saveButton,
            this.revertButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // editButton
            // 
            this.editButton.Image = global::SwitchMonitor.Properties.Resources.icon_edit;
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(51, 22);
            this.editButton.Text = "ערוך";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::SwitchMonitor.Properties.Resources.icon_save;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(54, 22);
            this.saveButton.Text = "שמור";
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // revertButton
            // 
            this.revertButton.Enabled = false;
            this.revertButton.Image = global::SwitchMonitor.Properties.Resources.icon_undo;
            this.revertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(49, 22);
            this.revertButton.Text = "בטל";
            this.revertButton.Visible = false;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // deviceIcon
            // 
            this.deviceIcon.Location = new System.Drawing.Point(12, 28);
            this.deviceIcon.Name = "deviceIcon";
            this.deviceIcon.Size = new System.Drawing.Size(64, 64);
            this.deviceIcon.TabIndex = 0;
            this.deviceIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(256, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "פינג מוצלח אחרון";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastPingLabel
            // 
            this.lastPingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastPingLabel.Location = new System.Drawing.Point(55, 180);
            this.lastPingLabel.Name = "lastPingLabel";
            this.lastPingLabel.Size = new System.Drawing.Size(195, 30);
            this.lastPingLabel.TabIndex = 9;
            this.lastPingLabel.Text = "label5";
            this.lastPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(256, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "הפסקה בין פינגים\r\n(שניות)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pingIntervalBox
            // 
            this.pingIntervalBox.Enabled = false;
            this.pingIntervalBox.Location = new System.Drawing.Point(177, 153);
            this.pingIntervalBox.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.pingIntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pingIntervalBox.Name = "pingIntervalBox";
            this.pingIntervalBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pingIntervalBox.Size = new System.Drawing.Size(73, 23);
            this.pingIntervalBox.TabIndex = 11;
            this.pingIntervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DeviceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 414);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.deviceNameBox);
            this.Controls.Add(this.eventsGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deviceIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeviceInfoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "פרטי רכיב";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceInfoForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingIntervalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deviceIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox eventsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceAddressBox;
        private System.Windows.Forms.TextBox deviceNameBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton revertButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox muteCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastPingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown pingIntervalBox;
    }
}