using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomSpring.Core
{
    public class SpringManager
    {
        private static IApplicationContext _springContext = null;
        public static bool _EnableViewSelectSql = false;
        public static bool _EnableViewSaveSql = true;
        public static bool _EnableViewSelectCountSql = false;
        private static void init()
        {
            if (_springContext == null)
                _springContext = ContextRegistry.GetContext();
            
        }

        public static object GetObject(string id)
        {
            init();
            return _springContext.GetObject(id);
        }
    }
}
