using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace ExcelOpration_Log4Net
{
    public class Log
    {
        public Log()
        {
            //配置文件
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            //加载配置
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }

        public void Debug(string msg)
        {
            var debug = LogManager.GetLogger("debug");
            debug.Debug(msg);
        }

        public void Info(string msg)
        {
            var info = LogManager.GetLogger("info");
            info.Info(msg);
        }

        public void Error(string msg)
        {
            var error = LogManager.GetLogger("error");
            error.Error(msg);
        }

        public void Warn(string msg)
        {
            var warn = LogManager.GetLogger("warn");
            warn.Warn(msg);
        }
    }
}
