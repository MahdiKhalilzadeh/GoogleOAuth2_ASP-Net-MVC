using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace OAuthGoogle.Classes
{
    public class GoogleApiHelper
    {
        public static string ApplicationName = "MyApplication";
        public static string ClientID = "353108713002-3tsf51c4bncle9jqg8ejuskq0m6fo8gs.apps.googleusercontent.com";
        public static string ClientSercter = "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";
        public static string RediretUrl = "http://localhost:39319/Home/OAuthCallback";
        public static string OAuthUrl = "https://accounts.google.com/o/oauth2/auth?";
        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string GetOAuthUrl(string extraParam)
        {
            StringBuilder sb = new StringBuilder(OAuthUrl);
            sb.Append("client_id=" + ClientID);
            sb.Append("&redirect_uri=" + RediretUrl);
            sb.Append("&response_type=code");
            sb.Append("&scope=" + Scope);
            sb.Append("&access_type=offline");
            sb.Append("&state=" + extraParam);
            return sb.ToString();
        }
    }
}