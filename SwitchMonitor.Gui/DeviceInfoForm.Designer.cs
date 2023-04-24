namespace SwitchMonitor
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
            this.deviceIcon = new System.Windows.Forms.PictureBox();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceAddressBox = new System.Windows.Forms.TextBox();
            this.eventsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.deviceIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceIcon
            // 
            this.deviceIcon.Location = new System.Drawing.Point(12, 12);
            this.deviceIcon.Name = "deviceIcon";
            this.deviceIcon.Size = new System.Drawing.Size(64, 64);
            this.deviceIcon.TabIndex = 0;
            this.deviceIcon.TabStop = false;
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameLabel.Location = new System.Drawing.Point(82, 28);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(147, 32);
            this.deviceNameLabel.TabIndex = 1;
            this.deviceNameLabel.Text = "deviceName";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.86302F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13698F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deviceAddressBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 234);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "כתובת IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceAddressBox
            // 
            this.deviceAddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceAddressBox.Location = new System.Drawing.Point(80, 3);
            this.deviceAddressBox.Name = "deviceAddressBox";
            this.deviceAddressBox.ReadOnly = true;
            this.deviceAddressBox.Size = new System.Drawing.Size(170, 23);
            this.deviceAddressBox.TabIndex = 1;
            // 
            // eventsGroupBox
            // 
            this.eventsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsGroupBox.Location = new System.Drawing.Point(332, 12);
            this.eventsGroupBox.Name = "eventsGroupBox";
            this.eventsGroupBox.Size = new System.Drawing.Size(271, 304);
            this.eventsGroupBox.TabIndex = 3;
            this.eventsGroupBox.TabStop = false;
            this.eventsGroupBox.Text = "אירועים של הרכיב הזה";
            // 
            // DeviceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 328);
            this.Controls.Add(this.eventsGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deviceNameLabel);
            this.Controls.Add(this.deviceIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeviceInfoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "מידע על הרכיב";
            ((System.ComponentModel.ISupportInitialize)(this.deviceIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deviceIcon;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox eventsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceAddressBox;
    }
}