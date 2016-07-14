using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service.threads
{
    class RefreshBusinessCacheThread : AbstractThread
    {
        public RefreshBusinessCacheThread(bool enableStop)
            : base(enableStop)
        { 
        
        }
        public override void Start()
        {
            #region
            base.StartWhile(() =>
            {
                CachePoolBusiness.Refresh();
            }, 60*60);
            #endregion
        }

    }
}
