namespace CAG_CHANGE_LINE
{
    partial class Form1
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
            this.grb_TTM = new System.Windows.Forms.GroupBox();
            this.grb_QuickDNS = new System.Windows.Forms.GroupBox();
            this.cbb_basic = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dgv_DSTT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DoiMang = new System.Windows.Forms.Button();
            this.btn_gg = new System.Windows.Forms.Button();
            this.btn_cloudFare = new System.Windows.Forms.Button();
            this.btn_Viettel = new System.Windows.Forms.Button();
            this.btn_OpenDNS = new System.Windows.Forms.Button();
            this.btn_VNPT = new System.Windows.Forms.Button();
            this.btn_Singapore = new System.Windows.Forms.Button();
            this.btn_FPT = new System.Windows.Forms.Button();
            this.btn_Verizon = new System.Windows.Forms.Button();
            this.lbl_TenMay = new System.Windows.Forms.Label();
            this.lbl_IPAdd = new System.Windows.Forms.Label();
            this.lbl_NetMask = new System.Windows.Forms.Label();
            this.lbl_GetWay = new System.Windows.Forms.Label();
            this.lbl_DNS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_TenMang = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnu_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_ChinhSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_ReadMe = new System.Windows.Forms.ToolStripMenuItem();
            this.col_TNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DNS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DNS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_TTM.SuspendLayout();
            this.grb_QuickDNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTT)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_TTM
            // 
            this.grb_TTM.Controls.Add(this.label13);
            this.grb_TTM.Controls.Add(this.label11);
            this.grb_TTM.Controls.Add(this.lbl_TenMang);
            this.grb_TTM.Controls.Add(this.lbl_DNS);
            this.grb_TTM.Controls.Add(this.label10);
            this.grb_TTM.Controls.Add(this.lbl_GetWay);
            this.grb_TTM.Controls.Add(this.label9);
            this.grb_TTM.Controls.Add(this.label8);
            this.grb_TTM.Controls.Add(this.lbl_NetMask);
            this.grb_TTM.Controls.Add(this.label7);
            this.grb_TTM.Controls.Add(this.lbl_IPAdd);
            this.grb_TTM.Controls.Add(this.lbl_TenMay);
            this.grb_TTM.Location = new System.Drawing.Point(12, 24);
            this.grb_TTM.Name = "grb_TTM";
            this.grb_TTM.Size = new System.Drawing.Size(379, 161);
            this.grb_TTM.TabIndex = 0;
            this.grb_TTM.TabStop = false;
            this.grb_TTM.Text = "Thông Tin Mạng";
            this.grb_TTM.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grb_QuickDNS
            // 
            this.grb_QuickDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_QuickDNS.Controls.Add(this.btn_Verizon);
            this.grb_QuickDNS.Controls.Add(this.btn_Singapore);
            this.grb_QuickDNS.Controls.Add(this.btn_OpenDNS);
            this.grb_QuickDNS.Controls.Add(this.btn_cloudFare);
            this.grb_QuickDNS.Controls.Add(this.btn_FPT);
            this.grb_QuickDNS.Controls.Add(this.btn_VNPT);
            this.grb_QuickDNS.Controls.Add(this.btn_Viettel);
            this.grb_QuickDNS.Controls.Add(this.btn_gg);
            this.grb_QuickDNS.Location = new System.Drawing.Point(397, 100);
            this.grb_QuickDNS.Name = "grb_QuickDNS";
            this.grb_QuickDNS.Size = new System.Drawing.Size(391, 85);
            this.grb_QuickDNS.TabIndex = 0;
            this.grb_QuickDNS.TabStop = false;
            this.grb_QuickDNS.Text = "Đổi DNS nhanh";
            this.grb_QuickDNS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbb_basic
            // 
            this.cbb_basic.FormattingEnabled = true;
            this.cbb_basic.Location = new System.Drawing.Point(13, 191);
            this.cbb_basic.Name = "cbb_basic";
            this.cbb_basic.Size = new System.Drawing.Size(379, 21);
            this.cbb_basic.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(741, 191);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(48, 34);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "button1";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // dgv_DSTT
            // 
            this.dgv_DSTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TNM,
            this.col_Gateway,
            this.col_DNS1,
            this.col_DNS2,
            this.col_Ping,
            this.col_status});
            this.dgv_DSTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_DSTT.Location = new System.Drawing.Point(8, 231);
            this.dgv_DSTT.MultiSelect = false;
            this.dgv_DSTT.Name = "dgv_DSTT";
            this.dgv_DSTT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DSTT.RowHeadersVisible = false;
            this.dgv_DSTT.Size = new System.Drawing.Size(781, 207);
            this.dgv_DSTT.TabIndex = 3;
            this.dgv_DSTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSTT_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAG PRO";
            // 
            // btn_DoiMang
            // 
            this.btn_DoiMang.Location = new System.Drawing.Point(399, 192);
            this.btn_DoiMang.Name = "btn_DoiMang";
            this.btn_DoiMang.Size = new System.Drawing.Size(165, 23);
            this.btn_DoiMang.TabIndex = 5;
            this.btn_DoiMang.Text = "Đổi Mạng";
            this.btn_DoiMang.UseVisualStyleBackColor = true;
            // 
            // btn_gg
            // 
            this.btn_gg.Location = new System.Drawing.Point(6, 20);
            this.btn_gg.Name = "btn_gg";
            this.btn_gg.Size = new System.Drawing.Size(86, 23);
            this.btn_gg.TabIndex = 0;
            this.btn_gg.Text = "Google";
            this.btn_gg.UseVisualStyleBackColor = true;
            // 
            // btn_cloudFare
            // 
            this.btn_cloudFare.Location = new System.Drawing.Point(6, 48);
            this.btn_cloudFare.Name = "btn_cloudFare";
            this.btn_cloudFare.Size = new System.Drawing.Size(86, 23);
            this.btn_cloudFare.TabIndex = 0;
            this.btn_cloudFare.Text = "CloudFare";
            this.btn_cloudFare.UseVisualStyleBackColor = true;
            // 
            // btn_Viettel
            // 
            this.btn_Viettel.Location = new System.Drawing.Point(103, 20);
            this.btn_Viettel.Name = "btn_Viettel";
            this.btn_Viettel.Size = new System.Drawing.Size(86, 23);
            this.btn_Viettel.TabIndex = 0;
            this.btn_Viettel.Text = "Viettel";
            this.btn_Viettel.UseVisualStyleBackColor = true;
            // 
            // btn_OpenDNS
            // 
            this.btn_OpenDNS.Location = new System.Drawing.Point(103, 48);
            this.btn_OpenDNS.Name = "btn_OpenDNS";
            this.btn_OpenDNS.Size = new System.Drawing.Size(86, 23);
            this.btn_OpenDNS.TabIndex = 0;
            this.btn_OpenDNS.Text = "OpenDNS";
            this.btn_OpenDNS.UseVisualStyleBackColor = true;
            // 
            // btn_VNPT
            // 
            this.btn_VNPT.Location = new System.Drawing.Point(200, 20);
            this.btn_VNPT.Name = "btn_VNPT";
            this.btn_VNPT.Size = new System.Drawing.Size(86, 23);
            this.btn_VNPT.TabIndex = 0;
            this.btn_VNPT.Text = "VNPT";
            this.btn_VNPT.UseVisualStyleBackColor = true;
            // 
            // btn_Singapore
            // 
            this.btn_Singapore.Location = new System.Drawing.Point(200, 48);
            this.btn_Singapore.Name = "btn_Singapore";
            this.btn_Singapore.Size = new System.Drawing.Size(86, 23);
            this.btn_Singapore.TabIndex = 0;
            this.btn_Singapore.Text = "Singapore";
            this.btn_Singapore.UseVisualStyleBackColor = true;
            // 
            // btn_FPT
            // 
            this.btn_FPT.Location = new System.Drawing.Point(297, 20);
            this.btn_FPT.Name = "btn_FPT";
            this.btn_FPT.Size = new System.Drawing.Size(86, 23);
            this.btn_FPT.TabIndex = 0;
            this.btn_FPT.Text = "FPT";
            this.btn_FPT.UseVisualStyleBackColor = true;
            this.btn_FPT.Click += new System.EventHandler(this.btn_FPT_Click);
            // 
            // btn_Verizon
            // 
            this.btn_Verizon.Location = new System.Drawing.Point(297, 49);
            this.btn_Verizon.Name = "btn_Verizon";
            this.btn_Verizon.Size = new System.Drawing.Size(86, 23);
            this.btn_Verizon.TabIndex = 0;
            this.btn_Verizon.Text = "Verizon";
            this.btn_Verizon.UseVisualStyleBackColor = true;
            // 
            // lbl_TenMay
            // 
            this.lbl_TenMay.AutoSize = true;
            this.lbl_TenMay.Location = new System.Drawing.Point(102, 22);
            this.lbl_TenMay.Name = "lbl_TenMay";
            this.lbl_TenMay.Size = new System.Drawing.Size(35, 13);
            this.lbl_TenMay.TabIndex = 0;
            this.lbl_TenMay.Text = "label2";
            // 
            // lbl_IPAdd
            // 
            this.lbl_IPAdd.AutoSize = true;
            this.lbl_IPAdd.Location = new System.Drawing.Point(102, 43);
            this.lbl_IPAdd.Name = "lbl_IPAdd";
            this.lbl_IPAdd.Size = new System.Drawing.Size(35, 13);
            this.lbl_IPAdd.TabIndex = 0;
            this.lbl_IPAdd.Text = "label2";
            // 
            // lbl_NetMask
            // 
            this.lbl_NetMask.AutoSize = true;
            this.lbl_NetMask.Location = new System.Drawing.Point(102, 64);
            this.lbl_NetMask.Name = "lbl_NetMask";
            this.lbl_NetMask.Size = new System.Drawing.Size(35, 13);
            this.lbl_NetMask.TabIndex = 0;
            this.lbl_NetMask.Text = "label2";
            // 
            // lbl_GetWay
            // 
            this.lbl_GetWay.AutoSize = true;
            this.lbl_GetWay.Location = new System.Drawing.Point(102, 85);
            this.lbl_GetWay.Name = "lbl_GetWay";
            this.lbl_GetWay.Size = new System.Drawing.Size(35, 13);
            this.lbl_GetWay.TabIndex = 0;
            this.lbl_GetWay.Text = "label2";
            // 
            // lbl_DNS
            // 
            this.lbl_DNS.AutoSize = true;
            this.lbl_DNS.Location = new System.Drawing.Point(102, 106);
            this.lbl_DNS.Name = "lbl_DNS";
            this.lbl_DNS.Size = new System.Drawing.Size(35, 13);
            this.lbl_DNS.TabIndex = 0;
            this.lbl_DNS.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Máy: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "IP Addr: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "NetMask: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "GateWay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "DNS: ";
            // 
            // lbl_TenMang
            // 
            this.lbl_TenMang.AutoSize = true;
            this.lbl_TenMang.Location = new System.Drawing.Point(202, 134);
            this.lbl_TenMang.Name = "lbl_TenMang";
            this.lbl_TenMang.Size = new System.Drawing.Size(35, 13);
            this.lbl_TenMang.TabIndex = 0;
            this.lbl_TenMang.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Line Đang Dùng: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Menu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mnu_Menu
            // 
            this.mnu_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_ChinhSua,
            this.mni_ReadMe});
            this.mnu_Menu.Name = "mnu_Menu";
            this.mnu_Menu.Size = new System.Drawing.Size(50, 20);
            this.mnu_Menu.Text = "Menu";
            // 
            // mni_ChinhSua
            // 
            this.mni_ChinhSua.Name = "mni_ChinhSua";
            this.mni_ChinhSua.Size = new System.Drawing.Size(200, 22);
            this.mni_ChinhSua.Text = "Chỉnh ở đây nhá";
            // 
            // mni_ReadMe
            // 
            this.mni_ReadMe.Name = "mni_ReadMe";
            this.mni_ReadMe.Size = new System.Drawing.Size(200, 22);
            this.mni_ReadMe.Text = "Xin trân trọng giới thiệu";
            // 
            // col_TNM
            // 
            this.col_TNM.HeaderText = "Tên nhà mạng";
            this.col_TNM.Name = "col_TNM";
            // 
            // col_Gateway
            // 
            this.col_Gateway.HeaderText = "Gateway";
            this.col_Gateway.Name = "col_Gateway";
            // 
            // col_DNS1
            // 
            this.col_DNS1.HeaderText = "DNS1";
            this.col_DNS1.Name = "col_DNS1";
            // 
            // col_DNS2
            // 
            this.col_DNS2.HeaderText = "DNS2";
            this.col_DNS2.Name = "col_DNS2";
            // 
            // col_Ping
            // 
            this.col_Ping.HeaderText = "Ping";
            this.col_Ping.Name = "col_Ping";
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Trạng Thái";
            this.col_status.Name = "col_status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phần Mềm Chuyển Đổi Nhà Mạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phần Mềm Chuyển Đổi Nhà Mạng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DoiMang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DSTT);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cbb_basic);
            this.Controls.Add(this.grb_QuickDNS);
            this.Controls.Add(this.grb_TTM);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grb_TTM.ResumeLayout(false);
            this.grb_TTM.PerformLayout();
            this.grb_QuickDNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTT)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_TTM;
        private System.Windows.Forms.GroupBox grb_QuickDNS;
        private System.Windows.Forms.ComboBox cbb_basic;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgv_DSTT;
        private System.Windows.Forms.Button btn_Verizon;
        private System.Windows.Forms.Button btn_Singapore;
        private System.Windows.Forms.Button btn_OpenDNS;
        private System.Windows.Forms.Button btn_cloudFare;
        private System.Windows.Forms.Button btn_FPT;
        private System.Windows.Forms.Button btn_VNPT;
        private System.Windows.Forms.Button btn_Viettel;
        private System.Windows.Forms.Button btn_gg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DoiMang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DNS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_GetWay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_NetMask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_IPAdd;
        private System.Windows.Forms.Label lbl_TenMay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_TenMang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DNS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DNS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Menu;
        private System.Windows.Forms.ToolStripMenuItem mni_ChinhSua;
        private System.Windows.Forms.ToolStripMenuItem mni_ReadMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

