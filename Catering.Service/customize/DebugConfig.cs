using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service.customize
{
    public class DebugConfig
    {
        public const string _KeyNameEnableDebugThread = "EnableDebugThread";
        public const string _KeyNameEnableDebugSocket = "EnableDebugSocket";
        public const string _KeyNameEnableDebugSelectSql = "EnableDebugSelectSql";
        public const string _KeyNameEnableDebugSelectCountSql = "EnableDebugSelectCountSql";
        public const string _KeyNameEnableDebugJson = "EnableDebugJson";

        private static object _enableDebugThread = false;
        public static object _EnableDebugThread
        {
            get { return _enableDebugThread; }
            set { _enableDebugThread = value; }
        }

        private static object _enableDebugSocket = false;
        public static object _EnableDebugSocket
        {
            get { return _enableDebugSocket; }
            set { _enableDebugSocket = value; }
        }

        private static object _enableDebugSelectSql = false;
        public static object _EnableDebugSelectSql
        {
            get { return _enableDebugSelectSql; }
            set { _enableDebugSelectSql = value; }
        }

        private static object _enableDebugSelectCountSql = false;
        public static object _EnableDebugSelectCountSql
        {
            get { return _enableDebugSelectCountSql; }
            set { _enableDebugSelectCountSql = value; }
        }

        private static object _enableDebugJson = false;
        public static object _EnableDebugJson
        {
            get { return _enableDebugJson; }
            set { _enableDebugJson = value; }
        }

        public static void Init()
        {
            Config.Get(_KeyNameEnableDebugThread, ref _enableDebugThread);
            Config.Get(_KeyNameEnableDebugSocket, ref _enableDebugSocket);
            Config.Get(_KeyNameEnableDebugSelectSql, ref _enableDebugSelectSql);
            Config.Get(_KeyNameEnableDebugSelectCountSql, ref _enableDebugSelectCountSql);
            Config.Get(_KeyNameEnableDebugJson, ref _enableDebugJson);
        }

    }
}
