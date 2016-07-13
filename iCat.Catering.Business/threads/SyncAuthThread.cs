using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service.threads
{
    class SyncAuthThread : AbstractThread
    {
        public SyncAuthThread(bool enableStop)
            : base(enableStop)
        { 
        
        }
        public override void Start()
        {
            #region
            SystemAuthenticationCenter authcenter = new SystemAuthenticationCenter();
            base.StartWhile(() => {
                authcenter.SyncV1ToV2();
            }, 3600);
            #endregion
        }
    }
}
