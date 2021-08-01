using System;
using System.Web;

namespace _21_CS_NH.Infrastructure
{
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request, string key, int fallbackValue = 0)
        {
            if (!string.IsNullOrEmpty(request.QueryString[key]))
            {
                fallbackValue = Convert.ToInt32(HttpContext.Current.Request.QueryString[key]);
            }
            return fallbackValue;
        }
    }
}