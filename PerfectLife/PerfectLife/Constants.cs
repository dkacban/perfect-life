﻿namespace PerfectLife
{
    public static class Constants
    {
        // OAuth
        public static string ClientId = "";
        public static string ClientSecret = "";

        //Web Service
        public static string WebServiceServer = "";

        // These values do not need changing
        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string AccessTokenUrl = "https://accounts.google.com/o/oauth2/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set this property to the location the user will be redirected too after successfully authenticating
        public static string RedirectUrl = "http://www.example.com/oauth2";
    }
}
