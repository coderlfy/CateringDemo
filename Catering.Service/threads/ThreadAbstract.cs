using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Catering.Service.threads
{
    enum ThreadStatus
    {
        Started,
        Stopped
    }
    abstract class AbstractThread
    {
        /// <summary>
        /// 构造函数设置线程的常开或常闭
        /// </summary>
        /// <param name="enableStop"></param>
        public AbstractThread(bool enableStop)
        {
            _enableStop = enableStop;
        }
        private readonly bool _enableStop;

        private ThreadStatus _status = ThreadStatus.Stopped;
        /// <summary>
        /// 线程的当前状态
        /// </summary>
        public ThreadStatus _Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public abstract void Start();

        /// <summary>
        /// 开启循环并执行主体功能
        /// </summary>
        /// <param name="method"></param>
        /// <param name="secondsInterval">执行间隔时间</param>
        public void StartWhile(
    Action method,
    int secondsInterval)
        {
            #region
            while (true)
            {
                if (!_enableStop ||
                    _status == ThreadStatus.Started)
                {
                    try
                    {
                        if (method != null)
                            method();
                    }
                    catch (Exception e)
                    {
                        LogInterface.Write(e.ToString());
                    }
                }
                System.Threading.Thread.Sleep(
                    TimeSpan.FromSeconds(secondsInterval));
            }
            #endregion
        }
        public void StartExec(
    Action method, string actionDescribe = "活动名称")
        {
            #region
            while (true)
            {
                if (!_enableStop ||
                    _status == ThreadStatus.Started)
                {
                    Stopwatch watch = new Stopwatch();
                    try
                    {
                        Console.WriteLine("【{0}】开始执行。", actionDescribe);
                        watch.Start();
                        if (method != null)
                            method();
                    }
                    catch (Exception e)
                    {
                        LogInterface.Write(e.ToString());
                    }
                    finally
                    {
                        watch.Stop();
                    }
                    Console.WriteLine("【{0}】执行完毕,消耗时长{1}毫秒。",
                        actionDescribe, watch.ElapsedMilliseconds);
                    break;
                }
                System.Threading.Thread.Sleep(
                    TimeSpan.FromSeconds(1));
            }
            #endregion
        }
    }

}
