using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FirstWeb.Web.Infrastructure
{
    public class Config
    {
        /// <summary>
        /// 获取配置项目value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetAppSettingsValue(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception e)
            {
                Log.Debug("获取配置项目value：" + e);
            }
            return null;
        }
        /// <summary>
        /// 微信appId
        /// </summary>
        public static string appId => GetAppSettingsValue("appId");

        /// <summary>
        /// 微信appSecret
        /// </summary>
        public static string appSecret => GetAppSettingsValue("appSecret");
    }
}