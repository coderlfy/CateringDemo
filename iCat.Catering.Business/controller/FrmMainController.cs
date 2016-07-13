using CustomSpring.Core;
using Foundation.Core;
using Catering.Service.customize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSSocket;

namespace Catering.Service
{
    public partial class FrmMain
    {
        private void setTitle()
        {
            #region
            string appfullname = string.Format("{0} V{1}",
                CustomConfig._ApplicationName,
                CustomConfig._ApplicationVersion);

            this.Text = appfullname;
            #endregion
        }

        public void InitUI()
        {
            #region
            this.setTitle();
            this.setStatusIcon();

            this.lbAppStartTime.Text = DateTime.Now.ToString();
            this.ckbAutoStartService.Checked = Convert.ToBoolean(
                CustomConfig._EnableAutoStartService);
            this.cbDebugThread.Checked = Convert.ToBoolean(
                DebugConfig._EnableDebugThread);
            this.cbDebugSocket.Checked = Convert.ToBoolean(
                DebugConfig._EnableDebugSocket);
            this.cbDebugSelectSql.Checked = Convert.ToBoolean(
                DebugConfig._EnableDebugSelectSql);
            this.cbDebugSelectCountSql.Checked = Convert.ToBoolean(
                DebugConfig._EnableDebugSelectCountSql);
            this.cbDebugJson.Checked = Convert.ToBoolean(
                DebugConfig._EnableDebugJson);

            SpringManager._EnableViewSelectSql =
    Convert.ToBoolean(DebugConfig._EnableDebugSelectSql);
            SpringManager._EnableViewSelectCountSql =
                Convert.ToBoolean(DebugConfig._EnableDebugSelectCountSql);
            JsonHelper._EnableViewJson =
                Convert.ToBoolean(DebugConfig._EnableDebugJson);

            SpringManager._EnableViewSaveSql =
Convert.ToBoolean(DebugConfig._EnableDebugThread);
            TcpServerEx._EnableViewDebug =
    Convert.ToBoolean(DebugConfig._EnableDebugSocket);

            #endregion
        }

        private void setStatusIcon()
        {
            #region
            WinIconStatus statusicon = new WinIconStatus("app.ico");
            statusicon.SetIconStatusMode(IconStatusMode.Normal);
            statusicon.BindToWindow(this);
            #endregion
        }

    }
}
