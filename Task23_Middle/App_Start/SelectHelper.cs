using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task23_Middle.App_Start
{
    public static class SelectHelper
    {
        public static MvcHtmlString CreateSelect(this HtmlHelper html, List<KeyValuePair<string, KeyValuePair<string, string>>> items)
        {
            var mainTag = new TagBuilder("div");

            foreach (var item in items)
            {
                var div = new TagBuilder("div");
                var topic = new TagBuilder("div");
                var date = new TagBuilder("div");
                var user = new TagBuilder("div");
                topic.InnerHtml=item.Key;
                date.InnerHtml = item.Value.Value;
                user.InnerHtml = item.Value.Key;
            }

            return MvcHtmlString.Create(mainTag.ToString());
        }
    }
}