using System;
using System.Collections.Generic;
using System.Text;

namespace W9OAuth
{
    public class AppAuthenParameters
    {
        public static string AppName = "W9OAuth";

        public static string AndroidClientId = "246293466687-vb7sfp0omrkup08nhprt1641u30olt3g.apps.googleusercontent.com";

        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://www.accounts.google.com/oauth2/auth";
        public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        public static string AndroidRedirectUrl = "com.googleusercontent.apps.246293466687-vb7sfp0omrkup08nhprt1641u30olt3g:/oauth2redirect";
    }
}
