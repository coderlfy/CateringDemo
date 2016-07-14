using CustomSpring.Core;
using Foundation.Core;
using NormalDocumentOffice.WinServer.customize;
using NormalDocumentOffice.WinServer.threads;
using NormalDocumentOffice.WinServer.wcfhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSSocket;

namespace Catering.Service
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(
            object sender, EventArgs e)
        {
            #region
            this.InitUI();
            ThreadManager.InitThreads(this);

            if (this.ckbAutoStartService.Checked)
                btnStartService_Click(null, null);
            else
                setControls(false);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isServiceStarted"></param>
        private void setControls(
            bool isServiceStarted)
        {
            #region
            if (isServiceStarted)
            {
                this.lbServiceStartTime.Text = DateTime.Now.ToString();
            }
            else
            {
                this.lbServiceStartTime.Text = "未开启";
                this.lbCurrentServiceTotalSpan.Text = "未开启";
            }
            this.btnStartService.Enabled = (!isServiceStarted);
            this.btnStopService.Enabled = isServiceStarted;
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartService_Click(
            object sender, EventArgs e)
        {
            #region
            this.setControls(true);
            Host.Start();
            ThreadManager.StartAll();
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopService_Click(
            object sender, EventArgs e)
        {
            #region
            Host.Stop();
            ThreadManager.StopAll();
            this.setControls(false);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocationErrorDir_Click(
            object sender, EventArgs e)
        {
            Console.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbAutoStartService_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            CustomConfig._EnableAutoStartService =
                this.cbChanage(this.ckbAutoStartService,
                CustomConfig._KeyNameEnableAutoStartService);
            #endregion
        }

        private object cbChanage(
            CheckBox cb, string keyname)
        {
            #region
            object enable = cb.Checked;
            Config.Update(keyname, ref enable);
            return enable;
            #endregion
        }

        private void cbDebugThread_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            DebugConfig._EnableDebugThread = 
                this.cbChanage(this.cbDebugThread,
                DebugConfig._KeyNameEnableDebugThread
                );

            SpringManager._EnableViewSaveSql =
    Convert.ToBoolean(DebugConfig._EnableDebugThread);
            #endregion
        }

        private void cbDebugSocket_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            DebugConfig._EnableDebugSocket = 
                this.cbChanage(this.cbDebugSocket,
                DebugConfig._KeyNameEnableDebugSocket
                );

            TcpServerEx._EnableViewDebug =
    Convert.ToBoolean(DebugConfig._EnableDebugSocket);
            #endregion
        }

        private void cbDebugSelectSql_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            DebugConfig._EnableDebugSelectSql = 
                this.cbChanage(this.cbDebugSelectSql,
                DebugConfig._KeyNameEnableDebugSelectSql
                );

            SpringManager._EnableViewSelectSql =
    Convert.ToBoolean(DebugConfig._EnableDebugSelectSql);

            #endregion
        }

        private void cbDebugSelectCountSql_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            DebugConfig._EnableDebugSelectCountSql = 
                this.cbChanage(this.cbDebugSelectCountSql,
                DebugConfig._KeyNameEnableDebugSelectCountSql
                );

            SpringManager._EnableViewSelectCountSql =
                Convert.ToBoolean(DebugConfig._EnableDebugSelectCountSql);
            #endregion
        }

        private void cbDebugJson_CheckedChanged(
            object sender, EventArgs e)
        {
            #region
            DebugConfig._EnableDebugJson = 
                this.cbChanage(this.cbDebugJson,
                DebugConfig._KeyNameEnableDebugJson
                );

            JsonHelper._EnableViewJson =
                Convert.ToBoolean(DebugConfig._EnableDebugJson);
            #endregion
        }

        private void btnFlushCache_Click(
            object sender, EventArgs e)
        {
            #region
            new SystemBusiness("backgroundsystem").RefreshAllModulesCache();
            MessageBox.Show("缓存已刷新，客户端可进行刷新来获取最新数据！");
            #endregion
        }

    }
}
