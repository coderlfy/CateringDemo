using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service.threads
{
    class IndexThread : AbstractThread
    {
        public IndexThread(bool enableStop)
            : base(enableStop)
        {

        }

        public override void Start()
        {
            #region
            int secondsinterval = 3600 * 1;
            base.StartWhile(() =>
            {
                LuceneNetHelper.GlobalInfo.ResetIndex();
                Catering.Service.Index.IndexOpery.CreateIndex();
            }, secondsinterval);

            #endregion
        }
    }
}
