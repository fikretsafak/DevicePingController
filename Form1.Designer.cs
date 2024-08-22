namespace DevicePingController
{
    partial class Form_Main
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
            this.devNameLbl = new System.Windows.Forms.TextBox();
            this.DevIPlbl = new System.Windows.Forms.TextBox();
            this.DeviceAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.devList = new System.Windows.Forms.ListView();
            this.DevNameLst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DevIPLst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeviceImportBtn = new System.Windows.Forms.Button();
            this.DeviceExportBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pingStatDGW = new System.Windows.Forms.DataGridView();
            this.DeviceDGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAddressDGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pingStatDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // devNameLbl
            // 
            this.devNameLbl.Location = new System.Drawing.Point(13, 244);
            this.devNameLbl.Name = "devNameLbl";
            this.devNameLbl.Size = new System.Drawing.Size(127, 20);
            this.devNameLbl.TabIndex = 1;
            // 
            // DevIPlbl
            // 
            this.DevIPlbl.Location = new System.Drawing.Point(146, 244);
            this.DevIPlbl.Name = "DevIPlbl";
            this.DevIPlbl.Size = new System.Drawing.Size(125, 20);
            this.DevIPlbl.TabIndex = 2;
            // 
            // DeviceAddButton
            // 
            this.DeviceAddButton.Location = new System.Drawing.Point(12, 270);
            this.DeviceAddButton.Name = "DeviceAddButton";
            this.DeviceAddButton.Size = new System.Drawing.Size(259, 23);
            this.DeviceAddButton.TabIndex = 3;
            this.DeviceAddButton.Text = "Device Add";
            this.DeviceAddButton.UseVisualStyleBackColor = true;
            this.DeviceAddButton.Click += new System.EventHandler(this.DeviceAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Address";
            // 
            // devList
            // 
            this.devList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DevNameLst,
            this.DevIPLst});
            this.devList.HideSelection = false;
            this.devList.Location = new System.Drawing.Point(15, 12);
            this.devList.Name = "devList";
            this.devList.Size = new System.Drawing.Size(246, 211);
            this.devList.TabIndex = 6;
            this.devList.UseCompatibleStateImageBehavior = false;
            this.devList.View = System.Windows.Forms.View.Details;
            this.devList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.devList_MouseDoubleClick_1);
            // 
            // DevNameLst
            // 
            this.DevNameLst.Text = "Device Name";
            this.DevNameLst.Width = 100;
            // 
            // DevIPLst
            // 
            this.DevIPLst.Text = "Device IP";
            this.DevIPLst.Width = 140;
            // 
            // DeviceImportBtn
            // 
            this.DeviceImportBtn.Location = new System.Drawing.Point(13, 299);
            this.DeviceImportBtn.Name = "DeviceImportBtn";
            this.DeviceImportBtn.Size = new System.Drawing.Size(259, 23);
            this.DeviceImportBtn.TabIndex = 7;
            this.DeviceImportBtn.Text = "Device Import";
            this.DeviceImportBtn.UseVisualStyleBackColor = true;
            this.DeviceImportBtn.Click += new System.EventHandler(this.DeviceImportBtn_Click);
            // 
            // DeviceExportBtn
            // 
            this.DeviceExportBtn.Location = new System.Drawing.Point(13, 328);
            this.DeviceExportBtn.Name = "DeviceExportBtn";
            this.DeviceExportBtn.Size = new System.Drawing.Size(259, 23);
            this.DeviceExportBtn.TabIndex = 8;
            this.DeviceExportBtn.Text = "Device Export";
            this.DeviceExportBtn.UseVisualStyleBackColor = true;
            this.DeviceExportBtn.Click += new System.EventHandler(this.DeviceExportBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pingStatDGW
            // 
            this.pingStatDGW.AllowUserToAddRows = false;
            this.pingStatDGW.AllowUserToDeleteRows = false;
            this.pingStatDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pingStatDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceDGW,
            this.IpAddressDGW,
            this.StatusDGW});
            this.pingStatDGW.Location = new System.Drawing.Point(267, 12);
            this.pingStatDGW.Name = "pingStatDGW";
            this.pingStatDGW.Size = new System.Drawing.Size(521, 211);
            this.pingStatDGW.TabIndex = 9;
            // 
            // DeviceDGW
            // 
            this.DeviceDGW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceDGW.HeaderText = "Device Name";
            this.DeviceDGW.Name = "DeviceDGW";
            this.DeviceDGW.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IpAddressDGW
            // 
            this.IpAddressDGW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IpAddressDGW.HeaderText = "Device IP";
            this.IpAddressDGW.Name = "IpAddressDGW";
            // 
            // StatusDGW
            // 
            this.StatusDGW.HeaderText = "Ping Status";
            this.StatusDGW.Name = "StatusDGW";
            this.StatusDGW.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pingBtn
            // 
            this.pingBtn.Location = new System.Drawing.Point(288, 244);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(259, 23);
            this.pingBtn.TabIndex = 10;
            this.pingBtn.Text = "Device Add";
            this.pingBtn.UseVisualStyleBackColor = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.pingBtn);
            this.Controls.Add(this.pingStatDGW);
            this.Controls.Add(this.DeviceExportBtn);
            this.Controls.Add(this.DeviceImportBtn);
            this.Controls.Add(this.devList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceAddButton);
            this.Controls.Add(this.DevIPlbl);
            this.Controls.Add(this.devNameLbl);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pingStatDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox devNameLbl;
        private System.Windows.Forms.TextBox DevIPlbl;
        private System.Windows.Forms.Button DeviceAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView devList;
        private System.Windows.Forms.ColumnHeader DevNameLst;
        private System.Windows.Forms.ColumnHeader DevIPLst;
        private System.Windows.Forms.Button DeviceImportBtn;
        private System.Windows.Forms.Button DeviceExportBtn;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView pingStatDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddressDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDGW;
        private System.Windows.Forms.Button pingBtn;
    }
}

