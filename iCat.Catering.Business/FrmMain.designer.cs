namespace Catering.Service
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDebugJson = new System.Windows.Forms.CheckBox();
            this.cbDebugSelectCountSql = new System.Windows.Forms.CheckBox();
            this.cbDebugSelectSql = new System.Windows.Forms.CheckBox();
            this.cbDebugSocket = new System.Windows.Forms.CheckBox();
            this.cbDebugThread = new System.Windows.Forms.CheckBox();
            this.ckbAutoStartService = new System.Windows.Forms.CheckBox();
            this.btnLocationErrorDir = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbServiceTotalSpan = new System.Windows.Forms.Label();
            this.lbServiveStartTimes = new System.Windows.Forms.Label();
            this.lbCurrentServiceTotalSpan = new System.Windows.Forms.Label();
            this.lbServiceStartTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPrevErrorTime = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbAppStartTotalSpan = new System.Windows.Forms.Label();
            this.lbAppStartTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnFlushCache = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFlushCache);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.ckbAutoStartService);
            this.tabPage1.Controls.Add(this.btnLocationErrorDir);
            this.tabPage1.Controls.Add(this.btnStopService);
            this.tabPage1.Controls.Add(this.btnStartService);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDebugJson);
            this.groupBox3.Controls.Add(this.cbDebugSelectCountSql);
            this.groupBox3.Controls.Add(this.cbDebugSelectSql);
            this.groupBox3.Controls.Add(this.cbDebugSocket);
            this.groupBox3.Controls.Add(this.cbDebugThread);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制台调试配置";
            // 
            // cbDebugJson
            // 
            this.cbDebugJson.AutoSize = true;
            this.cbDebugJson.Location = new System.Drawing.Point(38, 74);
            this.cbDebugJson.Name = "cbDebugJson";
            this.cbDebugJson.Size = new System.Drawing.Size(144, 16);
            this.cbDebugJson.TabIndex = 20;
            this.cbDebugJson.Text = "显示返回的Json字符串";
            this.cbDebugJson.UseVisualStyleBackColor = true;
            this.cbDebugJson.CheckedChanged += new System.EventHandler(this.cbDebugJson_CheckedChanged);
            // 
            // cbDebugSelectCountSql
            // 
            this.cbDebugSelectCountSql.AutoSize = true;
            this.cbDebugSelectCountSql.Location = new System.Drawing.Point(325, 52);
            this.cbDebugSelectCountSql.Name = "cbDebugSelectCountSql";
            this.cbDebugSelectCountSql.Size = new System.Drawing.Size(174, 16);
            this.cbDebugSelectCountSql.TabIndex = 19;
            this.cbDebugSelectCountSql.Text = "显示查询记录条数的SQL语句";
            this.cbDebugSelectCountSql.UseVisualStyleBackColor = true;
            this.cbDebugSelectCountSql.CheckedChanged += new System.EventHandler(this.cbDebugSelectCountSql_CheckedChanged);
            // 
            // cbDebugSelectSql
            // 
            this.cbDebugSelectSql.AutoSize = true;
            this.cbDebugSelectSql.Location = new System.Drawing.Point(38, 52);
            this.cbDebugSelectSql.Name = "cbDebugSelectSql";
            this.cbDebugSelectSql.Size = new System.Drawing.Size(138, 16);
            this.cbDebugSelectSql.TabIndex = 18;
            this.cbDebugSelectSql.Text = "显示检索方法SQL语句";
            this.cbDebugSelectSql.UseVisualStyleBackColor = true;
            this.cbDebugSelectSql.CheckedChanged += new System.EventHandler(this.cbDebugSelectSql_CheckedChanged);
            // 
            // cbDebugSocket
            // 
            this.cbDebugSocket.AutoSize = true;
            this.cbDebugSocket.Location = new System.Drawing.Point(325, 30);
            this.cbDebugSocket.Name = "cbDebugSocket";
            this.cbDebugSocket.Size = new System.Drawing.Size(144, 16);
            this.cbDebugSocket.TabIndex = 17;
            this.cbDebugSocket.Text = "显示系统消息调试信息";
            this.cbDebugSocket.UseVisualStyleBackColor = true;
            this.cbDebugSocket.CheckedChanged += new System.EventHandler(this.cbDebugSocket_CheckedChanged);
            // 
            // cbDebugThread
            // 
            this.cbDebugThread.AutoSize = true;
            this.cbDebugThread.Location = new System.Drawing.Point(38, 30);
            this.cbDebugThread.Name = "cbDebugThread";
            this.cbDebugThread.Size = new System.Drawing.Size(168, 16);
            this.cbDebugThread.TabIndex = 16;
            this.cbDebugThread.Text = "显示保存方法的数据库操作";
            this.cbDebugThread.UseVisualStyleBackColor = true;
            this.cbDebugThread.CheckedChanged += new System.EventHandler(this.cbDebugThread_CheckedChanged);
            // 
            // ckbAutoStartService
            // 
            this.ckbAutoStartService.AutoSize = true;
            this.ckbAutoStartService.Location = new System.Drawing.Point(22, 281);
            this.ckbAutoStartService.Name = "ckbAutoStartService";
            this.ckbAutoStartService.Size = new System.Drawing.Size(132, 16);
            this.ckbAutoStartService.TabIndex = 15;
            this.ckbAutoStartService.Text = "程序启动即开启服务";
            this.ckbAutoStartService.UseVisualStyleBackColor = true;
            this.ckbAutoStartService.CheckedChanged += new System.EventHandler(this.ckbAutoStartService_CheckedChanged);
            // 
            // btnLocationErrorDir
            // 
            this.btnLocationErrorDir.Location = new System.Drawing.Point(418, 277);
            this.btnLocationErrorDir.Name = "btnLocationErrorDir";
            this.btnLocationErrorDir.Size = new System.Drawing.Size(112, 23);
            this.btnLocationErrorDir.TabIndex = 14;
            this.btnLocationErrorDir.Text = "清除控制台日志";
            this.btnLocationErrorDir.UseVisualStyleBackColor = true;
            this.btnLocationErrorDir.Click += new System.EventHandler(this.btnLocationErrorDir_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(246, 277);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(80, 23);
            this.btnStopService.TabIndex = 13;
            this.btnStopService.Text = "暂停服务";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(160, 277);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(80, 23);
            this.btnStartService.TabIndex = 12;
            this.btnStartService.Text = "开启服务";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbServiceTotalSpan);
            this.groupBox2.Controls.Add(this.lbServiveStartTimes);
            this.groupBox2.Controls.Add(this.lbCurrentServiceTotalSpan);
            this.groupBox2.Controls.Add(this.lbServiceStartTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务状态";
            // 
            // lbServiceTotalSpan
            // 
            this.lbServiceTotalSpan.AutoSize = true;
            this.lbServiceTotalSpan.Location = new System.Drawing.Point(428, 51);
            this.lbServiceTotalSpan.Name = "lbServiceTotalSpan";
            this.lbServiceTotalSpan.Size = new System.Drawing.Size(23, 12);
            this.lbServiceTotalSpan.TabIndex = 9;
            this.lbServiceTotalSpan.Text = "N/A";
            // 
            // lbServiveStartTimes
            // 
            this.lbServiveStartTimes.AutoSize = true;
            this.lbServiveStartTimes.Location = new System.Drawing.Point(131, 51);
            this.lbServiveStartTimes.Name = "lbServiveStartTimes";
            this.lbServiveStartTimes.Size = new System.Drawing.Size(23, 12);
            this.lbServiveStartTimes.TabIndex = 8;
            this.lbServiveStartTimes.Text = "N/A";
            // 
            // lbCurrentServiceTotalSpan
            // 
            this.lbCurrentServiceTotalSpan.AutoSize = true;
            this.lbCurrentServiceTotalSpan.Location = new System.Drawing.Point(428, 26);
            this.lbCurrentServiceTotalSpan.Name = "lbCurrentServiceTotalSpan";
            this.lbCurrentServiceTotalSpan.Size = new System.Drawing.Size(41, 12);
            this.lbCurrentServiceTotalSpan.TabIndex = 7;
            this.lbCurrentServiceTotalSpan.Text = "未开启";
            // 
            // lbServiceStartTime
            // 
            this.lbServiceStartTime.AutoSize = true;
            this.lbServiceStartTime.Location = new System.Drawing.Point(131, 26);
            this.lbServiceStartTime.Name = "lbServiceStartTime";
            this.lbServiceStartTime.Size = new System.Drawing.Size(41, 12);
            this.lbServiceStartTime.TabIndex = 6;
            this.lbServiceStartTime.Text = "未开启";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "服务开启时刻：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "服务开启次数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "本次开启服务运行时长：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "服务运行总时长：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPrevErrorTime);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lbAppStartTotalSpan);
            this.groupBox1.Controls.Add(this.lbAppStartTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序状态";
            // 
            // lbPrevErrorTime
            // 
            this.lbPrevErrorTime.AutoSize = true;
            this.lbPrevErrorTime.Location = new System.Drawing.Point(131, 50);
            this.lbPrevErrorTime.Name = "lbPrevErrorTime";
            this.lbPrevErrorTime.Size = new System.Drawing.Size(185, 12);
            this.lbPrevErrorTime.TabIndex = 5;
            this.lbPrevErrorTime.Text = "本程序开启后还未出现任何错误！";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "近期产生错误时刻：";
            // 
            // lbAppStartTotalSpan
            // 
            this.lbAppStartTotalSpan.AutoSize = true;
            this.lbAppStartTotalSpan.Location = new System.Drawing.Point(428, 26);
            this.lbAppStartTotalSpan.Name = "lbAppStartTotalSpan";
            this.lbAppStartTotalSpan.Size = new System.Drawing.Size(23, 12);
            this.lbAppStartTotalSpan.TabIndex = 3;
            this.lbAppStartTotalSpan.Text = "N/A";
            // 
            // lbAppStartTime
            // 
            this.lbAppStartTime.AutoSize = true;
            this.lbAppStartTime.Location = new System.Drawing.Point(131, 26);
            this.lbAppStartTime.Name = "lbAppStartTime";
            this.lbAppStartTime.Size = new System.Drawing.Size(23, 12);
            this.lbAppStartTime.TabIndex = 2;
            this.lbAppStartTime.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "程序打开时刻：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "运行总时长：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // btnFlushCache
            // 
            this.btnFlushCache.Location = new System.Drawing.Point(332, 277);
            this.btnFlushCache.Name = "btnFlushCache";
            this.btnFlushCache.Size = new System.Drawing.Size(80, 23);
            this.btnFlushCache.TabIndex = 16;
            this.btnFlushCache.Text = "刷新缓存";
            this.btnFlushCache.UseVisualStyleBackColor = true;
            this.btnFlushCache.Click += new System.EventHandler(this.btnFlushCache_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "综合办公平台服务端";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox ckbAutoStartService;
        private System.Windows.Forms.Button btnLocationErrorDir;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbServiceTotalSpan;
        private System.Windows.Forms.Label lbServiveStartTimes;
        public System.Windows.Forms.Label lbCurrentServiceTotalSpan;
        public System.Windows.Forms.Label lbServiceStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPrevErrorTime;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label lbAppStartTotalSpan;
        public System.Windows.Forms.Label lbAppStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbDebugThread;
        private System.Windows.Forms.CheckBox cbDebugJson;
        private System.Windows.Forms.CheckBox cbDebugSelectCountSql;
        private System.Windows.Forms.CheckBox cbDebugSelectSql;
        private System.Windows.Forms.CheckBox cbDebugSocket;
        private System.Windows.Forms.Button btnFlushCache;

    }
}

