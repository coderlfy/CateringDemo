using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service.threads
{
    class NoticeThread : AbstractThread
    {
        public NoticeThread(bool enableStop)
            : base(enableStop)
        { 
        
        }
        public override void Start()
        {
            #region
            NoticeSendLogBusiness sendlog = new NoticeSendLogBusiness(null);
            base.StartWhile(() => {
                sendlog.AutoRelease();
            }, 60);
            #endregion
        }
    }
}
