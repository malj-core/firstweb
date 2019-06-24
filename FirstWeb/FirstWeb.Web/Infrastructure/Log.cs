using System;

namespace FirstWeb.Web.Infrastructure
{
    public class Log
    {
        /// <summary>
        /// 写入操作日志到文件中
        /// </summary>
        /// <param name="ex">异常</param>
        public static void Debug(Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(ex.TargetSite.DeclaringType);

            log.Error(ex.TargetSite.Name, ex);
        }

        /// <summary>
        /// 写入操作日志到文件中
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex">异常</param>
        public static void Info(object msg, Exception ex = null)
        {
            var log = log4net.LogManager.GetLogger("INFO");

            if (ex == null)

                log.Info(msg);
            else

                log.Info(msg, ex);

        }

        /// <summary>
        /// 写入过程数据或说明到文件中，以便跟踪
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex">异常</param>
        public static void Debug(object msg, Exception ex = null)
        {
            var log = log4net.LogManager.GetLogger("DEBUG");

            if (ex == null)

                log.Debug(msg);
            else

                log.Debug(msg, ex);
        }
    }
}