using Newtonsoft.Json;
using WeChat.WebApi.Entities;
using WeChat.WebApi.Utils;

namespace WeChat.WebApi
{
    public class WeChatRepository
    {
        /// <summary>
        /// 获取access_token、openId
        /// </summary>
        /// <param name="code"></param>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns></returns>
        public static AccessToken GetToken(string code, string appId, string appSecret)
        {
            var url =
                $"https://api.weixin.qq.com/sns/oauth2/access_token?appid={appId}&secret={appSecret}&code={code}&grant_type=authorization_code";

            var str = HttpHelper.GetResponse<AccessToken>(url);
            return str;
        }
        /// <summary>
        /// 获取微信用户信息
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static WechatUserInfo GetUserInfo(string openId, string token)
        {
            var url = $"https://api.weixin.qq.com/sns/userinfo?access_token={token}&openid={openId}&lang=zh_CN";

            var result = HttpHelper.GetResponse(url);

            if (string.IsNullOrEmpty(result))
                return null;

            var info = JsonConvert.DeserializeObject<WechatUserInfo>(result);

            return info;
        }
    }
}
